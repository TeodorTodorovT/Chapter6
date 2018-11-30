using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that calculates N!*K!/(N-K)! for given N and K (1 < K < N).
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int nMinusK = n - k;

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = nMinusK - 1; i > 0; i--) nMinusK *= i;

            Console.WriteLine("Result is {0}", n * k / nMinusK);
            Console.ReadLine();
        }
    }
}
