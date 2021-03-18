using System;

namespace LabWork6Classes
{
    public class DelAdd<T>
    {
        public void Add(T input) { }
    }

    public class NewGen : IEquatable<NewGen>
    {
        public string GenName { get; set; }
        public string GenId { get; set; }

        public override string ToString()
        {
            return "Name - " + GenName + "  Id - " + GenId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            NewGen newGen = obj as NewGen;
            if (newGen == null) return false;
            else return Equals(newGen);
        }

        public override int GetHashCode()
        {
            return GenId;
        }

        public bool Equals(NewGen gen)
        {
            if (gen == null) return false;
            return (this.GenId.Equals(gen.GenId));
        }
    }

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

            DelAdd<string> delAdd = new DelAdd<string>();
            Console.WriteLine(delAdd.Add("New string from new generic class"));

            List<NewGen> list = new List<NewGen>();

            list.Add(new NewGen() { GenName = "Some name first", GenId = 12463 });
            list.Add(new NewGen() { GenName = "Some name second", GenId = 74344 });

            Console.WriteLine();
            foreach(NewGen gen in list)
            {
                Console.WriteLine(list);
            }

            list.RemoveAt(1);

            Console.WriteLine();
            foreach (NewGen gen in list)
            {
                Console.WriteLine(list);
            }

            list.RemoveAt(1);

            Console.WriteLine();
            foreach (NewGen gen in list)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
