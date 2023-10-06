using System;

namespace abstracts;

class Program
{
    static void Main(string[] args)
    {
        ICars[] cars = new ICars[]
        {
            new Civic { Mark = Mark.Honda.ToString(), Color = Color.Red.ToString(), Year = 2019 },
            new BMW { Mark = Mark.BMW.ToString(), Color = Color.Black.ToString(), Year = 2020 }
        };

        foreach (var car in cars)
        {
            Console.WriteLine($"Mark: {car.Mark}, Color: {car.Color}, Year: {car.Year}, Engine: {car.Engine()}");
            car.Drive();
        }

        AbstractCivic abstractCivic = new AbstractCivic();
        abstractCivic.Mark = Mark.Honda.ToString();
        abstractCivic.Color = Color.Green.ToString();
        abstractCivic.Year = 2013;
        Console.WriteLine($"Mark: {abstractCivic.Mark}, Color: {abstractCivic.Color}, Year: {abstractCivic.Year}, Engine: {abstractCivic.Engine()}");
        abstractCivic.Drive();

        Console.ReadLine();
    }
}
