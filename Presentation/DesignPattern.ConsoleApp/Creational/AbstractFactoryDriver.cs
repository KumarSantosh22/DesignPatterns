using DesignPattern.AbstractFactory;
using DesignPattern.AbstractFactory.Concerns;
using DesignPattern.AbstractFactory.Contracts;
using DesignPattern.AbstractFactory.Helpers;

namespace DesignPattern.ConsoleApp.Creational
{
    public class AbstractFactoryDriver
    {
        public void Drive()
        {
            IVehicleFactory bikeFactory = VehilcleFactoryProcessor.GetVehicleFactory(VehicleType.Bike);
            IVehicle bike = bikeFactory.CreateVehicle();
            bike = bikeFactory.GetVehicle();
        }
    }
}
