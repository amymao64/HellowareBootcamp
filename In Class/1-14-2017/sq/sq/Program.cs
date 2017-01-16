using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type any number:");
            int resule = int.Parse(Console.ReadLine());
            for (int i = 0; i < resule; i++)
            {
                Console.Write(Math.Pow(2,i) + " ");
            }
          
        }
    }
}
