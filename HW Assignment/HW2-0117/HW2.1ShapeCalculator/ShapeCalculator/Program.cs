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

            Console.WriteLine("Which type of shape's area you want to calculate? Rectangle or Circle");
            String result = Console.ReadLine();

            {
                if (result == "Rectangle") 
                {
                    Console.WriteLine("Please type your width here:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please type your height here:");
                    double height = double.Parse(Console.ReadLine());
                    Shape shapeArea = new Shape(width, height);
                    double ans = shapeArea.GetRecArea(width, height);
                    Console.WriteLine("The area of rectangle is:" + ans);
                }


            else 
                {
                    Console.WriteLine("Please type your radius here:");
                    double radius = double.Parse(Console.ReadLine());
                    Shape shapeArea2 = new Shape(radius);
                    double ans2 = shapeArea2.GetCirArea(radius);
                    Console.WriteLine("The area of cicrle is:" + ans2);

                }
                
            }


        }
    }
}


