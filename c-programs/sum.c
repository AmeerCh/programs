#include <stdio.h>

int main(void)
{
    int Number1, Number2, Sum = 0;
    printf("To print the sum of two numbers, enter the first number: ");
    scanf("%d", &Number1);
    printf("Enter the second number: ");
    scanf("%d", &Number2);
    Sum = Number1 + Number2;
    printf("The sum of two numbers %d and %d is %d.\n", Number1, Number2, Sum);
    return 0;
}