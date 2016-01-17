using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class EcoStockItem : StockItem
    {
        private string marke;

        public string Marke
        {
            get { return marke; }
            set { marke = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()} Märke: {marke}";
        }
    }
}
