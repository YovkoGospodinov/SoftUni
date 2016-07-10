namespace _01.Students
{
    public class Student
    {
        private string name;
        private static int studentsCount;
        
        static Student()
        {
            studentsCount = 0;
        }

        public Student(string name)
        {
            this.name = name;
            studentsCount++;
        }

        public static int StudentsCount => studentsCount;
    }
}
