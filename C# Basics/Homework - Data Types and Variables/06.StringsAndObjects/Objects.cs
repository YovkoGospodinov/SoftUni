using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Objects
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object concatenation = firstWord + " " + secondWord;
            string phrase = (string)concatenation;
            Console.WriteLine(phrase);
        }
    }
}
