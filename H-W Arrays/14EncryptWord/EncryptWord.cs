using System;

class EncryptWord
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string word = Console.ReadLine();
        word = word.ToLower();
        string wordAsIndexes = "";

        for (int i = 0; i < word.Length; i++)
        {
            int maxIndex = alphabet.Length;
            int minIndex = 0;
            int curMid;

            for (int j = 0; j < alphabet.Length / 2; j++)
            {
                curMid = (minIndex + maxIndex) / 2;
                if (alphabet[curMid] == word[i])
                {
                    wordAsIndexes += curMid;
                    break;
                }
                else if (alphabet[curMid] > word[i])
                {
                    maxIndex = curMid - 1;
                }
                else
                {
                    minIndex = curMid + 1;
                }
            }
        }
        Console.WriteLine("{0}",wordAsIndexes);
    }
}


