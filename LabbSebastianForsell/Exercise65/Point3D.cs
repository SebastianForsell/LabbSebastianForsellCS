using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Point3D
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public Point3D() : base()
        {
            Z = 20;
        }
        public Point3D(int x, int y, int z) /*:base(x, y)*/
        {
            Z = z;
        }
    }
}
