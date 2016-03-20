using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LocalElections
{
    class Elections
    {
        static void Main()
        {
            int candidatesNumber = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            char votingSymbol = char.Parse(Console.ReadLine());

            for (int ballot = 1; ballot  <= candidatesNumber; ballot ++)
            {
                if (ballot == vote)
                {
                    if (votingSymbol == 'x' || votingSymbol == 'X')
                    {
                        Console.WriteLine(new string('.', 13));

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));

                        Console.WriteLine("{0}{1}{2}{3}{2}{4}{2}{1}{0}", new string('.', 3), new string('|', 1), new string('.', 1), new string('\\', 1), new string('/', 1));

                        Console.WriteLine("{0:00}{1}{2}{3}{4}{3}{2}{5}", (ballot), new string('.', 1), new string('|', 1), new string('.', 2), new string('X', 1), 
                            new string('.', 3));

                        Console.WriteLine("{0}{1}{2}{3}{2}{4}{2}{1}{0}", new string('.', 3), new string('|', 1), new string('.', 1), new string('/', 1), new string('\\', 1));

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));
                    }

                    else if (votingSymbol == 'v' || votingSymbol == 'V')
                    {
                        Console.WriteLine(new string('.', 13));

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));

                        Console.WriteLine("{0}{1}{2}{0}{3}{1}{0}", new string('.', 3), new string('|', 1), new string('\\', 1), new string('/', 1));

                        Console.WriteLine("{0:00}{1}{2}{1}{3}{1}{4}{1}{2}{5}", (ballot), new string('.', 1), new string('|', 1), new string('\\', 1), new string('/', 1)
                            , new string('.', 3));

                        Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('.', 3), new string('|', 1), new string('.', 2), new string('V', 1));

                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));
                    }
                    continue;
                }

                Console.WriteLine(new string('.', 13));

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('|', 1), new string('.', 5));

                Console.WriteLine("{0:00}{1}{2}{3}{2}{4}", (ballot), new string('.', 1), new string('|', 1), new string('.', 5), new string('.', 3));

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('|', 1), new string('.', 5));

                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 3), new string('+', 1), new string('-', 5));

                
            }

            Console.WriteLine(new string('.', 13));
        }
    }
}
