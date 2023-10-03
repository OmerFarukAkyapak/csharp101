using System;

namespace veriables;

class Program
{
    static void Main(string[] args)
    {
        int number = 10; // integer type veriable

        string name = "John"; // string type veriable
        string Name = "Alphie"; // string type veriable, diffrant from name because of capital N

        bool isWorking = true; // boolean type veriable

        double pi = 3.14; // double type veriable

        char letter = 'A'; // char type veriable


        Console.WriteLine("integer: " + number);
        Console.WriteLine("string with name: " + name);
        Console.WriteLine("string with Name: " + Name);
        Console.WriteLine("boolean: " + isWorking);
        Console.WriteLine("double: " + pi);
        Console.WriteLine("char: " + letter);



        Console.ReadLine();
    }
}
