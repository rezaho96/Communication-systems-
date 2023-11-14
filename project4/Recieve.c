#include <mega32.h>
#include <delay.h>
#include <stdio.h>
#include <stdlib.h>
#include <lcd.h>

#asm
    .equ __lcd_port = 0x1B;
#endasm

float Tempreture1=0,Tempreture2=0,T=0,Duty;
char str[10];

interrupt[13] void SPI_INT(void){
    if(PIND.0 == 0)
            Tempreture1 = SPDR;
        if(PIND.1 == 0)
            Tempreture2 = SPDR;
        T = (Tempreture1+Tempreture2)/2; 
        ftoa(T,3,str); 
        lcd_clear();
        lcd_puts("Tempreture = ");
        lcd_puts(str);
        Duty = (25*T - 575)/100;
        ftoa(Duty,3,str);
        SPSR.SPIF = 0;
}


void main(void)
{
lcd_init(16);

DDRD = 0x00;
DDRB = 0x40;
DDRC = 0xFF;
SPCR = 0xE1;

#asm("sei")

while (1){
                 
    if(Duty>0 && Duty<1){
        PORTC = 0x01;
        delay_ms(50*Duty);
        PORTC = 0x00;
        delay_ms((1-Duty)*50);
    }
    else if(Duty>=1)   
        PORTC = 0x01;
    else
        PORTC = 0x00;
    
 }       
}
