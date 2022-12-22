using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsCsharpAssignment3
{


    class Employee
    {
        public int EmpNo;
        public string EmpName;
        public  double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        public Employee(int EmpNo, string EmpName, double Salary)
        {
            

            if(EmpNo <= 0)
            {
                throw new Exception("EmpNo empty not allowed");
            }
            else
            {
                this.EmpNo = EmpNo;
            }
            if(string.IsNullOrEmpty(EmpName))
            {
                throw new Exception("EmpName empty not allowed");
            }
            else
            {
                this.EmpName = EmpName;

            }
            if(Salary <=0)
            {
                throw new Exception("Salary empty not allowed");
            }
            else
            {
               this.Salary = Salary;

            }

        }
        public void CalHra()
        {
            if (Salary < 5000)
            {
                HRA = 0.1 * Salary;
            }
            else if (Salary < 10000)
            {
                HRA = 0.15 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.20 * Salary;
            }
            else if (Salary < 20000)
            {
                HRA = 0.25 * Salary;
            }
            else
            {
                HRA = 0.30 * Salary;
            }
            Console.WriteLine(HRA);
        }
        public void CalTa()
        {
            if (Salary < 5000)
            {
                TA = 0.05 * Salary;
            }
            else if (Salary < 10000)
            {
                TA = 0.10 * Salary;
            }
            else if (Salary < 15000)
            {
                TA = 0.15 * Salary;
            }
            else if (Salary < 20000)
            {
                TA = 0.20 * Salary;
            }
            else
            {
                TA = 0.25 * Salary;
            }
            Console.WriteLine(TA);
        }
        public void CalDa()
        {
            if (Salary < 5000)
            {
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000)
            {
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                DA = 0.20 * Salary;
            }
            else
            {
                DA = 0.35 * Salary;
            }
            Console.WriteLine(DA);
        }
        public void GrossSal()
        {
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("GrossSalary:" + GrossSalary);
        }
        
        public virtual void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            Console.WriteLine("PF: " + PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS: " + TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary:" + NetSalary);
        }
        public void Display()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
            Console.WriteLine(GrossSalary);


        }

    }

    
}
