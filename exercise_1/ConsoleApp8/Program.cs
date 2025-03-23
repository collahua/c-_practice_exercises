using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Program
    {
        static void Greet(string name) => Console.WriteLine($"Hello {name}");
        static void SayGoodbye(string name) => Console.WriteLine($"Goodbye {name}");

        static void Main(string[] args)
        {
            /*  Create an Action<string> called messages that:
                First, stores a method that says "Hello, <name>".
                Then, stores a method that says "Welcome, <name>".
                Executes both methods together with the delegate.
            */

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Action<string> message = Greet;
            message += SayGoodbye;

            message(name);

            Console.ReadKey();
        }
    }
}
