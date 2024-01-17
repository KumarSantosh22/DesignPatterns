namespace DesignPattern.Facade.Services
{
    // facade class
    public class OrderService
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");

            //Get the Product Details
            ProductService product = new();
            product.GetProductDetails();

            //Make the Payment
            PaymentService payment = new();
            payment.MakePayment();

            //Send the Invoice
            InvoiceService invoice = new();
            invoice.SendInvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}
