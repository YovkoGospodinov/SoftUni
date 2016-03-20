﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WaveBits
{
    class Bits
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int count = 1;
            int biggestCount = 0;
            int startIndex = 0;
            ulong mask = 1UL;
            for (int i = 0; i < 62; i++)
            {
                bool index = (number >> i & 1) == 1;
                bool index1 = (number >> i + 1 & 1) == 0;
                bool index2 = (number >> i + 2 & 1) == 1;


                if (index && index1 && index2)
                {
                    count += 2;
                    i++;
                }
                else
                {
                    if (biggestCount < count)
                    {
                        biggestCount = count;
                        startIndex = i;
                    }
                    count = 1;
                }
            }
            ulong newNumber = 0;
            for (int i = 63; i >= 0; i--)
            {
                if (i <= startIndex && i > startIndex - biggestCount)
                {
                    continue;
                }
                newNumber <<= 1;
                newNumber = (number >> i & 1UL) | newNumber;

            }
            if (biggestCount == 1)
            {
                Console.WriteLine("No waves found!");
            }
            else
            {
                Console.WriteLine(newNumber);
            }

        }
    }
}
