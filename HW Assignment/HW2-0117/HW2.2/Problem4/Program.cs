using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of your array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numberArr = new int[n];


            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numberArr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                if (numberArr[i] > 0)
                {
                    Console.Write(numberArr[i]+1 + " ");
                }
            
                else
                {
                    Console.Write(numberArr[i]-1 + " ");
                }

            }


        }
    }
}
