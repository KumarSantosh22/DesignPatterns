namespace DesignPattern.AbstractFactory.Concerns
{
    public class Bike : IBike
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
    }
}
