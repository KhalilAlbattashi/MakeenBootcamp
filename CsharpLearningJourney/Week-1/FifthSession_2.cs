
namespace OOP
{   
    internal class Person
    {
        public int Id;
        public string fName;
        public string lName;
        public int age;
        public bool isMarried;
        public string Address;

        public Person(string fname, string lname)
        {
            this.Id = 0;
            this.fName = fname;
            this.lName = lname;
            this.age = 0;
            this.isMarried = false;
            this.Address = "none";
        }

        public Person(int id, string fname, string lname, int age, bool isMarried, string address)
        {
            this.Id = id;
            this.fName = fname;
            this.lName = lname;
            this.age = age;
            this.isMarried = isMarried;
            this.Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine($"{this.fName} {this.lName}");
            Console.WriteLine(this.age);
            Console.WriteLine(this.isMarried);
            Console.WriteLine(this.Address);
        }
    }
}
