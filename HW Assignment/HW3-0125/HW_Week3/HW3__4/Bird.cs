using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__4
{
    class Bird:Animal

    {
        private double weight;
        private double mealCost;
        private int mealCountPerDay;

        public Bird(string name, string color, int age, double mealCost, double weight,int mealCountPerDay) : base(name, color, age)
        {
            this.mealCost = mealCost;
            this.mealCountPerDay = mealCountPerDay;
            this.weight = weight;
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
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }

        }

        public virtual new double GetMonthlyCost()
        {
            return MealCost * mealCountPerDay + weight / 2.41;
        }


    }
}
