namespace Payment__Ödeniş__System.Models
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public virtual void Pay()
        {
            Console.WriteLine("Pay complated successfully");
        }

        public virtual void Refund()
        {
            Console.WriteLine("Payment refunded");
        }
    }
}
