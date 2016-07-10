namespace _01.Students
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var currentStudent = new Student(input);

                input = Console.ReadLine();
            }

            int numberOfStudents = Student.StudentsCount;

            Console.WriteLine(numberOfStudents);
        }
    }
}
