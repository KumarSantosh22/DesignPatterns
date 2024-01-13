using DesignPattern.AbstractFactory.Concerns;
using DesignPattern.AbstractFactory.Contracts;

namespace DesignPattern.AbstractFactory.Providers
{
    public class BusFactory: IBusFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bus();
        }

        public IVehicle GetVehicle()
        {
            return new Bus();
        }
    }
}
