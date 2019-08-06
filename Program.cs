using System;
using AdvancedTypes.Models;

namespace AdvancedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //1. need to create an instance of the app class
            App app = new App();
            //2. invoke the Greeting method
            // app.Greeting();


            Lion simba = new Lion("Simba", 2, 4, "Male");
            Lion scar = new Lion("Scar", 12, 4, "Male");
            // scar.Name = "Jim Bob"; //NOTE becuase the setter access modifier is private we cannot reassign the value of the Lion's Name property from outside of the class definition.
            Console.WriteLine($"{scar.Name} is jealous of {simba.Name}");
            simba.Eat("Antelope");
            scar.Eat(simba.Name);
            scar.ChangeName("Jim Bob");
        }
    }
}
