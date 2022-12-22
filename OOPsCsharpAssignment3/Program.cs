using System;

namespace OOPsCsharpAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(79,"Suji",70000);
            
            m.Display();
            Console.Write("GrossSalary is ");
            m.GrossSal();
            MarketingExecutive me = new MarketingExecutive(68, "ee", 1000);
            me.Display();
            
            me.GrossSal();
        }
    }
}
