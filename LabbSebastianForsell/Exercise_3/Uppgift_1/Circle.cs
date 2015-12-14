using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Circle
    {
        private double diameter;
        private Point centre;
        public void SetDiameter( double diameter)
        {
            this.diameter = diameter;
        }
        public double GetDiameter()
        {
            return this.diameter;
        }
        public double GetCircumference()
        {
            return this.diameter * 3.1416;
        }
        public void SetCentre(Point p)
        {
            this.centre = p;
        }
        public Point GetCentre()
        {
            return this.centre;
        }
    }
}
