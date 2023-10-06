using System;
using System.Dynamic;
using static Animals;
using static Plants;


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

        Console.WriteLine("********");

        Birds bird = new Birds();
        bird.Live();
        // bird.Respire();
        // bird.Locomotion();
        bird.Feathers();

        Console.ReadLine();
    }
}
