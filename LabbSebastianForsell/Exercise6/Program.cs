using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppgift1
            float f = 4.55555555555555555555555555555555555555F;
            long myLong = 32675372435L;
            char myChar = 'S';
            string myString = "Jippi Kajak!";
            ulong jag = 126785742345324358;

            MyDoubleType first = new MyDoubleType(9);
            bool saningen = first == 2.0;
            Console.WriteLine(first);

            //Point point = new Point(4, 2);
            //Console.WriteLine($"Point: {point}");

            //Point point = new Point() { X = 42, Y = 666 };
            //Console.WriteLine($"Point: {point}");

            //Point3D point3D = point;
            //Console.WriteLine($"My Point3D from the class Point: {point3D}");

            //point3D.Z = 23;
            //Console.WriteLine(point3D);
        }
    }
}
