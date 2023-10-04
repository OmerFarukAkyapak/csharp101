using System;
using System.Collections.Generic;

namespace collections;

class Program
{
    static void Main(string[] args)
    {
        // List<T> is a generic class
        // T is the type of the elements in the list
        List<string> namesList = new List<string> { "Faruk", "Enes", "Ozi" };
        namesList.Add("Mete");
        namesList.Add("Ali");

        List<int> numbersList = new List<int>();
        numbersList.Add(1);
        numbersList.Add(2);
        numbersList.Add(3);


        //Print List
        Console.WriteLine("Name List: ");
        PrintList(namesList);
        Console.WriteLine("");
        Console.WriteLine("Nubmer List: ");
        PrintList(numbersList);
        Console.WriteLine("");

        //Count
        Console.WriteLine("Name List Count: " + namesList.Count);
        Console.WriteLine("Number List Count: " + numbersList.Count + "\n");

        //Access
        Console.WriteLine("First of Name List: " + namesList[0]);
        Console.WriteLine("First of Number List: " + numbersList[0]);

        Console.WriteLine("\nPress Enter to Exit...");
        Console.ReadLine();
    }

    static void PrintList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    static void PrintList(List<int> list)
    {
        list.ForEach(i => Console.WriteLine(i));
    }
}
