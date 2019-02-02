// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            int Count;
            Console.Write("How many natural numbers do you want to print?");
            Count = int.Parse(Console.ReadLine());
            Console.Write("The first " + Count + " natural numbers are");
            for(int Counter = 1; Counter <= Count; Counter++)
            {
              Console.Write(" " + Counter);
            }
            Console.WriteLinesum.pv(".");
        }
    }
}