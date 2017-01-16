using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3_3
{
    class Program
    {

        static void Main(string[] args)
        {
            string result;
            int max = 0;
            while (true)
            {
                Console.WriteLine("Please type any positive int or end in order to find the max");
                result = (Console.ReadLine());


                if (result == "end")
                {
                    Console.WriteLine("The max number is:" + max);
                    break;
                }


                int numResult = Convert.ToInt32(result);
                if (numResult > max)
                {
                    max = numResult;

                }

            }

        }


    }
}

