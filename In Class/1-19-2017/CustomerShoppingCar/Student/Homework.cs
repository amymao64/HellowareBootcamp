using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Homework
    {

        private int number;
        private string topic;
        private string description;
        private DateTime StartDate
        {
            get
            {
                return StartDate;
            }

            set
            {
                StartDate = DateTime.Now;
            }
        }

        private DateTime DueDate
        {
            get
            {
                return DueDate;
            }

            set
            {
                StartDate = DateTime.Now;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Topic
        {
            get
            {
                return topic;
            }

            set
            {
                topic = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

    }
}
