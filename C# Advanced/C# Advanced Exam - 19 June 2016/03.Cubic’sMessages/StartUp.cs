namespace _03.Cubic_sMessages
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^([\d]+)([a-zA-Z]+)([^a-zA-Z]*)$";
            //Regex regex = new Regex(pattern);

            while (input != "Over!")
            {
                int messageSize = int.Parse(Console.ReadLine());

                string[] message = Regex.Split(input, pattern);
                //var massage = Regex.Matches(input, pattern);

                if (message.Length > 1)
                {
                    if (message[2].Length == messageSize)
                    {
                        Console.Write("{0} == ", message[2]);

                        foreach (var digit in message[1])
                        {
                            int number = 0;
                            //int temp = digit - '0';  //anothe way for parsing the digit

                            if(int.TryParse(digit.ToString(), out number))
                            { 
                            
                                if (number < message[2].Length)
                                {
                                    Console.Write("{0}", message[2][number]);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            
                        }

                        foreach (var digit in message[3])
                        {
                            int number = 0;
                            //int temp = digit - '0';  //anothe way for parsing the digit

                            if (int.TryParse(digit.ToString(), out number))
                            {
                                if (number < message[2].Length)
                                {
                                    Console.Write("{0}", message[2][number]);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            
                        }
                        Console.WriteLine();
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
