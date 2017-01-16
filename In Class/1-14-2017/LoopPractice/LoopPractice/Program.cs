using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            Console.WriteLine("Type a number here please:");
            int result = int.Parse(Console.ReadLine());
            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.WriteLine(i + 1 + "");
                }

            }


        }
    }
}
