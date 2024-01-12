using DesignPattern.Factory;
using DesignPattern.Factory.Concerns;
using DesignPattern.Factory.Contracts;
using DesignPattern.Factory.Helpers;

namespace DesignPattern.ConsoleApp.Creational
{
    public class FactoryDriver
    {
        public void Drive()
        {
            IPaymentGateway payment = PaymentFactory.GetPaymentProvider(PaymentProvider.Stripe);
            if (payment == null )
            {
                throw new ArgumentNullException();
            }
            PaymentResponse response  = payment.ProcessPayment(new PaymentRequest { Amount=10.00f });
            Console.WriteLine($"{response.Success} - {response.Message}");
        }
    }
}
