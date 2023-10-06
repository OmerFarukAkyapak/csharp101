using System;
using static Entities.Animals;
using static Entities.Plants;


namespace oop_examples;

class Program
{
    static void Main(string[] args)
    {
        //Inheritance example
        Console.WriteLine("Inheritance Example!" + "\n");

        SeedPlants seedPlant = new SeedPlants();
        seedPlant.Live();
        // seedPlant.Respire();
        // seedPlant.Photosynthesis();
        seedPlant.Seed();

        Console.WriteLine("\n" + "********" + "\n");

        Birds bird = new Birds();
        bird.Live();
        // bird.Respire();
        // bird.Locomotion();
        bird.Feathers();

        Console.ReadLine();
    }
}
