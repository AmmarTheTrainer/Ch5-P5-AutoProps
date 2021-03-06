﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P5_AutoProps
{
    class Car
    {
        // Automatic properties!No need to define backing fields.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        // Read-only property? This is OK!
        public int MyReadOnlyProp { get; }
        //// Write only property? Error!
        //public int MyWriteOnlyProp { set; }

        public Car()
        {
           // MyReadOnlyProp = 23; // why there is no error ?
        }


        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
