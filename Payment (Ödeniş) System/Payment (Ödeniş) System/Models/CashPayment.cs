namespace Payment__Ödeniş__System.Models
{
    public class CashPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Cash payment complated successfully");
        }

        public override void Refund()
        {
            Console.WriteLine("Cash payment refunded");
        }
    }
}
