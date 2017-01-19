using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a sentence:");
            string text = Console.ReadLine();

            

            Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));

        }
    }
}
