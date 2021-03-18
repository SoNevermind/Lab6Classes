using System;

namespace LabWork6Classes
{
    abstract class TechMean
    {
        public abstract void Run();
    }

    class Car : TechMean, ICloneable
    {
        public string carName { get; set; }
        public string carType { get; set; }

        public override void Run()
        {
            Console.WriteLine("Car rides....");
        }

        public object Clone()
        {
            return new Car { carName = this.carName, carType = this.carType };
        }
    }

    class Helycopter : TechMean, ICloneable
    {
        public string helName { get; set; }
        public string helType { get; set; }

        public override void Run()
        {
            Console.WriteLine("Helycopter flying....");
        }

        public object Clone()
        {
            return new Helycopter { helName = this.helName, helType = this.helType };
        }
    }
}
