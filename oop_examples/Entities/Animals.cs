using System;

namespace Entities;

//Animals are Creatures
public class Animals : Creatures
{
    public override void Live()
    {
        base.Live();
        Console.WriteLine("Animals are living in water, land, and air");
    }
    //Locomotion is a protected method
    protected void Locomotion()
    {
        Console.WriteLine("Animals are moving");
    }

    //Reptiles and Birds are Animals
    public class Reptiles : Animals
    {
        //Reptiles are Animals
        public Reptiles()
        {
            base.Respire();
            base.Nutrition();
            base.Locomotion();
            Console.WriteLine("Reptiles are being created");
        }
        public void ColdBlooded()
        {
            Console.WriteLine("Reptiles are cold blooded");
        }
        public override void Live()
        {
            base.Live();
            Console.WriteLine("Reptiles are living in land");
        }
    }
    public class Birds : Animals
    {
        //Birds are Animals
        public Birds()
        {
            base.Respire();
            base.Nutrition();
            base.Locomotion();
            Console.WriteLine("Birds are being created");
        }
        public void Feathers()
        {
            Console.WriteLine("Birds have feathers");
        }
        public override void Live()
        {
            base.Live();
            Console.WriteLine("Birds are living in air");
        }
    }
}