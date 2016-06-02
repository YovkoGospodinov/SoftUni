using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOcc
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();

            string[] spilittedText = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int countSubstringOcc = 0;
            int substringLenght = substring.Length;
            foreach (string word in spilittedText)
            {
                if (word.Length == substringLenght && word.Contains(substring))
                {
                    countSubstringOcc++;
                    continue;
                }
                else if (word.Length > substringLenght && word.Contains(substring))
                {
                    for (int i = 0; i < word.Length; i += 2)
                    {
                        if (word.Substring(i).Contains(substring))
                        {
                            countSubstringOcc++;
                        }
                    }
                }
            }
            Console.WriteLine(countSubstringOcc);
        }
    }
}
