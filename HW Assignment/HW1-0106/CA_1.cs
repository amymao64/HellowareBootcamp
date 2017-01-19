using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type Your First Name:");
            String userFirstName = Console.ReadLine();
            Console.WriteLine("Type Your Last Name:");
            String userLastName = Console.ReadLine();

            Console.WriteLine("Type Your Age:");
            String userAge = Console.ReadLine();
            Console.WriteLine("Type Your Gender:M or F");


            DateTime dt = DateTime.Now;
            if (dt.Hour > 18 || dt.Hour<6) 
            { string userTitle = Console.ReadLine();
                if (userTitle == "F")
                    Console.WriteLine("Good Evening! " + "Mrs." + userLastName + "," + "Age" + userAge + ".");
                else Console.WriteLine("Good Evening! " + "Mr." + userLastName + "," + "Age" + userAge + "."); }
            

            else 
            {
                string userTitle = Console.ReadLine();
                if (userTitle == "M")
                    Console.WriteLine("Good Day! " + "Mrs." + userLastName + "," + "Age" + userAge + ".");
              else Console.WriteLine("Good Day! " + "Mr." + userLastName + "," + "Age" + userAge + ".");
            }
        

            Console.ReadLine();
        }
    }
}
