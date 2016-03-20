using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrive = int.Parse(Console.ReadLine());
            int minutesOfArrive = int.Parse(Console.ReadLine());

            int timeOfExamInMinutes = hourOfExam * 60 + minutesOfExam;
            int timeOfArriveInMinutes = hourOfArrive * 60 + minutesOfArrive;

            if (timeOfArriveInMinutes > timeOfExamInMinutes)
            {
                Console.WriteLine("Late");
                if ((timeOfArriveInMinutes - timeOfExamInMinutes) < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeOfArriveInMinutes - timeOfExamInMinutes);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", (timeOfArriveInMinutes - timeOfExamInMinutes) / 60, (timeOfArriveInMinutes - timeOfExamInMinutes) % 60);
                }
            }
            else if ((timeOfArriveInMinutes == timeOfExamInMinutes))
            {
                Console.WriteLine("On time");
            }
            else if (timeOfArriveInMinutes >= timeOfExamInMinutes - 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeOfExamInMinutes - timeOfArriveInMinutes);
            }
            else
            {
                Console.WriteLine("Early");
                if ((timeOfExamInMinutes - timeOfArriveInMinutes) < 60)
                {
                    Console.WriteLine("{0} minutes before the start", timeOfExamInMinutes - timeOfArriveInMinutes);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", (timeOfExamInMinutes - timeOfArriveInMinutes) / 60, (timeOfExamInMinutes - timeOfArriveInMinutes) % 60);
                }
            }
        }
    }
}
