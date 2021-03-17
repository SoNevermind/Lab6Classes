using System;

namespace LabWork6Classes
{
    public class MainClass
    {
        static void Main(String[] args)
        {
            Car car = new Car() { carName = "Something car name", carType = "Something car type" };
            car.Run();
            Car car1 = (Car)car.Clone();
            car1.carName = "Something new car name";
            Console.WriteLine(car.carName + "\n");

            Helycopter helycopter = new Helycopter() { helName = "Something helycopter name", helType = "Something helycopter type" };
            helycopter.Run();
            Helycopter helycopter1 = (Helycopter)helycopter.Clone();
            helycopter1.helName = "Something new helycopter name";
            Console.WriteLine(helycopter.helName + "\n");

            FreightCar freightCar = new FreightCar() { freightName = "Something freight car name", freightNumber = 326236 };
            FreightCar freightCar1 = new FreightCar() { freightName = "Something freight car name number 1", freightNumber = 84568 };
            FreightCar freightCar2 = new FreightCar() { freightName = "Something freight car name numer 2", freightNumber = 47544 };

            FreightCar[] freightCars = new FreightCar[] { freightCar, freightCar1, freightCar2 };
            Array.Sort(freightCars);

            foreach(FreightCar freight in freightCars)
            {
                Console.WriteLine(freight.freightName + " - " + freight.freightNumber);
            }

            Console.WriteLine();

            PassengerCar passengerCar = new PassengerCar();
            passengerCar.Run();
        }
    }
}
