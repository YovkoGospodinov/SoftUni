using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number:");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0')); //Binary representation of number in 32 bits 
            uint mask3 = 1 << 3; //Making mask 
            uint numMask3 = num & mask3; //Bitwise comparing number and mask 
            uint mask4 = 1 << 4;
            uint numMask4 = num & mask4;
            uint mask5 = 1 << 5;
            uint numMask5 = num & mask5;
            uint mask24 = 1 << 24;
            uint numMask24 = num & mask24;
            uint mask25 = 1 << 25;
            uint numMask25 = num & mask25;
            uint mask26 = 1 << 26;
            uint numMask26 = num & mask26;
            uint tempNum = 0; //Temporary result 
            uint newNum; //Final result 
            if (numMask3 == 0 && numMask24 != 0) //Check if bit 3 is 0 and bit 24 is 1 
            {
                tempNum = num & ~(uint)(1 << 24); //Put 0 on position 24 
                tempNum = tempNum | 1 << 3; //Put 1 on position 3 
                newNum = tempNum;
            }
            else if (numMask3 != 0 && numMask24 == 0) //Check if bit 3 is 1 and bit 24 is 0 
            {
                tempNum = num & ~(uint)(1 << 3); //Put 0 on position 3 
                tempNum = tempNum | 1 << 24; //Put 1 on position 24 
                newNum = tempNum;
            }
            else
            {
                newNum = num; // Bit 3 and bit 24 are equal.No need to exchange 
            }
            if (numMask4 == 0 && numMask25 != 0) //Check if bit 4 is 0 and bit 25 is 1 
            {
                tempNum = newNum & ~(uint)(1 << 25); //Put 0 on position 25 
                tempNum = tempNum | 1 << 4; //Put 1 on position 4 
                newNum = tempNum;
            }
            else if (numMask4 != 0 && numMask25 == 0) //Check if bit 4 is 1 and bit 25 is 0 
            {
                tempNum = newNum & ~(uint)(1 << 4); //Put 0 on position 4 
                tempNum = tempNum | 1 << 25; //Put 1 on position 25 
                newNum = tempNum;
            }
            else
            {
                newNum = num; //Bit 4 and bit 25 are equal.No need to exchange 
            }
            if (numMask5 == 0 && numMask26 != 0) //Check if bit 5 is 0 and bit 26 is 1 
            {
                tempNum = newNum & ~(uint)(1 << 26); //Put 0 on position 26 
                tempNum = tempNum | 1 << 5; //Put 1 on position 5 
                newNum = tempNum;
            }
            else if (numMask5 != 0 && numMask26 == 0) //Check if bit 5 is 1 and bit 26 is 0 
            {
                tempNum = newNum & ~(uint)(1 << 5); //Put 0 on position 5 
                tempNum = tempNum | 1 << 26; //Put 1 on position 26 
                newNum = tempNum;
            }
            else
            {
                newNum = num; //Bit 5 and bit 26 are equal.No need to exchange 
            }
            Console.WriteLine(newNum);
            Console.WriteLine(Convert.ToString(newNum, 2).PadLeft(32, '0')); //Binary representation of new number in 32 bits 
        }
    }

}
