namespace DesignPattern.AbstractFactory.Concerns
{
    public class Car: ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
    }
}
