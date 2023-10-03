using System;

namespace conditions_loops;

class Program
{
    static void Main(string[] args)
    {
        DateTime time = DateTime.Now;
        Console.WriteLine("Your time: " + time);


        // If-Else
        int hour = time.Hour;

        if (hour >= 6 && hour < 12)
        {
            Console.WriteLine("Good Morning!");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon!");
        }
        else
        {
            Console.WriteLine("Good Evening!");
        }

        // Switch
        int month = time.Month;

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Spring");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Fall");
                break;
            default:
                Console.WriteLine("Unknown Season");
                break;
        }







        Console.ReadLine();
    }
}
