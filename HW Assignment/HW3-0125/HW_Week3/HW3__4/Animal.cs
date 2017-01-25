using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__4
{
    abstract class Animal
    {
        private int age;
        private string color;
        private string name;

        public Animal(string name, string color, int age)
        {
            this.name = name;           
            this.color = color;
            this.age = age;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }       
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age= value;
            }
        }

        public double GetMonthlyCost()
        {
            return 0.0;
        }
    }
}
