using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class MyDoubleType
    {
        public double DoubleValue { get; set; }
        public MyDoubleType(double myDouble)
        {
            DoubleValue = myDouble;
        }
        public static MyDoubleType operator +(double number, MyDoubleType myDoubleType)
        {
            myDoubleType.DoubleValue += number;
            return myDoubleType;
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType, double number)
        {
            myDoubleType.DoubleValue += number;
            return myDoubleType;
        }
        public static MyDoubleType operator -(double number, MyDoubleType myDoubleType)
        {
            myDoubleType.DoubleValue -= number;
            return myDoubleType;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double number)
        {
            myDoubleType.DoubleValue -= number;
            return myDoubleType;
        }
        public static MyDoubleType operator *(double number, MyDoubleType myDoubleType)
        {
            myDoubleType.DoubleValue *= number;
            return myDoubleType;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, double number)
        {
            myDoubleType.DoubleValue *= number;
            return myDoubleType;
        }
        public static MyDoubleType operator /(double number, MyDoubleType myDoubleType)
        {
            myDoubleType.DoubleValue += number;
            return myDoubleType;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double number)
        {
            myDoubleType.DoubleValue += number;
            return myDoubleType;
        }
        public static bool operator ==(MyDoubleType myDoubleType, double number)
        {
            myDoubleType.DoubleValue = number;
            return true;
        }
        public static bool operator !=(MyDoubleType myDoubleType, double number)
        {
            var boolean = myDoubleType.DoubleValue != number;
            return boolean;
        }

        public static bool operator <(MyDoubleType myDoubleType, double number)
        {
            var test = myDoubleType.DoubleValue <= number;
            return test;
        }
        public static bool operator >(MyDoubleType myDoubleType, double number)
        {
            var test = myDoubleType.DoubleValue >= number;
            return test;
        }

        public static bool operator <=(MyDoubleType myDoubleType, double number)
        {
            var sebbe = myDoubleType.DoubleValue <= number;
            return sebbe;
        }

        public static bool operator >=(MyDoubleType myDoubleType, double number)
        {
            var sebbe = myDoubleType.DoubleValue >= number;
            return sebbe;
        }

        public override string ToString()
        {
            return $"MyDoubleValue: {DoubleValue}";
        }
    }
}
