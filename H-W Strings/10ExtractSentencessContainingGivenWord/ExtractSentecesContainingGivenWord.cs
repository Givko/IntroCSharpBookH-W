using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class ExtractSentecesContainingGivenWord
{
    static void Main()
    {
        string[] sentences = Console.ReadLine().Split('.');
        string word = Console.ReadLine();
        char[] separators = new char[] { ' ', ',', '!', '"', '\'', '\\', '/', '-', '_', '=', '+', ')', '(', '*', '&', '^', '%', '$', '#', '@', '`', '?', ']', '[', '{', '}' };
        List<string> words = new List<string>();

        for (int i = 0; i < sentences.Length; i++)
        {
            words = sentences[i].Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int j = 0; j < words.Count; j++)
            {
                if (words[j] == word)
                {
                    Console.WriteLine(sentences[i]);
                    break;
                }
            }
        }
    }
}