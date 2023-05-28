namespace OOP_1
{
    public class Person
    {
        private static int currentYear = 2023; 
        private string Fname;
        private string Lname;
        private string RelationshipStatus;
        private int Age;
        private decimal Salary;

        public Person(string fname, string lname, string rel, int age, decimal salary) {
            this.Fname = fname;
            this.Lname = lname; 
            this.RelationshipStatus = rel;  
            this.Age = age;
            this.Salary = salary;
        }
        public string getFname() { return Fname; }
        public void setFname(string name) {
            this.Fname = name;
        }
        public string getLname() {  return Lname; }
        public void setLname(string name){
            this.Lname = name;  
        }
        public string getRelationshipStatus() {  return RelationshipStatus; }
        public void setRelationshipStatus(string relationshipStatus){
            this.RelationshipStatus = relationshipStatus;
        }
        public int getAge() { return Age;}
        public void setAge(int age){
            this.Age = age;
        }

        public void setAge(string yearOfBirth){
            int year = int.Parse(yearOfBirth);
            this.Age = DateTime.Now.Year - year;
        }
        public decimal getSalary() {  return Salary;}
        public void setSalary(decimal salary) { 
            this.Salary = salary;   
        }


        public string PrintInfo() { 

            string info = $"Full Name: {this.getFname()} {this.getLname()}\n" +
            $"Relationship Status: {this.getRelationshipStatus()}\n" +
            $"Age: {this.getAge()}\n" +
            $"Salary: {this.getSalary()}";

            return info;

        }
    }
}
