#include <mega32.h>
#include <delay.h>
#include <stdio.h>
#include <stdlib.h>
#include <lcd.h>

#asm
    .equ __lcd_port = 0x1B;
#endasm

float temp0=0,temp1=0;
float mytemp=0,D=0;
char str[10];

interrupt[13] void SPI_INT(void){
    if(PIND.0 == 0)
            temp0 = SPDR;
        if(PIND.1 == 0)
            temp1 = SPDR;
        mytemp = (temp0+temp1)/2; 
        ftoa(mytemp,3,str); 
        lcd_clear();
        lcd_puts("mytemp = ");
        lcd_puts(str);
        D = (25*mytemp - 575)/100;
        lcd_puts(" D= ");
        ftoa(D,3,str);
        lcd_puts(str);
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
                 
    if(D<1 && D>0){
        PORTC = 0x01;
        delay_ms(50*D);
        PORTC = 0x00;
        delay_ms((1-D)*50);
    }
    else if(D>=1)   
        PORTC = 0x01;
    else
        PORTC = 0x00;
    
 }       
}
