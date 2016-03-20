using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnicodeCharacter
{
    class UnicodeChar
    {
        static void Main()
        {
            char character = '\u002A';
            Console.WriteLine(character);

            //The easier way
            //Console.WriteLine((char)42);
            //Console.WriteLine((char)'\x2a');
            //Console.WriteLine((char)'\u002A');
        }
    }
}
