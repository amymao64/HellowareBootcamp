using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your email address here:");
            string text = Console.ReadLine();

            int startIndex = 0;
            int length = text.IndexOf("@");
            String substring = text.Substring(startIndex, length);
            Console.WriteLine(substring);



      
        }
    }
}
