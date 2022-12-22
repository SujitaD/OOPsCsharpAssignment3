using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsCsharpAssignment3
{
    class MarketingExecutive : Employee,Interface1
    {
        public MarketingExecutive(int EmpNo, string EmpName, double Salary): base(EmpNo,EmpName,Salary)
        {

        }

        double KilometerTravel;
        double TourAllowance;
        double TelephoneAllowance;
        double GrossSalary;

        public void GrossSal()
        {
            Console.WriteLine("KilometerTravel:");
            KilometerTravel = Convert.ToDouble(Console.ReadLine());
            TourAllowance = 5 * KilometerTravel;
            TelephoneAllowance = 1000;
            GrossSalary = Salary + HRA + TA + DA + KilometerTravel + TourAllowance + TelephoneAllowance;
            Console.WriteLine("Gross salary is  : "+GrossSalary);

        }

        public override void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            Console.WriteLine("PF: " +PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS: " +TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary:" +NetSalary);
        }
        public void Display()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
            


        }

    }

}
