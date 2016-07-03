namespace _01.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var peshoPerson = new Person
            {
                name = "Pesho",
                age = 20
            };

            var goshoPerson = new Person
            {
                name = "Gosho",
                age = 18
            };

            var stamatPerson = new Person();
            stamatPerson.name = "Stamat";
            stamatPerson.age = 43;


            //Problem 2.	Creating Constructors
            //Type personType = typeof(Person);
            //ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            //ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            //ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            //bool swapped = false;
            //if (nameAgeCtor == null)
            //{
            //    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            //    swapped = true;
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            //Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            //Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            //Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);


            //Problem 3.	Opinion Poll
            //int lines = int.Parse(Console.ReadLine());
            //List<Person> persons = new List<Person>();

            //for (int i = 0; i < lines; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    var person = new Person(int.Parse(input[1]), input[0]);

            //    persons.Add(person);
            //}

            //persons.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));


            //Problem 4.	Company Roster
            //    int numberOfEmployees = int.Parse(Console.ReadLine());
            //    List<Employee> employees = new List<Employee>();

            //    for (int i = 0; i < numberOfEmployees; i++)
            //    {
            //        string[] input = Console.ReadLine().Split(' ');

            //        string name = input[0];
            //        decimal salary = decimal.Parse(input[1]);
            //        string position = input[2];
            //        string department = input[3];
            //        int age;
            //        string email;

            //        if (input.Length == 4)
            //        {
            //            employees.Add(new Employee(name, salary, position, department));
            //        }
            //        else if (input.Length == 5)
            //        {
            //            bool isNumeric = int.TryParse(input[4], out age);
            //            if (isNumeric)
            //            {
            //                employees.Add(new Employee(name, salary, position, department, age));
            //            }
            //            else
            //            {
            //                employees.Add(new Employee(name, salary, position, department, input[4]));
            //            }
            //        }
            //        else if (input.Length == 6)
            //        {
            //            email = input[4];
            //            age = int.Parse(input[5]);

            //            employees.Add(new Employee(name, salary, position, department, email, age));
            //        }
            //    }

            //    var groupDepartment = employees.GroupBy(emp => emp.Department).ToList();
            //    var groups = groupDepartment.Count;

            //    decimal maxSalary = 0;
            //    string bestPaidDept = string.Empty;

            //    foreach (var group in groupDepartment)
            //    {
            //        //Console.WriteLine(group.Key);
            //        decimal deptSalary = 0;
            //        string currentDepartment = string.Empty;
            //        foreach (var item in group)
            //        {
            //            deptSalary += item.Salary;
            //            currentDepartment = item.Department;
            //        }
            //        if (deptSalary > maxSalary)
            //        {
            //            maxSalary = deptSalary;
            //            bestPaidDept = currentDepartment;
            //        }
            //    }

            //    Console.WriteLine("Highest Average Salary: {0}", bestPaidDept);

            //    employees.Where(emp => emp.Department.Contains(bestPaidDept)).OrderByDescending(emp => emp.Salary).ToList().ForEach(emp => Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}"));
            //}
        }
    }
}
