using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Stock
    {
        public static int stockCounter = 0;
        public StockItem[] stockItem = new StockItem[500];
        public StockItem this[int index]
        {
            get
            {
                return stockItem[index];
            }
            set
            {
                stockItem[index] = value;
            }
        }
        public void AddItem(StockItem item)
        {
            if (stockCounter < stockItem.Length)
            {
                this[stockCounter] = item;
                stockCounter++;
            }
        }
        public StockItem GetItem(int itemId)
        {
            for (int i = 0; i < stockItem.Length; i++)
            {
                if (stockItem[i] != null && stockItem[i].Id == itemId)
                {
                    return stockItem[i];
                }
            }
            return null;
        }

    }
}
