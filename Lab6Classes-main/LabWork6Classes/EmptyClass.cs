using System;

namespace LabWork6Classes
{
    class FreightCar : Car, IComparable<FreightCar>
    {
        public string freightName { get; set; }
        public int freightNumber { get; set; }

        public override void Run()
        {
            Console.WriteLine("Freight car rides.....");
        }

        public int CompareTo(FreightCar freight)
        {
            return this.freightName.CompareTo(freight.freightName);
        }
    }

    class PassengerCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Passenger car rides.....");
        }
    }
}
