using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//E1: write a Person class. 
//Each Person object can have different nationality, different gender, 
//different race.You need to write constructor and use “this” keyword.
//本题训练constructor 和 “this” 关键字

namespace HW_Week3
{
    class Person
    {
        private string gender;
        private string nationality;
        private string race;
        

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender= value;
            }
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }
        public string Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }


        public Person (string nationality, string gender, string race)
        {
            this.nationality = nationality;
            this.gender = gender;
            this.race = race;
        }

    }
}
