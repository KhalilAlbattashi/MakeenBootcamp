namespace Events
{
    public class Program
    {
        public class Money
        {
            public decimal amount { set; get; }

            public Money( decimal amount) 
            {
                this.amount = amount;
            }

            public static Money operator *(Money a, Money b) 
            {
                decimal val = a.amount * b.amount;
                return new Money(val);
            }

            public static Money operator /(Money a, Money b)
            {
                // cannot divide by zero  
                if (b.amount == 0)
                {
                    throw new DivideByZeroException();
                }

                decimal val = b.amount / a.amount;
                return new Money(val);  
            }

            // while implementing the logical operators you must implement both of the operators (== and !=) (>= and <=) ... etc
            public static bool operator ==(Money a, Money b)
            {
                return a.amount == b.amount;
            }

            public static bool operator !=(Money a, Money b) 
            {  
                return !(a == b); 
            }
        }
        public class Rectangle
        {
            public  double length { get; set; }
            public double width { get; set; }

            // Functions that has the same signture
            public Rectangle()
            {
                //this.length = length;
                //this.width = width;
            }
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double getArea(double length, double width) 
            {   
                Console.WriteLine(length * width);
                return length * width;
            }

            public double getParameter(double length, double width)
            {
                Console.WriteLine(2 * (length + width));
                return 2 * (length + width);
            }

            public double sum(double length, double width)
            {
                Console.WriteLine(length + width);
                return length + width;
            }

            public double subtraction(double length, double width)
            {
                Console.WriteLine(length - width);
                return length - width;
            }
        }

        //initalizing the delegator.
        public delegate double RectangleHelper(double length, double width);
        static void Main(string[] args)
        {
            Console.WriteLine("-----Delegators-----");
            Rectangle rec = new Rectangle();
            //subscribing to the delegator,
            RectangleHelper recH = new RectangleHelper(rec.getArea);
            recH += rec.getParameter;
            recH += rec.sum;
            recH += rec.subtraction;
            recH(12, 90);

            Console.WriteLine("-----Operator Overloading-----");
            // operator overloading
            Money a = new Money(12m);
            Money b = new Money(14m);

            Money c = a * b;
            Money d = b / c;
            Console.WriteLine(c.amount);
            Console.WriteLine(d.amount);




        }
    }
} 