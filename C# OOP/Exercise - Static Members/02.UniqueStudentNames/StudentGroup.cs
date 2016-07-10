namespace _02.UniqueStudentNames
{
    using System.Collections.Generic;

    public class StudentGroup
    {
        private static HashSet<string> students;

        static StudentGroup()
        {
            students = new HashSet<string>();
        }

        public static HashSet<string> Students => students;

        public static void AddStudent(string student)
        {
            students.Add(student);
        }
    }
}
