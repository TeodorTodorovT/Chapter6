using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that reads from the console a series of integers and prints the smallest and largest of them.
            int lowest, highest, input, lenght;
            lowest = 0;
            highest = 0;
            Console.Write("Enter the lenght: ");
            lenght = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lenght; i++)
            {
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest >= input) lowest = input; 
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);
            Console.ReadLine();
        }

    }
}
