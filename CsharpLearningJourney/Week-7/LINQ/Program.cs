namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Extensions
            int x = 1234;
            int y = x.mirror();
            //Console.WriteLine(y);

            
            // LINQ Operators different syntax
            List<int> list = new List<int>() { 1,2,4,45,6,3,4,7,8,9,10};
            // methods syntax
            var EvenRes = list.Where(x => x % 2 == 0);
            
            // sql syntax
            var OddRes = from i in list
                         where i % 2 != 0
                         select i;

            // Result output
            Console.WriteLine("Even Numbers");
            foreach (var item  in EvenRes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Odd Numbers");
            foreach (var item in OddRes)
            {
                Console.WriteLine(item);
            }
        }
    }
}