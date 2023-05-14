namespace Arrays{
    internal class Program{
        static void Main(string[] args) {
            // one dimension array
            int[] arr = new int[2] { 1, 2 };

            // multi-dimension array (matrix)
            int[,] multiArr = new int[2, 2] { { 1, 3 }, { 2, 5 } };

            // jagged Array, in this kind of arrays we can control the size of the inner arrays
            int[][] jaggedArr = new int[2][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 , 5},
            };

            // printing the content of the arrays
            Console.WriteLine($" arr: {arr[0]}, {arr[1]}\n");
            Console.WriteLine($" multiArr:\n {multiArr[0,0]}, {multiArr[0, 1]}\n {multiArr[1, 0]}, {multiArr[1, 1]}\n");
            Console.WriteLine($" jaggedArr:\n {jaggedArr[0][0]}, {jaggedArr[0][1]}\n {jaggedArr[1][0]}, {jaggedArr[1][1]}, {jaggedArr[1][2]}\n");

            // array slicing
            int[] arrSlice = new int[5] {1, 2, 3, 4, 5};
            int[] slice = arrSlice[..3];
            int[] slice1 = arrSlice[2..];
            int[] slice2 = arrSlice[1..3];

            Console.WriteLine(slice[2]);// 3
            Console.WriteLine(slice1[0]);// 3
            Console.WriteLine(slice2[0]);// 2

            //chapeau notation

            int[] chapeauSlice = arrSlice[1..^2];
            Console.WriteLine(chapeauSlice[1]);//3

            //binary Operators (%)
            int number = 6;
            // testing if the number is Even or Odd
            string result = (number % 2 == 0)? "Even" : "Odd";
            Console.WriteLine(result);

            // null values
            int? z = null;// ? is the null operator
            string str = null;
            //str = str ?? "Yousf"; // if it is null let it equal to yousf if not print the value
            Console.WriteLine(str?.ToUpper()); // conditional Null (if the value is null do do the operation)

            // statements and block scopes
            int x = 1;
            int y = 1;
            x++;
            Console.WriteLine(x++);//print first than increament
            Console.WriteLine(++x);// increament first then print
        }
    }
}
