namespace HelloWorld{
    class Program{
        static void Main(string[] args) {
            // hard-coded numbers 
            int a = 10;
            int b = 40;
            int c = 30;
            // return the same if all three numbers are the same
            if (a == b && b == c) {
                Console.WriteLine("numbers are equal");
            } else { 
                /*
                set a as the the biggest if any numbers is bigger than a
                set it to max
                */
                int max = a;
                if (b > max) {
                    max = b;
                }
                if (c > max) {
                    max = c;
                }
                Console.WriteLine($"{max} is the largest");
        }
    }
}
