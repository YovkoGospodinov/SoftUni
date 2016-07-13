namespace _03.ManKind
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] studentDetails = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string studentFirstName = studentDetails[0];
            string studentSecondName = studentDetails[1];
            string facultyNumber = studentDetails[2];

            input = Console.ReadLine();
            string[] workerDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string workerFirstName = workerDetails[0];
            string workerSecondName = workerDetails[1];
            double salary = double.Parse(workerDetails[2]);
            double hours = double.Parse(workerDetails[3]);


            try
            {
                var student = new Student(studentFirstName, studentSecondName, facultyNumber);
                Console.WriteLine(student.GetDesription());
                var worker = new Worker(workerFirstName, workerSecondName, salary, hours);
                Console.WriteLine(worker.GetDesription());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
