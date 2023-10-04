using System;

namespace methods;

class Program
{
    static void Main(string[] args)
    {
        //methods
        //methods are a way to group code together

        //array
        int[] numbers = { 23, 41, 3, 32, 51, 16, 7, 11 };
        Console.WriteLine("Numbers:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        //sort
        Console.WriteLine("After Sort");
        Array.Sort(numbers);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        //reverse
        Console.WriteLine("After Reverse");
        Array.Reverse(numbers);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");





        Console.ReadLine();

    }
}
