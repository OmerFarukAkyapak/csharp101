using System;

namespace abstracts
{
    public class Civic : ICars
    {
        public string Mark { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.WriteLine("Civic is driving...");
        }

        public string Engine()
        {
            return "2.0";
        }
    }
}