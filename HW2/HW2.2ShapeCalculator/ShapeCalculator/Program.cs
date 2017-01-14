using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which type shape's area you want to calculate? Rectangle or Circle");
            String result = Console.ReadLine();

            {
                if (result == "Rectangle") 
                {
                    Console.WriteLine("Please type your width here:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please type your height here:");
                    double height = double.Parse(Console.ReadLine());
                    Shape s = new Shape(width, height);
                    double ans = s.GetRecArea(width, height);
                    Console.WriteLine("The area of rectangle is:" + ans);
                }


            else 
                {
                    Console.WriteLine("Please type your radius here:");
                    double radius = double.Parse(Console.ReadLine());
                    Shape s2 = new Shape(radius);
                    double ans = s2.GetCicArea(radius);
                    Console.WriteLine("The area of cicrle is:" + ans);

                }
            }


        }
    }
}


