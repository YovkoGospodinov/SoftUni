namespace _02.UniqueStudentNames
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            while (name != "End")
            {
                Student currentStudent = new Student(name);

                StudentGroup.AddStudent(currentStudent.Name);

                name = Console.ReadLine();
            }

            int numberOfUniqueStudents = StudentGroup.Students.Count;

            Console.WriteLine(numberOfUniqueStudents);
        }
    }
}
