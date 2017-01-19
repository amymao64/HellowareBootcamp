using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of your array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[n];
            string[] numValue = new string[n];

            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numArr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
               numValue[i]=Convert.ToString(numArr[i]);
                Console.Write(numValue[i] + " ");
            }

             
            
        }
    }
}
