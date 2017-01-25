using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {

        const double pI = 3.14;

        //statics/class method 
        public static void Main(string[] args) //statics member of class
        {
            Console.WriteLine(company.CompanyName);
        }

        //instance members 
        //instance method == objecct 
        //instance variable 
        //instance property
        public void TestTest()
        {

        }
    }

    static class company
    {
        static string companyName = "Helloware";
        static int yearFounded = 2016;


        public static string CompanyName 
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public static int YearFounded
        {
            get
            {
                return yearFounded;
            }

            set
            {
                yearFounded = value;
            }
        }

        static






    class Test //:Object---> all the class are 
        {
            static void TestMain(string[] args)
            {
                Program program = new Program();
                program.TestTest();



            }
        }
    }
}
