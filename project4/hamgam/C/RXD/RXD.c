#include <mega32.h>
#include <delay.h>
#include <stdio.h>
#include <stdlib.h>

float temp,temp1;
char str[10];
float D;
void main(void)
{
DDRD.0=0;
DDRC = 0xFF;

UCSRB = 0x10;
UCSRC = 0x86;
UBRRL = 71;
UBRRH = 0;


while (1){
   gets(str,10);
   temp = atof(str);
   D = (25*temp - 575)/100; 
   while(1){
    gets(str,10);
    temp1 = atof(str);
    if(temp1 != temp)
        break;
    else{ 
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
   
   //delay_ms(50);
}
      
}
