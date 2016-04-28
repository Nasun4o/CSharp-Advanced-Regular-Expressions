namespace ReplaceATag
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            //string text = Console.ReadLine();

            //string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";

            //string textToReplace = @"[URL href=$1]$2[/URL]";

            //var regex = Regex.Replace(text, pattern, textToReplace);
            //Console.WriteLine(regex);


            string html = File.ReadAllText(@"..\..\HTML-AHref.txt"); // read file HTML-AHref.txt saved in same folder as the project .cs file
            string pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
            using (StreamWriter output = new StreamWriter(@"..\..\HTML-URL.txt"))  // create new file
            {
                output.WriteLine(Regex.Replace(html, pattern, @"[URL$1]$3[/URL]")); // write on the new file, the URL-replaced string
            }
            string fileContents = File.ReadAllText(@"..\..\HTML-URL.txt"); // print output file to the console
            Console.WriteLine(fileContents);
        }
    }
}
