using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of your array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[n];

            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i <n ; i++)
            {
                sum= sum+numArr[i];
            }
            Console.WriteLine("The sum of all elements in this array is:" + sum);

        }
    }
}
