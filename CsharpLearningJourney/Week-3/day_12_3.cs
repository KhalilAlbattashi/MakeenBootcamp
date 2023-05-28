using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Report
    {
        public delegate bool SalesCondition(Employee e);
        public void ProcessEmployee(Employee[] emps, string title, SalesCondition con)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------------------");
            foreach (Employee e in emps) 
            {
                if (con(e))
                {
                    Console.WriteLine($"{e.Id} {e.Name} {e.Gender} {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
