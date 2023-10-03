using System;

namespace console_programming;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello,You are in the console programming.");
        Console.WriteLine("Whats your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");

        Console.ReadLine();
    }
}
