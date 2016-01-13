using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class StockItem
    {
        private int id;
        private string name;
        private int stockCountInt;

        public int StockCountInt
        {
            get { return stockCountInt; }
            set { stockCountInt = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return $"Stock Item";
        }
    }
}
