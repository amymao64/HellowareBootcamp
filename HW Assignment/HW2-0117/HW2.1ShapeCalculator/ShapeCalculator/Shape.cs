using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Shape
    {
        private double recwidth;
        private double recheight;
        private double cicradius;

        public Shape (double width, double height)
        {
            recwidth = width;
            recheight = height;
        }


        public Shape (double radius)
        {
            cicradius = radius;
        }

        public double Cicradius
        {
            get
            {
                return cicradius;
            }

            set
            {
                cicradius = value;
            }
        }



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
            return recwidth * height;
        }

        public double GetCirArea(double cicradius)
        {
            return Math.PI*cicradius*cicradius;
        }

    }
    }

  