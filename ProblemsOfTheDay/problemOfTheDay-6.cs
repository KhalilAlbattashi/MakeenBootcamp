namespace POD6
{
    public class Program
    {
        public static void Main()
        {
            // Create a matrix
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 10, 8, 9 } };

            // Calculate the sum of the main diagonal
            int mainDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                mainDiagonalSum += matrix[i,i];
            }

            // Calculate the sum of the right diagonal
            int rightDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rightDiagonalSum += matrix[i,matrix.GetLength(0) - 1 - i];
            }

            
            // Print the sum of the two diagonals
            Console.WriteLine($"The sum of the main diagonal is: {mainDiagonalSum}");
            Console.WriteLine($"The sum of the right diagonal is: {rightDiagonalSum}");
            Console.WriteLine($"The abs value of subtracting the two diagonals is: {Math.Abs(mainDiagonalSum - rightDiagonalSum)}");

        }
    }
}