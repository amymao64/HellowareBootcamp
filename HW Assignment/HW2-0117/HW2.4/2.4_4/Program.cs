using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_4
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please type any numerical, character or symbol here:");
            string text = Console.ReadLine();
            text = text.Replace("0", "zero");
            text = text.Replace("1", "one");
            text = text.Replace("2", "two");
            text = text.Replace("3", "three");
            text = text.Replace("4", "four");
            text = text.Replace("5", "five");
            text = text.Replace("6", "six");
            text = text.Replace("7", "seven");
            text = text.Replace("8", "eight");
            text = text.Replace("9", "nine");
            
            Console.WriteLine(text);




            //    Program t = new Program();

            //    Console.WriteLine("Please type any numerical, character or symbol here:");
            //    int n = int.Parse(Console.ReadLine());
            //    string str = t.convert(n);
            //    Console.WriteLine(str);
            //    Console.ReadLine();

            //}

            //private string convert(int n)
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}




  