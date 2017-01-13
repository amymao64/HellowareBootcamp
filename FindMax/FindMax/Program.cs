using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a group (limit at 5 elements) of int number below :");
            int[] number = new int[5];
         
            
            for (int i=0;i<number.Length;i++)
            {
                number[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] > number[i++])


                {
                    int max = number[i];
                    Console.WriteLine("The max number is:" + max);
                }


                else
                {
                    int max = number[i++];
                    Console.WriteLine("The max number is:" + max);
                }
            }



        }
    }
}
