using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Shape
    {

        public Shape(double width, double height)
        {
            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
        }


        public Shape(double radius)
        {
            radius = int.Parse(Console.ReadLine());
        }


        private double recwidth;

        public double Width
        {
            get
            {
                return recwidth;
            }
            set
            {
                recwidth = value;
            }
        }


        private double recheight;

        public double Height
        {
            get
            {
                return recheight;
            }
            set
            {
                recheight = value;
            }
        }

        

        public double GetRecArea(double width, double height)
        {
            return width * height;
        }

        private double cicradius;

        public double Radius
        {
            get
            {
                return cicradius;
            }

            set
            {
                Radius = value;
            }
        }

        public double GetCicArea(double radius)
        {
            return Math.PI*radius*radius;
        }

    }
    }

  