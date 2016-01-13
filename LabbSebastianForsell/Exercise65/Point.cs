using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Point
    {
        internal int y;
        internal int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point()
        {
            X = 40;
            Y = 2;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point3D(1, 2, 3);
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
