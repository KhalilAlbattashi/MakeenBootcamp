namespace Enums
{
    public class Program
    {
        // using enums to represent data
        enum BookOrUpdate
        {
            Book = 0,
            Update = 1
        }
        enum WeekDays
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Console.WriteLine("Book New Appointment => 0\nUpdate Existing Appointment => 1");
            Option:
            string sInput = Console.ReadLine();
            int Input = Convert.ToInt32(sInput);

            while (true)
            {
                if (Input == 0)
                {
                    Console.WriteLine("Book New Appointment");
                    
                    chooseDays:
                    Console.WriteLine("Enter a numric value from 1 - 7 for the the day of your appointment");
                    string SuserInput = Console.ReadLine();
                    int userInput = Convert.ToInt32(SuserInput);
                    if((userInput == (int)WeekDays.Friday) || (userInput == (int)WeekDays.Saturday))
                    {
                        Console.WriteLine("Cannot choose Weekend Days");
                        goto chooseDays;
                    }else
                    {
                        Console.WriteLine("Enter Patient Name: ");
                        string name = Console.ReadLine();
                        patient.Name = name;
                        Console.WriteLine("Enter Patient Relationship: ");
                        string relationship = Console.ReadLine();
                        patient.Relationship = relationship;
                        bool isNew;
                        string appointment;

                        Console.WriteLine("have you booked here before (Yes/No)");
                        string newPatient = Console.ReadLine();

                        if (newPatient == "Yes")
                        {
                            isNew = true;
                            patient.NewPatient = isNew;
                        }
                        else if (newPatient == "No")
                        {
                            isNew = false;
                            patient.NewPatient = isNew;
                        }

                        switch (userInput)
                        {
                            case 1:
                                appointment = WeekDays.Sunday.ToString();
                                patient.Appointment = appointment;
                                break;
                            case 2:
                                appointment = WeekDays.Monday.ToString();
                                patient.Appointment = appointment;
                                break;
                            case 3:
                                appointment = WeekDays.Tuesday.ToString();
                                patient.Appointment = appointment;
                                break;
                            case 4:
                                appointment = WeekDays.Wednesday.ToString();
                                patient.Appointment = appointment;
                                break;
                            case 5:
                                appointment = WeekDays.Thursday.ToString();
                                patient.Appointment = appointment;
                                break;
                            default:
                                Console.WriteLine("invalid value");
                                break;
                        }
                    }
                    patient.print();
                    break;  
                }
                else if (Input == 1) 
                {
                    Console.WriteLine("Update");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    goto Option;
                }

            }
            




        }
    }
}
  