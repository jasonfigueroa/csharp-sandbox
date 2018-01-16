using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = "Toyota";
            string model = "Prius";
            string color = "black";
            string year = "2015";
            Car prius = new Car(make, model, color, year);

            Console.WriteLine();

            prius.Color = "red";

            Console.WriteLine();

            Fleet fleet = new Fleet();
            fleet.Inventory.Add(prius);

            Console.WriteLine();
        }
    }
}
