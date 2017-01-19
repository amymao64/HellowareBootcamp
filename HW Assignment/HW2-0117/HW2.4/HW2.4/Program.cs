using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._4
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter the size of your array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];


            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToString(Console.ReadLine());
            }

            for (int j = n-1; j > -1; j--)
            {
                Console.Write(arr[j] + " ");
            }

        }
    }
}
