
namespace HelloWorld{
    class Program{
        static void Main(string[] args) {
            //Consoling the data
            /*
            consoling the data means writing the the data to the console using Console.WriteLine("") function and anything in-between the 
            " " will be written to the console(cli) 
            */
            Console.WriteLine("Consoling the data");
            
            // value types vs refrence type
            /*
            in C# the data follows the CTS system which is a short for Common type system.
            There are two types of data in the CTS one is the value type which contains all the known size data types like 
            int, float, double, boolean and many others data types. the other type is refrence type which is a intilized data using the new 
            keyword and this data types is not fixied in size which means We Don’t Know how Much we will reserve in the
            Memory for it.
            */
            int Age = 24;
            int Age2 = 25;
            object obj1 = new object();
            object obj2 = new object();
            
            // system.object functions
            /*
            every data type in c# innherite the functionalities of the system.object type which means that 
            every data type has the built-in fuctions such as GetHashCode().
            GetHashCode() fucntion returns a unique identifier for each object.
            */
            Console.WriteLine(obj1.GetHashCode()); // 32425243
            Console.WriteLine(obj2.GetHashCode()); // 54343211
            Console.WriteLine(Age.GetHashCode()); // 24
            Console.WriteLine(Age2.GetHashCode()); // 25

            // string interpolation
            /*
            string interpolation is using $ before the "" and inserting the variable name that we want to conncatenate inside {} instead of
            seperating the string by + everytime.
            */
            string firstname = "First";
            string lastname = "Last";
            Console.WriteLine($"{firstname} {lastname}");
            
            //var vs dynamic 
            /*
            var and dynamic keyword are used for data type automatic detection but the difference between them is that 
            var cannot be changed after assigning it to a value for the first time, but dynamic, as the name implies, the variable
            value can be changed as many times as we want.
            */
            
            var test = 23;
            //test = "Hello"; this will generate an error
            
            dynamic test1 = 23;
            test = "Hello";
            
            // expressions
            /*
            expressions are a combination of more that one value or function calls
            */
            
            int x = 12 + 3 // 15

            // boolean operations (Comparison Operators)
            /*
            Comparison Operators are for comparing two values and return true or false based on their relation 
            */
            int x = 10;
            int y = 3;
            bool equal = x == y; // false
            bool notequal = x != y; // true
            bool lessthan = x < y; //false
            bool biggerThan = x > y; // true
            bool lessOrequal = x <= y; //false
            bool biggerOrequal = x >= y; // true
            
            // logical operators
            /*
            logical operators are used to determine the truth value of two boolean expressions
            */
            bool And = (x == y) && (y != x); //AND retrun true if both expressions are true otherwise its false
            bool Or = (x > y) || (x < y);// OR return true if one or both of the expressions are true otherwise false
            bool xor = (x > y) ^ (x < y); // if both true or both false the result is false otherwise its true
            Console.WriteLine(xor);
        }
    }
}
