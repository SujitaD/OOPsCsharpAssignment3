using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsCsharpAssignment3
{
    class Manager :Employee,Interface1
    {
        

        
        double PetrolAllowance;
        double FoodAllowance;
        double OtherAllowance;
        double GrossSalary;

        public void GrossSal()
        {
             PetrolAllowance = 0.08 * Salary;
             FoodAllowance = 0.13 * Salary;
             OtherAllowance = 0.03 * Salary;
             GrossSalary = Salary + HRA + TA + DA + PetrolAllowance + FoodAllowance + OtherAllowance;
             Console.WriteLine(GrossSalary);

        }
        public override void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            Console.WriteLine("PF: " + PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS: " + TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary:" + NetSalary);
        }
        public Manager(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {

        }
        public void Display()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
           


        }


    }
}
