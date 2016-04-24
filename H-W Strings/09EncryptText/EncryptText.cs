using System;
using System.Text;

namespace _09EncryptText
{
    class EncryptText
    {
        static void Main()
        {
            string plainText = Console.ReadLine();
            string cipher = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            int encyptedCode = 0;

            for (int index = 0, cipherIndex = 0; index < plainText.Length; index++, cipherIndex++)
            {
                if (cipherIndex == cipher.Length)
                {
                    cipherIndex = 0;
                }
                encyptedCode = (int)plainText[index] ^ (int)cipher[cipherIndex];
                encryptedText.Append(string.Format("\\u{0:X4}", encyptedCode));
            }
            Console.WriteLine(encryptedText.ToString());
        }
    }
}
