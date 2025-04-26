using System;

namespace lab2
{
    public class Woorrrddddssssss
    {
        static void Main(string[] args)
        {
            var t = args[0];

            if (t.StartsWith("Error"))
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine(Word(t));
                Environment.Exit(0);
            }
        }

        public static string FromArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("No args?");
                return null;
            }

            return Word(args[0]);
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