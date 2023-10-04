using System;

namespace methods;

class Program
{
    static void Main(string[] args)
    {
        //methods
        //methods are a way to group code together

        //array methods
        Methods methods = new Methods();
        int[] numbers = methods.CreateArray();
        arrayProcess(numbers);

        Console.ReadLine();

    }

    private static void arrayProcess(int[] numbers)
    {
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
        //clear
        Console.WriteLine("After Clear");
        Array.Clear(numbers);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
    }
}


class Methods
{
    public int[] CreateArray()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter the {i + 1}. number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("");
        Console.WriteLine("The array is: ");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        return numbers;
    }
}