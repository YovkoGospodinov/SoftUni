using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Null
    {
        static void Main()
        {
            int? firstVariable = null;
            double? secondVariable = null;
            Console.WriteLine("Integer variable:{0}\nDouble variable:{1}", firstVariable, secondVariable);

            firstVariable += 5;
            secondVariable += 5.5d;
            Console.WriteLine("Integer variable:{0}\nDouble variable:{1}", firstVariable, secondVariable);

            firstVariable += null;
            secondVariable += null;
            Console.WriteLine("Integer variable:{0}\nDouble variable:{1}", firstVariable, secondVariable);
        }
    }
}
