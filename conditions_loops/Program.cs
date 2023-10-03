using System;
using System.Net.Http.Headers;

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
        Console.WriteLine(" ");


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
        Console.WriteLine(" ");


        // For Loop
        int counter = 0;
        Console.WriteLine("You woke up at 7 AM.");
        for (int wakeUpTime = 7; wakeUpTime < 23; wakeUpTime++)
        {
            if (hour < wakeUpTime && hour > 23)
            {
                break;
            }
            else if (wakeUpTime != hour)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("You've been awake for " + counter + " hours.");
        Console.WriteLine(" ");


        // While with Fibonacci
        int first = 0;
        int second = 1;
        int total;
        int fibCounter = 0;
        Console.WriteLine("Enter a number for Fibonacci:");
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci Sequence:");
        while (fibCounter < inputNum)
        {
            total = first + second;
            first = second;
            second = total;
            Console.WriteLine(total);
            fibCounter++;
        }
        Console.WriteLine(" ");

        // Do-While
        string password = "password";
        string input;
        do
        {
            Console.WriteLine("Enter your password:");
            input = Console.ReadLine();
            if (input != password)
            {
                Console.WriteLine("Incorrect Password");
            }
        } while (input != password);
        Console.WriteLine("Correct Password");
        Console.WriteLine(" ");



        Console.WriteLine("Press Enter to Exit");
        Console.ReadLine();
    }
}
