#include <stdio.h>

int main(void)
{
  int Count, Counter;
  printf("How many natural numbers do you want to print?");
  scanf("%d", &Count);
  printf("The natural numbers upto %d are", Count);
  for(Counter = 1; Counter <= Count; Counter++)
  {
    printf(" %d", Counter);
  }
  printf(".\n");
  return 0;
}