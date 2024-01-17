using DesignPattern.Decorator.Contracts;

namespace DesignPattern.Decorator
{
    public class MyCar: ICar
    {
        public string Name { get; set; }
        public string Wheels { get; set; }
        public string Engine { get; set; }

        public ICar ManufactureCar()
        {
            Name = "Apache";
            Wheels = "Four";
            return this;
        }
    }
}
