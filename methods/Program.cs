using System;

namespace methods;

class Program
{
    static void Main(string[] args)
    {
        //methods
        //methods are a way to group code together
        Console.WriteLine("Methods");
        Console.WriteLine("1- Array Method");
        Console.WriteLine("2- Exponential Function");
        Console.WriteLine("3- String Method");
        Console.WriteLine("Enter the number of the method: \n");
        int selection = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                //array methods
                Console.WriteLine("Array Methods");
                Methods methods = new Methods();
                methods.CreateArray(out int[] numbers);
                arrayProcess(numbers);
                break;
            case 2:
                //exponential function
                Console.WriteLine("Exponential Function");
                Methods methods2 = new Methods();
                Console.WriteLine("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the exponent: ");
                int exponent = Convert.ToInt32(Console.ReadLine());
                methods2.Exponential(number, exponent);
                Console.WriteLine($"The result is: {methods2.Exponential(number, exponent)}");
                break;
            case 3:
                //string methods
                Console.WriteLine("String Methods");
                Methods methods3 = new Methods();
                Console.WriteLine("Enter the text: ");
                string text = Console.ReadLine();
                Console.WriteLine(methods3.StringMethods(text));
                break;
            default:
                Console.WriteLine("Press Enter to Exit...");
                Console.ReadLine();
                break;
        }
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

        numbers.ClearArray();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");
    }
}


class Methods
{
    public int[] CreateArray(out int[] array)
    {
        Console.WriteLine("Enter the size of the array: ");

        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter the {i + 1}. number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        array = numbers;

        Console.WriteLine("");
        Console.WriteLine("The array is: ");

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        return array;
    }

    public int Exponential(int number, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent == 1)
        {
            return number;
        }
        else
        {
            return number * Exponential(number, exponent - 1);
        }
    }

    public string StringMethods(string text)
    {
        return $"Upper Case: {text.ToUpper()} \nLower Case: {text.ToLower()}";
    }
}

public static class Extension
{
    public static int[] ClearArray(this int[] array)
    {
        Array.Clear(array);
        return array;
    }
}