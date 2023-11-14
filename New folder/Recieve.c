#include <mega32.h>
#include <delay.h>
#include <stdio.h>
#include <stdlib.h>

float Temperature,duty,t;
char str[10];
void main(void)
{
DDRD.0=0;
DDRC = 0xFF;
DDRA.0=1;
UCSRB = 0x10;
UCSRC = 0x86;
UBRRL = 71;
UBRRH = 0;


while (1){
   gets(str,10);
   Temperature = atof(str);
   duty = (25*Temperature - 575)/100; 
   while(1){
    gets(str,10);
    t = atof(str);
    if(t != Temperature)
        break;
    else{ 
        if(duty>0 && duty<1 ){ 
            PORTA.0=0;
            PORTC = 0x01;
            delay_ms(50*duty);
            PORTC = 0x00;
            delay_ms((1-duty)*50);
            }
        else if(duty>=1)   
            {
            PORTC = 0x01;
            PORTA.0=1;
            }
        else
        {   
         PORTC = 0x00;
         PORTA.0=0;
         }
    }
   }  
   
}
      
}
