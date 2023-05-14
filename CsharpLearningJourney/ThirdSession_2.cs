namespace ThirdDay
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            const double PI = 3.14159265359;
            Console.WriteLine("Enter a What you Want to Calcuate");
            beginning:
            string option = Console.ReadLine();
            switch (option)
            {
                case "circumference":
                    Console.WriteLine("Enter the Radius");
                
                    while (true)
                    {   
                        A:
                        string str = Console.ReadLine();
                        if (double.TryParse(str, out double cRadius)) {
                            if(cRadius > 0)
                            {
                                double circumference = 2 * cRadius * PI;
                                Console.WriteLine(circumference);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                goto A;
                            }
                        }
                    }
                    break;
                case "Area":
                    Console.WriteLine("Enter the Radius");

                    B:
                    string str1 = Console.ReadLine();
                    if(double.TryParse(str1, out double aRadius))
                    {
                        if (aRadius > 0)
                        {
                            double Area = Math.Pow(aRadius,2) * PI;
                            Console.WriteLine(Area);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            goto B;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    goto beginning;
            }
        }
    }
}
