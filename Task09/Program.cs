using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that for a given integers n and x, calculates the sum {formula}
            int sum = 1, temp = 1;
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Result is {0}", sum);
            Console.ReadLine();
        }
    }
}
