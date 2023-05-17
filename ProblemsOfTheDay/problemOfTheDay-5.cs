namespace ProblemOfTheDay_5
{
    public class Program
    {
        static void leftRotatebyOne(ref int[] arr, int size, int numRotations)
        {
            
            for (int k = 0;  k < numRotations; k++)
            {
                //store the first element in a temporary variable
                int temp = arr[0];
                for (int i = 0; i < size - 1; i++)
                {
                    //swap elements one by one
                    arr[i] = arr[i + 1];
                }
                arr[size - 1] = temp;
            }
            
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            leftRotatebyOne(ref arr, 7, 3);
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + " "); }
                
        }
    }
}