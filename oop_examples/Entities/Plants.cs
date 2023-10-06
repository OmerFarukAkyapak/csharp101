using System;

namespace Entities;
//Plans are Creatures
public class Plants : Creatures
{
    public override void Live()
    {
        base.Live();
        Console.WriteLine("Plants are living in water and land");
    }
    //Photosynthesis is a protected method
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants are photosynthesizing");
    }

    //Seed plants and Seedless plants are Plants
    //Sealed class
    public sealed class SeedPlants : Plants
    {
        //Seed plants are Plants
        public SeedPlants()
        {
            base.Respire();
            base.Nutrition();
            base.Photosynthesis();
            Console.WriteLine("Seed plants are being created");
        }
        public void Seed()
        {
            Console.WriteLine("Seed plants are seeding");
        }
        public override void Live()
        {
            base.Live();
            Console.WriteLine("Seed plants are living in water and land");
        }
    }
    public sealed class SeedlessPlants : Plants
    {
        //Seedless plants are Plants
        public SeedlessPlants()
        {
            base.Respire();
            base.Nutrition();
            base.Photosynthesis();
            Console.WriteLine("Seedless plants are being created");
        }
        public void Spore()
        {
            Console.WriteLine("Seedless plants are sporing");
        }
        public override void Live()
        {
            base.Live();
            Console.WriteLine("Seedless plants are living in water and land");
        }
    }
}
