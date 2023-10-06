using System;

//Creatures is the base class
public class Creatures
{
    //Respire and Nutrition are protected methods
    protected void Respire()
    {
        Console.WriteLine("Creatures are breathing");
    }
    protected void Nutrition()
    {
        Console.WriteLine("Creatures are eating");
    }
}