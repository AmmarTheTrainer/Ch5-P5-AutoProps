﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P5_AutoProps
{
    class Garage
    {
        //// The hidden int backing field is set to zero!
        //public int NumberOfCars { get; set; }
        //// The hidden Car backing field is set to null!
        //public Car MyAuto { get; set; }


        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; } = 1;
        // The hidden Car backing field is set to null!
        public Car MyAuto { get; set; } = new Car();


        // Must use constructors to override default
        // values assigned to hidden backing fields.
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
