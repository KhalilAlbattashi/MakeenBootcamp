using System.Linq.Expressions;

namespace Interface
{
    public class Cashier
    {
        public IPayment payment { get; set; }
        public Cashier(IPayment payment)
        {
            this.payment = payment;
        }

        public void Checkout()
        {
            payment.Pay();
        }
    }

    public interface IPayment 
    {
        void Pay();
    }


    public class Cash : IPayment
    {
        public decimal amount;
        public Cash(decimal amount)
        {
            this.amount = amount;
        }
        public void Pay()
        {
            Console.WriteLine($"Paid in Cash {amount} OMR");
        }
    }
    public class MasterCard : IPayment
    {
        public decimal amount;
        public MasterCard(decimal amount)
        {
            this.amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Paid by MasterCard {amount} OMR");

        }
    }
    public class Visa : IPayment
    {
        public decimal amount;
        public Visa(decimal amount)
        {
            this.amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Paid by Visa {amount} OMR");
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {

            Cashier c1 = new Cashier(new Cash(901.12m));
            Cashier c2 = new Cashier(new MasterCard(9m));
            Cashier c3 = new Cashier(new Visa(90.12m));

            c1.Checkout();
            c2.Checkout();
            c3.Checkout();

        }
    }
}