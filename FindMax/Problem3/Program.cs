using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of your array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strArr = new string[n];

            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                strArr[i] = Convert.ToString(Console.ReadLine());
            }
         
            for (int j = 0; j < n-1; j++)
            {
              
                Console.Write(strArr[j] + "-");
                
            }
            Console.Write(strArr[n]);
        }

        
}
}

