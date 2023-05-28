namespace Enums
{
    public class Patient
    {
        public  string Name { get; set; }
        public string Relationship { get; set; }
        public string Appointment { get; set; }
        public  bool NewPatient { get; set; }
        public Patient()
        {

        }
        public Patient(string name, string relationship, string appointment, bool newPatient) 
        {
            this.Name = name;   
            this.Relationship = relationship;
            this.Appointment = appointment;
            this.NewPatient = newPatient;
        }

        public void print()
        {
            Console.WriteLine("-----------------------Patient Information-------------------------------");
            Console.WriteLine($"Patient Name: {this.Name}");
            
            Console.WriteLine($"Patient Relationship: {this.Relationship}");

            Console.WriteLine($"First Time: {this.NewPatient}");

            Console.WriteLine($"Appointment: {this.Appointment}");
            Console.WriteLine("-----------------------Patient Information-------------------------------");


        }
    }
}
