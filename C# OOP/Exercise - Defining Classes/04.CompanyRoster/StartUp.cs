namespace _04.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                int age;
                string email;

                if (input.Length == 4)
                {
                    employees.Add(new Employee(name, salary, position, department));
                }
                else if (input.Length == 5)
                {
                    bool isNumeric = int.TryParse(input[4], out age);
                    if (isNumeric)
                    {
                        employees.Add(new Employee(name, salary, position, department, age));
                    }
                    else
                    {
                        employees.Add(new Employee(name, salary, position, department, input[4]));
                    }
                }
                else if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);

                    employees.Add(new Employee(name, salary, position, department, email, age));
                }
            }

            var groupDepartment = employees.GroupBy(emp => emp.Department).ToList();
            var groups = groupDepartment.Count;

            decimal maxSalary = 0;
            string bestPaidDept = string.Empty;

            foreach (var group in groupDepartment)
            {
                //Console.WriteLine(group.Key);
                decimal deptSalary = 0;
                string currentDepartment = string.Empty;
                foreach (var item in group)
                {
                    deptSalary += item.Salary;
                    currentDepartment = item.Department;
                }
                if (deptSalary > maxSalary)
                {
                    maxSalary = deptSalary;
                    bestPaidDept = currentDepartment;
                }
            }

            Console.WriteLine("Highest Average Salary: {0}", bestPaidDept);

            employees.Where(emp => emp.Department.Contains(bestPaidDept)).OrderByDescending(emp => emp.Salary).ToList().ForEach(emp => Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}"));
        }
    }
}

