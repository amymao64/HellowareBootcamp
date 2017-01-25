using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__4
{
    class Dog : Animal
    {
        private string breed;

        public Dog(string name, string breed, string color, int age) : base(name, color, age)
        {
            this.breed = breed;
        }

        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }

        }

        public virtual new double GetMonthlyCost()
        {
            return Age * 3.11;
        }

    }
}
