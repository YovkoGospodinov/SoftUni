using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProspectInHospitality
{
    class Hospitality
    {
        static void Main()
        {
            long builders = long.Parse(Console.ReadLine());
            long receptionists = long.Parse(Console.ReadLine());
            long chambermaids = long.Parse(Console.ReadLine());
            long technicians = long.Parse(Console.ReadLine());
            long otherStaff = long.Parse(Console.ReadLine());
            decimal nikiSalaryUsd = decimal.Parse(Console.ReadLine());
            decimal usaCurancy = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal buildersAmount = builders * 1500.04m;
            decimal receptionistsAmount = receptionists * 2102.10m;
            decimal chambermaidsAmount = chambermaids * 1465.46m;
            decimal techniciansAmount = technicians * 2053.33m;
            decimal otherStaffAmount = otherStaff * 3010.98m;
            decimal nikiSalaryBgn = nikiSalaryUsd * usaCurancy;

            decimal salariesAmount = buildersAmount + receptionistsAmount + chambermaidsAmount
                + techniciansAmount + otherStaffAmount + nikiSalaryBgn + mySalary;
            

            Console.WriteLine("The amount is: {0:F2} lv.", salariesAmount);

            if (budget >= salariesAmount)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", (budget - salariesAmount));
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", (salariesAmount - budget));
            }

        }
    }
}
