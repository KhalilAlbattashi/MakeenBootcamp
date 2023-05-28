namespace PhoneBook
{
    public class Program
    {
        public class PhoneBook
        {
            public string[] names;
            public string[] numbers;
            public int len;
            public int counter = 0;
            public PhoneBook(int len)
            {
                this.len = len;
                this.names = new string[len];
                this.numbers = new string[len];
            }

            // set, get indexers 

            public string this[int idx  , string name]
            {
                get
                { 
                    return numbers[idx];
                }
                set
                {
                    names[idx] = name;
                    numbers[idx] = value; // value preserved keyword  keyword 
                }
            }

            public string this[string name]
            {
                get
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];

                    }
                    return "not found";
                }
            }
            

            public void printPhoneBook()
            {
                for(int i  = 0; i < len; i++) 
                {
                    Console.WriteLine($"{names[i]} : {numbers[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            PhoneBook b = new PhoneBook(2);

            b[0,"Khalil"] = "9090800820";
            Console.WriteLine(b["Khalil"]);
            b.printPhoneBook();
        }
    }
}