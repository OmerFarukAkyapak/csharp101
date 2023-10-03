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

        byte b = 255; // byte type veriable 1 byte
        short s = 32767; // short type veriable 2 byte
        int i = 2147483647; // int type veriable 4 byte
        long l = 9223372036854775807; // long type veriable 8 byte

        Console.WriteLine("integer: " + number);
        Console.WriteLine("string with name: " + name);
        Console.WriteLine("string with Name: " + Name);
        Console.WriteLine("boolean: " + isWorking);
        Console.WriteLine("double: " + pi);
        Console.WriteLine("char: " + letter);



        Console.ReadLine();
    }
}
