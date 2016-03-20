using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShuffleBits
{
    class Bits
    {
        static void Main()
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            //string firstNumberStr = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
            //string secondNumberStr = Convert.ToString(secondNumber, 2).PadLeft(32, '0');
            //Console.WriteLine(firstNumberStr);
            //Console.WriteLine(secondNumberStr);
            //char[] resultChar = new char[64];

            ulong result = 0;
            if (firstNumber >= secondNumber)
            {
                //for (int i = 0; i < 32; i++)
                //{
                //    resultChar[2 * i] = firstNumberStr[i];
                //    resultChar[2 * i + 1] = secondNumberStr[i];
                //}

                //string resultStr = new string(resultChar);
                //result = Convert.ToUInt64(resultStr, 2);

                for (int i = 31; i >= 0; i--)
                {
                    ulong mask = 1;
                    mask <<= i;
                    ulong bitAtN = firstNumber & mask;
                    bitAtN >>= i;
                    result = result ^ (bitAtN << 2 * i + 1);
                }
                for (int i = 31; i >= 0; i--)
                {
                    ulong mask = 1;
                    mask <<= i;
                    ulong bitAtN = secondNumber & mask;
                    bitAtN >>= i;
                    result = result ^ (bitAtN << 2 * i);                    
                }
            }
            else
            {
                //for (int i = 0; i < 32; i+=2)
                //{
                //    resultChar[2 * i] = firstNumberStr[i];
                //    resultChar[2 * i + 1] = firstNumberStr[i + 1];
                //    resultChar[2 * i + 2] = secondNumberStr[i];
                //    resultChar[2 * i + 3] = secondNumberStr[i + 1];
                //}

                //string resultStr = new string(resultChar);
                //result = Convert.ToUInt64(resultStr, 2);

                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));
                for (int i = 31; i >= 0; i-=2)
                {
                    ulong mask = 1;
                    mask <<= i;
                    ulong bitAtN = firstNumber & mask;
                    bitAtN >>= i;
                    result = result ^ (bitAtN << 2 * i + 1);
                    mask = 1;
                    if (i == 0)
                    {
                        continue;
                    }
                    mask <<= i - 1;
                    bitAtN = firstNumber & mask;
                    bitAtN >>= i - 1;
                    result = result ^ (bitAtN << 2 * i);
                    
                }
                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));
                for (int i = 31; i >= 0; i-=2)
                {
                    ulong mask = 1;
                    mask <<= i;
                    ulong bitAtN = secondNumber & mask;
                    bitAtN >>= i;
                    result = result ^ (bitAtN << 2 * i - 1);
                    mask = 1;
                    if (i == 0)
                    {
                        continue;
                    }
                    mask <<= i - 1;
                    bitAtN = secondNumber & mask;
                    bitAtN >>= i - 1;
                    result = result ^ (bitAtN << 2 * i - 2);
                }

                //Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));
                //Console.WriteLine(result);
            }

            Console.WriteLine(result);
        }
    }
}
