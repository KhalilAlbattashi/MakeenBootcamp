namespace Filteration
{
    public class Reports
    {
        public delegate bool filter(Employee e);
        public void FilterEmployee(Employee[] emps, string title, filter con)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\tAge\tSalary\tTotal Sales");
            foreach (Employee e in emps)
            {
                if (con(e))
                {
                    Console.WriteLine($"{e.Name}\t{e.Age}\t{e.Salary}\t{e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
