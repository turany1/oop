using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Container
{
    public void DisplayContainer()
    {
        Console.WriteLine("Container method");
    }
    public class Nested
    {
        private Container? container;
        public Nested(Container container)
        {
            this.container = container;
        }
        public void ContainerMethod()
        {   
            if(container != null)
            {
                container.DisplayContainer();
            }   
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Container container = new Container();
        Container.Nested nested = new Container.Nested(container);
        nested.ContainerMethod();
    }
}
