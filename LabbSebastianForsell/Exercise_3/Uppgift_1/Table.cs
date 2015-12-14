using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Table
    {
        private int width;
        private int height;
        private int numberOfLegs;
        private string colour; 

        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public  void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetNumberOfLegs(int tableLegs)
        {
            this.numberOfLegs = tableLegs;
        }
        public int GetNumberOfLegs()
        {
            return this.numberOfLegs;
        }
        public void SetColour(string colour)
        {
            this.colour = colour;
        }
        public string GetColour()
        {
            return this.colour;
        }
        public override string ToString() => $"Mitt bord inne i huset är {GetWidth()}decimeter brett och {GetHeight()}decimeter högt, den har också {GetNumberOfLegs()} ben och har {GetColour()} färg.";
    }
}
