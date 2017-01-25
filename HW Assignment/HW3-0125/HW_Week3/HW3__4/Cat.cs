using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__4
{
    class Cat:Animal
    {
        private double mealCost;
        private int mealCountPerDay;

        public Cat(string name, string color, int age, double mealCost, int mealCountPerDay) : base(name, color, age)
        {
            this.mealCost = mealCost;
            this.mealCountPerDay = mealCountPerDay;
        }

        public double MealCost
        {
            get
            {
                return mealCost;
            }

            set
            {
                mealCost = value;
            }

        }

        public int MealCountPerDay
        {
            get
            {
                return mealCountPerDay;
            }

            set
            {
                mealCountPerDay = value;
            }

        }

        public virtual new double GetMonthlyCost()
        {
            return MealCost*mealCountPerDay+Age*1.1/5;
        }



    }
}
