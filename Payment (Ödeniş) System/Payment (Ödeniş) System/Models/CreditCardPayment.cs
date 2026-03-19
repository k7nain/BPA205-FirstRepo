namespace Payment__Ödeniş__System.Models
{
    public class CreditCardPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("CreditCard payment complated successfully");
        }

        public override void Refund()
        {
            Console.WriteLine("CreditCard payment refunded");
        }
    }
}
