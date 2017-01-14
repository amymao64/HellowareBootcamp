using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        static void Main(string[] args)
        {

            Calculator c = new Calculator();

            Console.WriteLine("Which operation do you need? Choose +, -,*, or /  then hit enter:");


            switch (Console.ReadLine())
            {
                case "+":
                    {
                        Console.WriteLine("How many numbers in this calculation? 2 or 3");

                        switch (Console.ReadLine())
                        {

                            case "2":
                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    double sum = c.Addition(x, y);
                                    Console.WriteLine("The sum is:" + sum);
                                    break;
                                }

                            case "3":

                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your thrid number, hit enter:");
                                    double z = double.Parse(Console.ReadLine());
                                    double sum2 = c.Addition(x, y, z);
                                    Console.WriteLine("The sum is:" + sum2);
                                    break;
                                }
                        }
                        Console.ReadKey();
                        break;


                    }
                case "-":
                    {
                        Console.WriteLine("How many numbers in this calculation? 2 or 3");

                        switch (Console.ReadLine())
                        {

                            case "2":
                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    double diff = c.Subtraction(x, y);
                                    Console.WriteLine("The difference is:" + diff);
                                    break;
                                }

                            case "3":

                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your thrid number, hit enter:");
                                    double z = double.Parse(Console.ReadLine());
                                    double diff2 = c.Subtraction(x, y, z);
                                    Console.WriteLine("The difference between the first number to the last number is:" + diff2);
                                    break;
                                }
                        }

                        Console.ReadKey();
                        break;

                    }

                case "*":
                    {
                        Console.WriteLine("How many numbers in this calculation? 2 or 3");

                        switch (Console.ReadLine())
                        {

                            case "2":
                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    double Multi = c.Multiply(x, y);
                                    Console.WriteLine("The multiply is:" + Multi);
                                    break;
                                }

                            case "3":

                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your thrid number, hit enter:");
                                    double z = double.Parse(Console.ReadLine());
                                    double Multi2 = c.Multiply(x, y, z);
                                    Console.WriteLine("The multiply is:" + Multi2);

                                    break;
                                }
                        }
                        Console.ReadKey();
                        break;


                    }

                case "/":
                    {
                        Console.WriteLine("How many numbers in this calculation? 2 or 3");

                        switch (Console.ReadLine())
                        {

                            case "2":
                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    double divi = c.Division(x, y);
                                    Console.WriteLine("The division is:" + divi);
                                    break;
                                }

                            case "3":

                                {
                                    Console.WriteLine("Enter your first number, hit enter:");
                                    double x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your second number, hit enter:");
                                    double y = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter your thrid number, hit enter:");
                                    double z = double.Parse(Console.ReadLine());
                                    double divi2 = c.Division(x, y, z);
                                    Console.WriteLine("The division is:" + divi2);
                                    break;
                                }
                        }
                        Console.ReadKey();
                        break;

                    }
            }
        }
    }
}








