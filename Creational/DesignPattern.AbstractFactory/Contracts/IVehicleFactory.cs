using DesignPattern.AbstractFactory.Concerns;

namespace DesignPattern.AbstractFactory.Contracts
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
        IVehicle GetVehicle();
    }
}
