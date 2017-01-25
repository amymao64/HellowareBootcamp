using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string cellPhone;
        private string emaail;
        private string address;

        public string FirstName
        {
            get
            {
                return firstName;
            }

        }

        public string LastName
        {
            get
            {
                return lastName;
            }

           
        }

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                cellPhone = value;
            }
        }

        public string Emaail
        {
            get
            {
                return emaail;
            }

            set
            {
                emaail = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }


        public Student(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emaail = email;
        }

        public List<double> GetGrades()
        {
            return new List<double>();
        }

        public double GetGradesForHomework(int homeworkNumber)
        {
            return 87.9;
        }

    }
}
