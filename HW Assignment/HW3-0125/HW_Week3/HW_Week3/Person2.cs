using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week3
{

    public enum Gender
    {
        Male,
        Female,
    }



    class Person2
    {
        private int _age;
        private string _gender;
        private string _name;

        public bool SetAge (int Age)
        {
            if (_age > 120 || _age < 0)
                return false;
            Age = _age;
            return true;

        }
        public int Age
        {
            get;
            private set;
        }
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        public string Name
        {
            get
            {
                return "John";
            }
        }

        public Person2 (string name,int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }


        public List<Person2> GetAllInfor()
        {
            return new List<Person2>();
        }
    }
}
