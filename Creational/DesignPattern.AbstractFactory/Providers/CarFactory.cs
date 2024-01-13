using DesignPattern.AbstractFactory.Concerns;
using DesignPattern.AbstractFactory.Contracts;

namespace DesignPattern.AbstractFactory.Providers
{
    public class CarFactory : ICarFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }

        public IVehicle GetVehicle()
        {
            return new Car();
        }
    }
}
