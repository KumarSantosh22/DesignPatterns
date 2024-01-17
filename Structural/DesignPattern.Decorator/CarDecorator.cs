using DesignPattern.Decorator.Contracts;

namespace DesignPattern.Decorator
{
    public class CarDecorator: ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return _car.ManufactureCar();
        }
    }
}
