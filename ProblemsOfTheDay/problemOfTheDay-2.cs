namespace ProblemOfTheDay
{
    public class Program
    {
        static double VectorSlope(double x1, double y1, double x2, double y2)
        {
            if (x2 == x1)
            {
                // Line is vertical, slope is undefined
                return double.PositiveInfinity;
            }
            else
            {
                // Line is not vertical, calculate slope using formula
                return (y2 - y1) / (x2 - x1);
            }
        }
        static double VectorLength(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public static void VectorInfo()
        {
            double maxY = double.NegativeInfinity;
            double minY = double.PositiveInfinity;
            Console.Write("How many vectors do you want to input? ");
            int n = int.Parse(Console.ReadLine());

            double[][] coords = new double[n][];
            Console.WriteLine("Enter the Coordinates x1 y1 and x2 y2");
            for (int i = 0; i < n; i++)
            {
                string sx1 = Console.ReadLine();
                double x1 = double.Parse(sx1);
                string sy1 = Console.ReadLine();
                double y1 = double.Parse(sy1);
                string sx2 = Console.ReadLine();
                double x2 = double.Parse(sx2);
                string sy2 = Console.ReadLine();
                double y2 = double.Parse(sy2);

                coords[i] = new double[4] {x1, y1, x2, y2};

            }
            Console.Write($"x1 y1\tx2 y2\n");
            for (int i = 0; i < n; i++)
            {

                Console.Write($"{coords[i][0]} {coords[i][1]}\t{coords[i][2]} {coords[i][3]}\n");
            }

            Console.WriteLine($"Vector\tLength\tslope");
            for (int i = 0; i < n; i++)
            {
                double length = VectorLength(coords[i][0], coords[i][1], coords[i][2], coords[i][3]);
                double slope = VectorSlope(coords[i][0], coords[i][1], coords[i][2], coords[i][3]);
                Console.WriteLine($"S{i+1}\t{length}\t{slope}");

            }

            foreach(double[] vector in coords)
            {
                double y1 = vector[1];
                double y2 = vector[3];
                maxY = Math.Max(maxY, Math.Max(y1, y2));
                minY = Math.Min(minY, Math.Min(y1, y2));
            }
            Console.WriteLine($"The Maximum Y Coordinate is: {maxY}");
            Console.WriteLine($"The Minimum Y Coordinate is: {minY}");



        }
        static void Main(string[] args)
        {
            VectorInfo();
        }
    }
}