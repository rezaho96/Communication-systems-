#include <mega32.h>
#include <stdlib.h>
#include <delay.h>
#include <stdio.h>
#include <lcd.h>
#include <spi.h>

#asm
    .equ __lcd_port = 0x15;
#endasm


float Tempreture,T;
char c,str[10];

#define ADC_VREF_TYPE ((0<<REFS1) | (1<<REFS0) | (0<<ADLAR))

unsigned int read_adc(unsigned char adc_input)
{
ADMUX=adc_input | ADC_VREF_TYPE;
delay_us(10);
ADCSRA|=(1<<ADSC);
while ((ADCSRA & (1<<ADIF))==0);
ADCSRA|=(1<<ADIF);
return ADCW;
}


void main(void)
{
lcd_init(16);
DDRB = 0xB0;
PORTB.4=1;
   
//ACSR=(1<<ACD) | (0<<ACBG) | (0<<ACO) | (0<<ACI) | (0<<ACIE) | (0<<ACIC) | (0<<ACIS1) | (0<<ACIS0);
ADMUX=ADC_VREF_TYPE;
ADCSRA=(1<<ADEN) | (0<<ADSC) | (0<<ADATE) | (0<<ADIF) | (0<<ADIE) | (0<<ADPS2) | (1<<ADPS1) | (1<<ADPS0);
DDRA=(0<<DDA7) | (0<<DDA6) | (0<<DDA5) | (0<<DDA4) | (0<<DDA3) | (0<<DDA2) | (0<<DDA1) | (0<<DDA0);
PORTA=(0<<PORTA7) | (0<<PORTA6) | (0<<PORTA5) | (0<<PORTA4) | (0<<PORTA3) | (0<<PORTA2) | (0<<PORTA1) | (0<<PORTA0);

Tempreture = read_adc(0)/2.054;

while (1){
    
    T = read_adc(0)/2.054;
    while(Tempreture != T){
    while(PINB.0==0);
    SPCR = 0x71;
    c = T;
    PORTB.4 = 0;
    SPDR = c;   
    while(SPSR.SPIF == 0);
    SPCR = 0X00;
    delay_ms(10);
    PORTB.4 = 1;
    Tempreture = T;
    lcd_clear();
    lcd_puts("Tempreture = ");
    ftoa(T,0,str);
    lcd_puts(str);
    }   
       
    
}
     
}