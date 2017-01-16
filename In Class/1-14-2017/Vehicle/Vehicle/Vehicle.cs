﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private double speed;


        public Vehicle(string make,string model,int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Accelerate(double a, double t)
        {
            speed = speed + a * t;
        }

        public void Decelerate(double a, double t)
        {
            if (a > 0)
            {
                speed = speed - a * t;
            }
            else
            {
                Accelerate(a, t);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public void Start()
        {
            speed = 0;
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
        }

       



    }


}
