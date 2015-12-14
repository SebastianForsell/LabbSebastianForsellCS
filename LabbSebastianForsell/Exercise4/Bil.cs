using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Bil
    {
        private string brand;
        private int numberOfGears;
        private string colour;
        private string type;

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "kupe" || value == "kombi")
                {
                    type = value;
                }
            }
        }


        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int NumberOfGears
        {
            get { return numberOfGears; }
            set { numberOfGears = value; }
        }


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Bil()
        {
            brand = "blabla";
            numberOfGears = 6;
            colour = "Red";
            type = "kupe";
        }
        public Bil(string brand, int numberOfGears, string colour, string type)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Colour = colour;
            Type = type;
        }
        public override string ToString() => $"Märke: {this.brand}\nAntal växlar: {this.numberOfGears}\nFärg: {this.colour}\nTyp: {type}.";
    }
}
