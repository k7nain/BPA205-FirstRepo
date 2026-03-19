using Payment__Ödeniş__System.Models;

namespace Payment__Ödeniş__System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Payment Class
            Payment payment = new Payment();
            payment.Amount = 200;
            payment.Pay();
            payment.Refund();
            Console.WriteLine("---------------");

            //CreditCardPayment Class
            CreditCardPayment creditCard = new CreditCardPayment();
            creditCard.Pay();
            creditCard.Refund();
            Console.WriteLine("---------------");

            //CashPayment Class
            CashPayment cash = new CashPayment();
            cash.Pay();
            cash.Refund();
            Console.WriteLine("---------------");

            // CryptoPayment Class
            CryptoPayment crypto = new CryptoPayment();
            crypto.Pay();
            crypto.Refund();
        }
    }
}
