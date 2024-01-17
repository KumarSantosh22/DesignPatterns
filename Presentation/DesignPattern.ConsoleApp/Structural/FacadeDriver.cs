using DesignPattern.Facade.Services;

namespace DesignPattern.ConsoleApp.Structural
{
    public class FacadeDriver
    {
        OrderService orderService = new();

        public void Drive()
        {
            orderService.PlaceOrder();
        }
    }
}
