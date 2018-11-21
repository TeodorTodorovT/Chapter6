using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
                Console.WriteLine(i);


            Console.ReadLine();


        }
    }
}
