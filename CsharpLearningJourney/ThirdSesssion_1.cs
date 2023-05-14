namespace Arrays{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1) the user enters he number of students
             2) after that the user enters the grades of each student
             3) save all the grades in an array called gradesInt
             4) also go through a loop an convert each number grade to a letter graed
             */

            Console.WriteLine("Enter the number of students");
            int size;
            while (true)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out int Grade))
                {
                    if (Grade > 0)
                    {
                        size = Grade;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Negative Number");
                    } 
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            int[] intGrades = new int[size];
           

            for (int i = 0; i < intGrades.Length; i++){
                intGrade:
                string grade = Console.ReadLine();
                dynamic temp = int.TryParse(grade, out int newGrade);
                if (temp == true) {
                    intGrades[i] = newGrade;
                }
                else
                {
                    Console.WriteLine("invalid Input");
                    goto intGrade;
                }
                
                //intGrades[i] = int.TryParse(grade, out int newGrade)? newGrade: 0;
            }

            for (int i = 0; i < intGrades.Length; i++){
                if (intGrades[i] <= 100 && intGrades[i] >= 90){
                    Console.WriteLine($"{intGrades[i]} is: A");
                }
                else if (intGrades[i] >= 80 && intGrades[i] <= 89){
                    Console.WriteLine($"{intGrades[i]} is: B");
                }
                else if (intGrades[i] >= 70 && intGrades[i] <= 79){
                    Console.WriteLine($"{intGrades[i]} is: C");
                }
                else if (intGrades[i] >= 60 && intGrades[i] <= 69){
                    Console.WriteLine($"{intGrades[i]} is: D");
                
                }
                else if (intGrades[i] > 100 || intGrades[i] < 0){
                    Console.WriteLine("Wrong Grade");
                    break;
                }
                else{
                    Console.WriteLine($"{intGrades[i]} is: F");
                }
            }
        }
    }
}
