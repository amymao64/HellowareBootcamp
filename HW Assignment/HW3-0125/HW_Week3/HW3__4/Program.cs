using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Lucky", "Corgi", "Gold", 2);
            Cat cat = new Cat("MeatBall", "Black",3, 2.3, 2);
            Bird bird = new Bird("Annie", "Blue", 4, 1.1, 2, 3);

            Console.WriteLine(dog.GetMonthlyCost());
            Console.WriteLine(cat.GetMonthlyCost());
            Console.WriteLine(bird.GetMonthlyCost());

        }
    }
}
