namespace OOP{
    public class Program{
        public static void PrintLine(int cnt = 5, string pattern = "##")
        {
            for (int i=0; i < cnt; i++)
            {
                Console.Write($"{pattern} ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int x, ref int y) {
            int temp = x; 
            x = y; 
            y = temp;
        }

        public static void sumMulti(int x, int y, out int sum, out int multi) {
            sum = x + y;
            multi = x * y;
        }

        public static string EvenOrOdd(int x)=> (x % 2 == 0)? "Even" : "Odd";


        static void Main(string[] args){
            int x = 7, y = 6;
            double c = 5.3, d = 5.5;
            string w = "Hello ", z = "World!";
            Calculator calc = new Calculator();

            Person p1 = new Person("First", "Last");
            Person p2 = new Person(1, "first", "last", 24, false, "Muscat, OMAN");

            Swap(ref x, ref y);
            sumMulti(x, y, out int sum, out int multi);
            Console.WriteLine($"x is: {x}");
            Console.WriteLine($"y is: {y}");
            Console.WriteLine($"the sum is: {sum}");
            Console.WriteLine($"the multipication is: {multi}");

            Console.WriteLine(calc.add(x, 6));
            Console.WriteLine(calc.add(c, d));
            Console.WriteLine(calc.add(w, z));
            
            Console.WriteLine(EvenOrOdd(4));
            
            Console.WriteLine();

            p1.PrintInfo();

            Console.WriteLine();

            p2.PrintInfo();


        }
    }
}
