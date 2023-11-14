#include <mega32.h>
#include <io.h>
#include <stdlib.h>
#include <stdio.h>
#include <delay.h>
#include <alcd.h>


char str[10];
void main(void)
{
UCSRB=0x10;
UCSRC=0x86;
UBRRH=0;
UBRRL=71;
lcd_init(16);
while (1)
      {
      gets(str,10);
      lcd_clear();
      lcd_puts(str);
      }
}
