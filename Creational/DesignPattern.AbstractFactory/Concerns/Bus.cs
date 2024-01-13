namespace DesignPattern.AbstractFactory.Concerns
{
    public class Bus: IBus
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
    }
}
