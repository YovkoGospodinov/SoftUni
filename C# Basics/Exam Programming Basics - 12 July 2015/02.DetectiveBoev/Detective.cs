using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DetectiveBoev
{
    class Detective
    {
        static void Main()
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();
            int secredWordSum = 0;
            int[] newEncryptedMessage = new int[encryptedMessage.Length];
            for (int i = 0; i < secretWord.Length; i++)
            {
                secredWordSum += Convert.ToInt32(secretWord[i]);
            }
            
            double mask = (secredWordSum.ToString().Sum(s =>Char.GetNumericValue(s)));
            if (mask > 9)
            {
                mask = (mask.ToString().Sum(s => Char.GetNumericValue(s)));
            }
            
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (Convert.ToInt32(encryptedMessage[i]) % mask == 0)
                {
                    newEncryptedMessage[i] = (char)(Convert.ToInt32(encryptedMessage[i]) + mask);
                }
                else if (Convert.ToInt32(encryptedMessage[i]) % mask != 0)
                {
                    newEncryptedMessage[i] = (char)(Convert.ToInt32(encryptedMessage[i]) - mask);
                }
            }
            Array.Reverse(newEncryptedMessage);
            for (int i = 0; i < newEncryptedMessage.Length; i++)
            {
                Console.Write((char)(newEncryptedMessage[i]));
            }
            Console.WriteLine();

        }
    }
}
