

namespace Filteration
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public decimal TotalSales { get; set; }  
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee{Name="Khali", Age = 43, Salary = 12222m , TotalSales=1000000m },
                new Employee{Name="Khal", Age = 17,Salary = 100000m ,TotalSales=1000000m},
                new Employee{Name="Kha", Age = 21, Salary = 1211m,TotalSales=550000m },
                new Employee{Name="Kh",  Age = 32, Salary = 1200m,TotalSales=60000m},
                new Employee{Name = "K", Age = 52, Salary = 213m,TotalSales = 7000000m},
                new Employee{Name= "ali", Age = 22, Salary = 122m,TotalSales= 10000m},
                new Employee{Name= "li", Age = 45, Salary = 1002m,TotalSales= 40000m},
                new Employee{Name="i",  Age = 60, Salary = 122m,TotalSales=10000m}
            };

            Reports reports = new Reports();
            reports.FilterEmployee(employees, "Salary Less than 60K", (emp) => emp.Salary >= 60000m);
            reports.FilterEmployee(employees, "total sales between 30 to 60 k", (emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m);
            reports.FilterEmployee(employees, "Age > 21", (emp) => emp.Age < 21);
        }
    }
}