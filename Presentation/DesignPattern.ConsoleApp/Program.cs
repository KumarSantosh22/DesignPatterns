using DesignPattern.ConsoleApp.Creational;
using DesignPattern.ConsoleApp.Structural;

FluentInterfaceDriver fluentInterfaceDriver = new FluentInterfaceDriver();
fluentInterfaceDriver.Drive();

SingletonDriver sinletonDriver = new SingletonDriver();
sinletonDriver.Drive();

FactoryDriver factoryDriver = new FactoryDriver();
factoryDriver.Drive();

BuilderDriver builderDriver = new BuilderDriver();
builderDriver.Drive();

AapterDriver aapterDriver = new AapterDriver();
aapterDriver.Drive();
