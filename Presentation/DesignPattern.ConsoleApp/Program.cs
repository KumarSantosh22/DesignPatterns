using DesignPattern.ConsoleApp.Behavioral;
using DesignPattern.ConsoleApp.Creational;
using DesignPattern.ConsoleApp.Structural;

// Creational Design Patterns

FluentInterfaceDriver fluentInterfaceDriver = new FluentInterfaceDriver();
fluentInterfaceDriver.Drive();

SingletonDriver sinletonDriver = new SingletonDriver();
sinletonDriver.Drive();

FactoryDriver factoryDriver = new FactoryDriver();
factoryDriver.Drive();

BuilderDriver builderDriver = new BuilderDriver();
builderDriver.Drive();


// Structural Design Patterns

AapterDriver aapterDriver = new AapterDriver();
aapterDriver.Drive();

DecoratorDriver decoratorDriver = new DecoratorDriver();
decoratorDriver.Drive();

FacadeDriver facadeDriver = new FacadeDriver();
facadeDriver.Drive();


// Behavioral Design Patterns
ChainOfResponsibilityDriver chainOfResponsibilityDriver = new ChainOfResponsibilityDriver();
chainOfResponsibilityDriver.Drive();
