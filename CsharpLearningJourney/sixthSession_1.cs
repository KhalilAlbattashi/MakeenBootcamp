namespace OOP_1
{
    public class BankAccount{
        private const double _MAXIMUM_DEPOSITE = 1000;
        private long _AccountNo;
        private double _Balance;
        private string _message;

        public BankAccount(long accountNo)
        {
            this._AccountNo = accountNo;
            this._Balance = 0;
        }

        public long getAccountNo()
        {
            return this._AccountNo;
        }

        public double getBalance()
        {
            return this._Balance;
        }
        public void Deposite(double amount)
        {
            
            if(amount <= 0) 
            {
                _message = "invalid Amount";
                Log(_message);
                return;
            }else if(amount > _MAXIMUM_DEPOSITE) 
            {
                _message = "Deposite Maximum Exceeded";
                Log(_message);
                return;
            }
            else
            {
                //DepositeBalance(amount);
                this._Balance += amount;
                _message = "Success";
                Log(_message);
            }
        }

        public void Withdraw(double amount) 
        {
            if (amount > this.getBalance()) 
            {
                _message = "insufficient funds";
                Log(_message);
            }else if(amount <= 0)
            {
                _message = "invalid Amount";
                Log(_message);  
            }
            else
            {
                //WithdrawBalance(amount);
                this._Balance -= amount;
                _message = "Success";
                Log(_message);
            }
        }

        public void Log(string Messege)
        {
            string dateAndTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            if (Messege == "Success")
            {
                Console.WriteLine($"{dateAndTime}\nTransaction Seccussfull\nyour Account No: {this.getAccountNo()}\nyour Balanceis: {this.getBalance()}\n");
            }
            else if (Messege == "insufficient funds")
            {
                Console.WriteLine($"{dateAndTime}\nTransaction Failed Available Balance is not Enough\nyour Account No: {this.getAccountNo()}\nyour Balanceis: {this.getBalance()}\n");
            }
            else if (Messege == "Deposite Maximum Exceeded")
            {
                Console.WriteLine($"{dateAndTime}\nTransaction Failed the Deposite Amount Exceeded the Limit {BankAccount._MAXIMUM_DEPOSITE}\nyour Account No: {this.getAccountNo()}\nyour Balanceis: {this.getBalance()}\n");
            }else if(Messege == "invalid Amount")
            {
                Console.WriteLine($"{dateAndTime}\nTransaction Failed Invalid Amount\nyour Account No: {this.getAccountNo()}\nyour Balanceis: {this.getBalance()} \n");
            }
        }
    }
}
