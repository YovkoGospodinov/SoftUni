using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class CompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter the requested company information below.");
            Console.Write("Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Company address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number:");
            string companyPhone = Console.ReadLine();
            Console.Write("Fax number:");
            string companyFax = Console.ReadLine();
            if (companyFax == string.Empty)
            {
                companyFax = "(no fax)";
            }
            Console.Write("Web site:");
            string companyWebPage= Console.ReadLine();
            Console.Write("Manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name:");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age:");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone:");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5}{6}{7} (age: {8}, tel. {9})", 
                companyName, companyAddress, companyPhone, companyFax, companyWebPage, 
                managerFirstName, " ", managerLastName, managerAge, managerPhone);
        }
    }
}
