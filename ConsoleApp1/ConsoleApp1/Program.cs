using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Hello World!");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                
        }
    }
}
