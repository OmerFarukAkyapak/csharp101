using System;

namespace abstracts
{
    public class BMW : ICars
    {
        public string Mark { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.WriteLine("BMW is driving...");
        }

        public string Engine()
        {
            return "2.0";
        }
    }

}