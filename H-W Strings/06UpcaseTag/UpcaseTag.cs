using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06UpcaseTag
{
    class UpcaseTag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string upText = ToUpperCase(text);
            Console.WriteLine(upText);
        }

        private static string ToUpperCase(string text)
        {
            string[] splittedText = text.Split('<', '>');
            StringBuilder upcaseTexted = new StringBuilder();

            if (splittedText[0] == text)
            {
                return splittedText[0];
            }

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (splittedText[i] == "upcase" || splittedText[i] == "/upcase")
                {
                    continue;
                }
                else
                {
                    if (i - 1 >= 0)
                    {
                        if (splittedText[i - 1] == "upcase")
                        {
                            upcaseTexted.Append(splittedText[i].ToUpper());
                        }
                        else
                        {
                            upcaseTexted.Append(splittedText[i]);
                        }
                    }
                }
            }
            return upcaseTexted.ToString();
        }
    }
}
