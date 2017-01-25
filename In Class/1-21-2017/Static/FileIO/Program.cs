using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("TextFile1.txt"));
            //File.WriteAllText("TextFile1.txt", "Huijie Li");
            //Console.WriteLine(File.ReadAllText("TextFile1.txt"));

            FileStream fileStream = new FileStream("TextFile1.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            for (int i = 0; i <= 20; i++)
            {
                Console.Write((char)fileStream.ReadByte() + " ");
            }


            
        }
    }
}
