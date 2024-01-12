using DesignPattern.Factory.Contracts;
using DesignPattern.Factory.Helpers;
using DesignPattern.Factory.Providers;

namespace DesignPattern.Factory
{
    public class PaymentFactory
    {
        public static IPaymentGateway GetPaymentProvider(PaymentProvider provider)
        {
            switch (provider)
            {
                case PaymentProvider.Paypal:
                    return new PaypalPaymentGateway();
                case PaymentProvider.RazorPay:
                    return new RazorpayPaymentGateway();
                case PaymentProvider.Paytm:
                    return new PaytmPaymentGateway();
                case PaymentProvider.Stripe:
                    return new StripePaymentGateway();
                default:
                    return null;
            }
        }

    }
}

/*
 * Conditional Object Creation: If the creation of an object depends on certain conditions or configurations, 
 * the Factory pattern can encapsulate these conditions and ensure the creation of the appropriate object.
 * 
 * Readability and Maintenance: It improves code readability and maintenance by
 * encapsulating the creation logic in one place and promoting a clean separation of concerns.
 * 

Real-Time Examples of the Factory Design Pattern in C#
Payment Gateway Integration
Document Conversion System
Logging System
A Simple System to Handle Notifications
Discounts in an E-commerce Application
Transport Application
Developing a Graphics Editor
Designing a System for a Bank
Report Generation
Cloud Storage System
UI Theme System
 */