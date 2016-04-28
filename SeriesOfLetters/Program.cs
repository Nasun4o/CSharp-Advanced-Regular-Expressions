namespace SeriesOfLetters
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            // aaaaabbbbbcdddeeeedssaa
            char currentChar = default(char);

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (currentChar != input[i])
                {
                    Console.Write(input[i]);
                    currentChar = input[i];
                }
            }

            Console.WriteLine();
        }
    }
}
