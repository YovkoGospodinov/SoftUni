using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encoded_Answers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            int numberOfQuestions = int.Parse(Console.ReadLine());
            int answerA = 0;
            int answerB = 0;
            int answerC = 0;
            int answerD = 0;
            string result = "";

            for (int i = 0; i < numberOfQuestions; i++)
            {
                uint question = uint.Parse(Console.ReadLine());
                uint questionDevided = question % 4;

                switch (questionDevided)
                {
                    case 0:
                        answerA++;
                        result += "a" + " ";
                        break;
                    case 1:
                        answerB++;
                        result += "b" + " ";
                        break;
                    case 2:
                        answerC++;
                        result += "c" + " ";
                        break;
                    case 3:
                        answerD++;
                        result += "d" + " ";
                        break;
                    default:
                        break;
                }                
            }

            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}", answerA);
            Console.WriteLine("Answer B: {0}", answerB);
            Console.WriteLine("Answer C: {0}", answerC);
            Console.WriteLine("Answer D: {0}", answerD);
        }
    }
}
