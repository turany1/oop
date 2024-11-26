using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Vehicle
{
    public class Engine
    {
        public void StartEngine()
        {   
            Console.WriteLine("Started");
        }
    }
}
public class Car : Vehicle
{
    public string Name {get;private set;}
    public Engine CarEngine{get;private set;}
    public Car (string name)
    {
        Name = name;
        CarEngine = new Engine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Audi");
        Console.WriteLine("The car name is : " + car.Name);
        car.CarEngine.StartEngine();
    }
}
