using DesignPattern.AbstractFactory.Concerns;
using DesignPattern.AbstractFactory.Contracts;

namespace DesignPattern.AbstractFactory.Providers
{
    public class BikeFactory : IBikeFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bike();
        }

        public IVehicle GetVehicle()
        {
            return new Bike();
        }
    }
}
