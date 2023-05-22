namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee{Id=1, Name="Khali", Gender='M', TotalSales=1000000m },
                new Employee{Id=2, Name="Khal", Gender='M', TotalSales=1000000m},
                new Employee{Id=3, Name="Kha", Gender='M', TotalSales=550000m },
                new Employee{Id=4, Name="Kh", Gender='M', TotalSales=60000m},
                new Employee{Id = 5, Name = "K", Gender = 'M', TotalSales = 7000000m},
                new Employee{Id= 6, Name= "ali", Gender= 'M', TotalSales= 10000m},
                new Employee{Id= 7, Name= "li", Gender= 'M', TotalSales= 40000m},
                new Employee{Id=8, Name="i", Gender='M', TotalSales=10000m}
            };

            Report reports = new Report();
            reports.ProcessEmployee(employees, "total sales morethan 60 k", (emp) => emp.TotalSales >= 60000m);
            reports.ProcessEmployee(employees, "total sales between 30 to 60 k", (emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m);
            reports.ProcessEmployee(employees, "total sales lessthan 30k", (emp) => emp.TotalSales < 30000m);
        }
    }
}