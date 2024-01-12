using DesignPattern.Factory.Concerns;
using DesignPattern.Factory.Contracts;

namespace DesignPattern.Factory.Providers
{
    public class PaytmPaymentGateway : IPaytmPaymentGateway
    {
        public PaymentResponse ProcessPayment(PaymentRequest paymentRequest)
        {
            // process payment
            return new PaymentResponse { Success = true, Message = "Paytm payment" };
        }
    }
}
