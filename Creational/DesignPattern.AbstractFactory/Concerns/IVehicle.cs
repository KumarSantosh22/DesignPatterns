namespace DesignPattern.AbstractFactory.Concerns
{
    public interface IVehicle
    {
        string Name { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        int Wheels { get; set; }
    }
}
