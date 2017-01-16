using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3
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


            int largest = numberArr[0];
            for (int i = 0; i < n; i++)
            {
                if (numberArr[i] > largest)
                {
                    largest = numberArr[i];
                }
            }

            Console.WriteLine("The largest number in the array is:" + largest);
        }
    }
    }

