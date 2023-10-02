using System;

namespace csharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Thanks " + name + "!");

            Console.ReadLine();
        }
    }
}
