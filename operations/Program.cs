using System;

namespace operations;

class Program
{
    static void Main(string[] args)
    {
        // Addition, Subtraction, Multiplication, Division, Modulus, Increment, Decrement, Assignment
        int number = 10;
        Console.WriteLine(number);

        number = number + 5;
        Console.WriteLine(number);

        number += 5;
        Console.WriteLine(number);

        number *= 5;
        Console.WriteLine(number);

        number /= 5;
        Console.WriteLine(number);

        //Logical Operators, &&, ||, !
        bool isRaining = true;
        bool isSnowing = false;
        if (isRaining)
        {
            Console.WriteLine("We should stay home because it's raining");
        }
        else if (isSnowing)
        {
            Console.WriteLine("We should stay home because it's snowing");
        }
        else
        {
            Console.WriteLine("We should go out");
        }

        //Relational Operators, ==, !=, >, <, >=, <=
        int a = 10;
        int b = 20;
        bool result = a < b;
        Console.WriteLine("a < b is " + result);

        //Conditional Operators, &&, ||
        int c = 10;
        int d = 20;
        int e = 30;
        bool result2 = c < d && d < e;
        Console.WriteLine("c < d && d < e is " + result2);

        Console.ReadLine();
    }
}
