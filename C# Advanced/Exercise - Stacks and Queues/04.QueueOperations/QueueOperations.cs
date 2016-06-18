using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.QueueOperations
{
    class QueueOperations
    {
        static void Main(string[] args)
        {
            Queue<int> database = new Queue<int>();
            int[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int enqueueEls = commands[0];
            int dequeueEls = commands[1];
            int searchedNumber = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < enqueueEls; i++)
            {
                database.Enqueue(numbers[i]);
            }
            for (int i = 0; i < dequeueEls; i++)
            {
                database.Dequeue();
            }
            bool isNumberExist = database.Contains(searchedNumber);
            if (isNumberExist)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (database.Count > 0)
                {
                    Console.WriteLine(database.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
