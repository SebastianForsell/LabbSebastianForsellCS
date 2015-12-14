using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class House
    {
        private int numberOfDoors;
        private int numberOfWindows;
        private string roofColour;
        private string facade;
        private Table table;

        public void SetNumberOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
        }
        public int GetNumberOfDoors()
        {
            return this.numberOfDoors;
        }
        public void SetNumberOfWindows(int numberOfWindows)
        {
            this.numberOfWindows = numberOfWindows;
        }
        public int GetNumberOfWindows()
        {
            return this.numberOfWindows;
        }
        public void SetRoofColour(string roofColour)
        {
            this.roofColour = roofColour;
        }
        public string GetRoofColour()
        {
            return this.roofColour;
        }
        public void SetFacade(string facade)
        {
            this.facade = facade;
        }
        public string GetFacade()
        {
            return this.facade;
        }
        public void SetTable(Table table)
        {
            this.table = table;
        }
        public Table GetTable()
        {
            return this.table;
        }

        public override string ToString() => $"Mitt hus har: {GetNumberOfDoors()} dörrar, {GetNumberOfWindows()} fönster, {GetRoofColour()} tak" + 
            $" och {GetFacade()} fasad. {table}";
    }
}
