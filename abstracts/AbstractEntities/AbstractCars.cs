using System;

namespace abstracts
{
    public abstract class AbstractCars
    {
        public virtual string Mark { get; set; }
        public virtual string Color { get; set; }
        public virtual int Year { get; set; }
        public abstract string Engine();
        public abstract void Drive();
    }

}