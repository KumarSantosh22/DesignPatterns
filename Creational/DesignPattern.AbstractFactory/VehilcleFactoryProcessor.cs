using DesignPattern.AbstractFactory.Contracts;
using DesignPattern.AbstractFactory.Helpers;
using DesignPattern.AbstractFactory.Providers;

namespace DesignPattern.AbstractFactory
{
    public class VehilcleFactoryProcessor
    { 
        public static IVehicleFactory GetVehicleFactory(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Bike:
                    return new BikeFactory();
                case VehicleType.Car:
                    return new CarFactory();
                case VehicleType.Bus:
                    return new BusFactory();
                default:
                    return null;
            }
        }
    }
}
