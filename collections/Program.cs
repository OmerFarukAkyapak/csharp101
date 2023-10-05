using System;
using System.Collections;
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

        List<User> usersList = new List<User>();
        usersList.Add(new User
        {
            Name = "Faruk",
            Surname = "Akyapak",
            Age = 22
        });

        //ArrayList is a non-generic class
        //It can store any type of data
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Faruk");
        arrayList.Add(true);

        //Dictionary<TKey, TValue> is a generic class
        //TKey is the type of the keys in the dictionary
        //TValue is the type of the values in the dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Faruk");
        dictionary.Add(2, "Enes");
        dictionary.Add(3, "Ozi");

        //Print List
        Console.WriteLine("Name List: ");
        PrintList(namesList);
        Console.WriteLine("");
        Console.WriteLine("Nubmer List: ");
        PrintList(numbersList);
        Console.WriteLine("");
        Console.WriteLine("User List: ");
        PrintList(usersList);
        Console.WriteLine("");
        Console.WriteLine("ArrayList: ");
        PrintList(arrayList);
        Console.WriteLine("");
        Console.WriteLine("Dictionary: ");
        PrintList(dictionary);
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
    static void PrintList(List<User> list)
    {
        list.ForEach(u => Console.WriteLine(u.Name + " " + u.Surname + " " + u.Age + "\n"));
    }
    static void PrintList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    static void PrintList(Dictionary<int, string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}


public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}