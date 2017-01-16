using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Toyota", "Highlander", 2004);

            Console.WriteLine(vehicle.Model);

            vehicle.Start();
            vehicle.Accelerate(10, 2);
            vehicle.Accelerate(2, 2);
            Console.WriteLine(vehicle.Speed);
            vehicle.Decelerate(5, 2);
            vehicle.Decelerate(2, 2);
            Console.WriteLine(vehicle.Speed);
            vehicle.Stop();
            vehicle.Accelerate(2, 2);
            Console.WriteLine(vehicle.Speed);




        }
    }
}
