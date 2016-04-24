using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Diagnostics;
namespace _11CensorText
{
    class CensorText
    {
        static void Main()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string text = "Microsoft announced its next generation C# compiler today. It uses and advance parser and special optimizer for the Microsoft CLR.";
            string[] forbidenWords = { "C#","Microsoft","CLR"};
            Regex replaceWords;

            if (forbidenWords.Length == 0)
            {
                Console.WriteLine(text.ToString());
                return;
            }

            for (int i = 0; i < forbidenWords.Length; i++)
            {
                replaceWords = new Regex(forbidenWords[i]);
                text = replaceWords.Replace(text.ToString(), string.Format("{0}", new string('*', forbidenWords[i].Length)));
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
    }
}
