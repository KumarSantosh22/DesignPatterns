using DesignPattern.Singleton;

namespace DesignPattern.ConsoleApp.Creational
{
    public class SingletonDriver
    {
        public void Drive()
        {
            SingletonExampleOne singleton1 = SingletonExampleOne.GetInstance();
            int value = singleton1.GetValue();
            Console.WriteLine(value);
            singleton1 = SingletonExampleOne.GetInstance();
            value = singleton1.GetValue();
            Console.WriteLine(value);
        }
    }
}
