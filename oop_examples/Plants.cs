using System;

//Plans are Creatures
public class Plants : Creatures
{
    //Photosynthesis is a protected method
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants are photosynthesizing");
    }

    public class SeedPlants : Plants
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
    }
    public class SeedlessPlants : Plants
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
    }
}
