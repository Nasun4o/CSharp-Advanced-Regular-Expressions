namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
          //  string wordToMatch = @"\b" + keyword + @"\b";

            string input = Console.ReadLine();

            string pattern = string.Format(@"\b[a-zA-Z][\s\w]+{0}[\w\s]+[\!|\.|\?]", keyword);

            MatchCollection regex = Regex.Matches(input, pattern);

            foreach (Match item in regex)
            {
                Console.WriteLine(item);
            }
        }
    }
}
