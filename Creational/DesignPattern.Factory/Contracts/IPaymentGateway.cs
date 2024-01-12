using DesignPattern.Factory.Concerns;

namespace DesignPattern.Factory.Contracts
{
    public interface IPaymentGateway
    {
        PaymentResponse ProcessPayment(PaymentRequest paymentRequest);
    }
}
