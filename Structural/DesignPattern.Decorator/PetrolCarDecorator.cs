using DesignPattern.Decorator.Contracts;

namespace DesignPattern.Decorator
{
    public class PetrolCarDecorator: CarDecorator
    {
        public PetrolCarDecorator(ICar car): base(car) { }

        public override ICar ManufactureCar()
        {
            _car.ManufactureCar();
            AddEnine(_car);
            return _car;
        }

        public void AddEnine(ICar car)
        {
            if(car is MyCar MyCar)
            {
                MyCar.Engine = "Petrol Engine";
            }
        }
    }
}
