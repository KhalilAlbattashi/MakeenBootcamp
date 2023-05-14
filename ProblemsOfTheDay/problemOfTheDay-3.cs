namespace ProblemOfTheDay{
    public class Problem{
        static int FindFirstNonDuplicate(int[] numbers){
            for (int i = 0; i < numbers.Length; i++){
                bool isDuplicate = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    return numbers[i];
                }
            }

            return -1; // No non-duplicate numbers found
        }
    }
}
