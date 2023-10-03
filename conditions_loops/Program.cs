using System;

namespace conditions_loops;

class Program
{
    static void Main(string[] args)
    {
        // If-Else
        int timeNow = DateTime.Now.Hour;

        if (timeNow >= 6 && timeNow < 12)
        {
            Console.WriteLine("Good Morning!");
        }
        else if (timeNow >= 12 && timeNow < 18)
        {
            Console.WriteLine("Good Afternoon!");
        }
        else
        {
            Console.WriteLine("Good Evening!");
        }

        Console.ReadLine();
    }
}
