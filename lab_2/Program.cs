using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = input.Length;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}