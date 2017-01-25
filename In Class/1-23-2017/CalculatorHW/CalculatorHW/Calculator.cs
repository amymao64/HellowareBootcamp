using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHW
{
    class Calculator
    {
        private static double firstNum;
        private static double secondNum;


        public static double FirstNum
        {
            get
            {
                return firstNum;
            }

            set
            {
                firstNum = value;
            }
        }

        public static double SecondNum
        {
            get
            {
                return secondNum;
            }

            set
            {
                secondNum = value;
            }
        }
        

      public static double Addition(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public static double Subtraction(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public static double Divided(double firstNum, double secondNum)
        {
            return firstNum/secondNum;
        }

        public static double Square(double num)
        {
            return num * num;
        }

        internal static double Addition()
        {
            throw new NotImplementedException();
        }

        internal static double Subtraction()
        {
            throw new NotImplementedException();
        }

        internal static double Multiply()
        {
            throw new NotImplementedException();
        }

        internal static double Divided()
        {
            throw new NotImplementedException();
        }

        internal static double Square()
        {
            throw new NotImplementedException();
        }
    }
}
