using DesignPattern.Decorator;
using DesignPattern.Decorator.Contracts;

namespace DesignPattern.ConsoleApp.Structural
{
    public class DecoratorDriver
    {
        public void Drive()
        {
            ICar myCar = new MyCar();
            PetrolCarDecorator petrolCarDecorator = new PetrolCarDecorator(myCar);
            petrolCarDecorator.ManufactureCar();
        }
    }
}
