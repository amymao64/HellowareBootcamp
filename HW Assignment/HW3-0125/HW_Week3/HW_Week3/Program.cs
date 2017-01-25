using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person2> PersonList = new List<Person2>();
            PersonList.Add(new Person2("Amy", 22, "Female"));
            PersonList.Add(new Person2("Andy", 22, "Male"));
            PersonList.Insert(0, new Person2("Eric", 25, "Male"));

          
            foreach (Person2 p in PersonList)
            {
                Console.WriteLine(PersonList);
            }
            

        }

        
           
   

    }
    }

