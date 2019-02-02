// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            int Number1, Number2, Sum;
            Console.Write("To print the sum of two numbers, enter the first number:");
            Number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            Number2 = int.Parse(Console.ReadLine());
            Sum = Number1 + Number2;
            Console.WriteLine("The sum of " + Number1 + " and " + Number2 + " is " + Sum + ".");
        }
    }
}