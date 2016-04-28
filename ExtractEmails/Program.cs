namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string userInput = Console.ReadLine();

            string pattern = @"\b[A-Za-z][\w\.\-]+@[\w\.\-]+[a-z]\b";

            var regex = Regex.Matches(userInput, pattern);

            foreach (Match item in regex)
            {
                Console.WriteLine(item);
            }
        }
    }
}