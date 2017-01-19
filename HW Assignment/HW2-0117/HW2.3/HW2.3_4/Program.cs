using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3_4
{
    class Program
    {
        private static int numResult;

        static void Main(string[] args)
        {
            Console.WriteLine("Which order of Fibonacci Number you would like to get?");
            int n = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;

           
            int[] numArr = new int[n+1];

            if (n == 0)
            {
                Console.WriteLine("This " + n + "th order fibonacci numberf is:" + f0);
            }

            if (n == 1)
            {
                Console.WriteLine("This"+n+"th order fibonacci numberf is:"+f1);
            }
               
            if (n > 1)
            {
                numArr[0] = f0;
                numArr[1] = f1;
                for (int i = 2; i < n+1; i++)
                {
                    numArr[i] = numArr[i-1] + numArr[i-2];
                    numResult = numArr[i];
                }
                Console.WriteLine("This " + n + "th order fibonacci numberf is:" + numResult);
            }
   

        }
    }
}
