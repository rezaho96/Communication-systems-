#include <mega32.h>
#include <io.h>
#include <stdlib.h>
#include <stdio.h>
#include <delay.h>
int n;
char str[4];
void main(void)
{
UCSRB=0x08;
UCSRC=0x86;
UBRRH=0;
UBRRL=71;
DDRB=0x00;
     

while (1)
      {
      n=PINB;
      itoa(n,str);
      puts(str);
      delay_ms(500);

      }
}
