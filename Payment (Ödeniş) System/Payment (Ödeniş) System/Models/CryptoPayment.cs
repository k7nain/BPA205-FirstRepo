namespace Payment__Ödeniş__System.Models
{
    public class CryptoPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("CryptoPayment complated successfully");
        }

        public override void Refund()
        {
            Console.WriteLine("CryptoPayment refunded");
        }
    }
}
