using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 1, 4, 5 };
        int[] leftArr;
        int n = arr.Length;


        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            rightSum += arr[i];
        }

        int index = -1;

        for (int i = 0; i < n; i++)
        {
            leftSum += arr[i];
            rightSum -= arr[i];

            if (leftSum == rightSum)
            {
                index = i;
                break;
            }
        }

        leftArr = arr[..(index+1)];

        

       

        
        
        if (index == -1) {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
            Console.Write("the left half { ");
            for (int i = 0;i < leftArr.Length; i++) {
                Console.Write($"{leftArr[i]}, ");
            }
            Console.Write("}\n");

            Console.Write("the right half { ");
            for (int i = index + 1; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("}");
        }

    }
}
