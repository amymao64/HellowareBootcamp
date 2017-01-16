using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3_2
{
    class Program
    {
       
        static void Main(string[] args)
        {

            string resultName;
            string resultPassword;
            Console.WriteLine("Please type your username:");
            resultName = Console.ReadLine();
            Console.WriteLine("Please type your password:");
            resultPassword = Console.ReadLine();

            

            //while (resultName != "hello" || resultPassword != "123")
            //{
            //    Console.WriteLine("Please type your username:");
            //    resultName = Console.ReadLine();
            //    Console.WriteLine("Please type your password:");
            //    resultPassword = Console.ReadLine();
            //}


            while (true)
            {
                if (resultName != "hello" || resultPassword != "123")
                {
                    Console.WriteLine("Please type your username:");
                    resultName = Console.ReadLine();
                    Console.WriteLine("Please type your password:");
                    resultPassword = Console.ReadLine();
                }
                else break;
            }
        }

    }
    }

