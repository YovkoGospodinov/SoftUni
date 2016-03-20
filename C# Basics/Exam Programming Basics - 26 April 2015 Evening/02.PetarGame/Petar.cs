using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.PetarGame
{
    class Petar
    {
        static void Main()
        {
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string replacingString = Console.ReadLine();
            string sumString = "";
            BigInteger sum = 0;

            //ulong i = startNumber;

            //do
            //{
            //    if (i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //    else
            //    {
            //        sum += i % 5;
            //    }

            //    i++;

            //} while (i < endNumber);

            for (ulong i = startNumber; i < endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }

            if (sum % 2 == 0)
            {
                sumString = Convert.ToString(sum);

                sumString = sumString.Replace(sumString[0].ToString(), replacingString);

                
            }
            else
            {
                sumString = Convert.ToString(sum);
                //ulong lastDigit = sum % 10; // sumstring.lenght - 1
                //string lastDigitStr = Convert.ToString(lastDigit);

                sumString = sumString.Replace(sumString[sumString.Length - 1].ToString(), replacingString);

            }
            Console.WriteLine(sumString);

        }
    }
}
