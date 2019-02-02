// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            int Number1, Number2, Number3, Product;
            Console.Write("To print the multiplication of three numbers, enter the number1:");
            Number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number:");
            Number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third nu number:");
            Number3 = int.Parse(Console.ReadLine());
            Product = Number1 * Number2 * Number3;
            Console.Write("The product of " + Number1 + ", " + Number2 + " and " + Number3 + " is " + Product + ".");
        }
    }
}