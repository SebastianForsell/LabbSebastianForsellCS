using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Juice : EcoStockItem
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
