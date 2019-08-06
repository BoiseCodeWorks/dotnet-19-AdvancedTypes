using System;

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
            app.Run();
        }
    }
}
