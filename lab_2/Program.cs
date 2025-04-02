using System;

namespace lab2
{
    public class Woorrrddddssssss
    {
        static void Main(string[] args)
        {
            string t = Word("hello world");
            Console.WriteLine(t);
        }
        public static string Word(string input)
        {
            int a = input.Length;
            string output = "";
            for (int i = 0; i < a; i++)
            {
                for (int j = i*(i+1)/2; j <= i + i * (i + 1) / 2; j++)  //не знаю наскільки тут оптимально брати суму, але працює
                {
                    output = output.Insert(j, input[i].ToString());
                }
            }
            return output;
        }
    }
}