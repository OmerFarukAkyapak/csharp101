using System;

namespace abstracts
{
    public interface ICars
    {
        public string Mark { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Engine();
        public void Drive();
    }
}