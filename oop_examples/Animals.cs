using System;

//Animals are Creatures
public class Animals : Creatures
{
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
    }
}