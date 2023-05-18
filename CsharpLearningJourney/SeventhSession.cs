using System.Linq.Expressions;

namespace Interface
{

    public abstract class vehicle
    {
        public string model { get; set; }
        public int year { get; set; }
        public string catagory { get; set; }
        
        public vehicle(string  model, int year, string catagory)
        {
            this.model = model;
            this.year = year;   
            this.catagory = catagory;
        }
    }

    public interface IDriver
    {
        void start();
        void move();
        void stop();
    }

    public interface ILoader
    {
        void start();
        void load();
        void unload();
    }

    public class Honda : vehicle, IDriver
    {
        public Honda(string model, int year, string catagory) : base(model, year, catagory)
        {
        }

        public void move()
        {
            Console.WriteLine("Moving");
        }

        public void stop()
        {
            Console.WriteLine("Stopped");
        }

        void IDriver.start()
        {
            Console.WriteLine("Enging Started"); ;
        }
    }

    public class Caterpiller : vehicle, ILoader, IDriver
    {
        public Caterpiller(string model, int year, string catagory) : base(model, year, catagory)
        {
        }

        public void load()
        {
            Console.WriteLine("Loading . . .");
        }

        public void move()
        {
            Console.WriteLine("Moving");
        }

        public void stop()
        {
            Console.WriteLine("Stopped");
        }

        public void unload()
        {
            Console.WriteLine("Unloading . . .");
        }

        void ILoader.start()
        {
            Console.WriteLine("Loading Car engin started"); 
        }

        void IDriver.start()
        {
            Console.WriteLine("Driving Car engin started");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            
            Caterpiller c = new Caterpiller("Chevy", 2007, "heavy");
            Honda h = new Honda("civic", 2001, "v2.1");
            
            c.load();
            c.move();
            c.stop();
            h.move();
        }
    }
}