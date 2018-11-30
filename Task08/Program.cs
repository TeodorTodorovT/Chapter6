using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that calculates the n-th Catalan number by given n. {formula}
            Console.Write("Enter N: (N >=0 ) ");
            int n = int.Parse(Console.ReadLine());

            int fact2N = 2 * n, factNplus1 = n + 1;

            for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
            for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
            for (int i = n - 1; i > 0; i--) n *= i;

            Console.WriteLine("Result is {0}", fact2N / (factNplus1 * n));
            Console.ReadLine();
        }
    }
}
