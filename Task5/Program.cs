using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            int firstN = 0, secondN = 1, thirdN = 0;

            Console.Write("Enter N: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for (int i = 2; i < length; i++)
            {
                thirdN = firstN + secondN;
                Console.Write(" {0},", thirdN);
                firstN = secondN;
                secondN = thirdN;
            }
            Console.ReadLine();
        }   
    }
}
