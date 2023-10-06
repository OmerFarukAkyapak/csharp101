using System;

namespace abstracts
{
    public class AbstractCivic : AbstractCars
    {
        public override string Engine()
        {
            return "1.6";
        }
        public override void Drive()
        {
            Console.WriteLine("Abstract Civic is driving...");
        }
    }
}