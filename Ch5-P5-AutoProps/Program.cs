using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P5_AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto Implemented Properties

            #region ReadOnly Auto-Implemented Propertes

            //Car car = new Car();
            //car.MyReadOnlyProp = 22;

            //Console.WriteLine(car.MyReadOnlyProp);

            #endregion

            #region Interacting with Automatic Properties

            //Car c = new Car();
            //c.PetName = "Frank";
            //c.Speed = 55;
            //c.Color = "Red";

            //Console.WriteLine("Your car is named {0}? That's odd...",c.PetName);

            //c.DisplayStats();

            #endregion

            #region Automatic Properties and Default Values

            //Garage g = new Garage();
            //// OK, prints default value of zero.
            //Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            //// Runtime error! Backing field is currently null!
            //Console.WriteLine(g.MyAuto.PetName); // Error


            // Make a car.
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();
            // Put car in the garage.
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            #endregion

            Console.ReadLine();
        }
    }
}
