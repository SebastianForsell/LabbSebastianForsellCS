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
        public StockItem[] stockItem = new StockItem[20];
        public StockItem this[int index]
        {
            get
            {
                return stockItem[index];
            }
            set
            {
                if (index <= 20)
                {
                    stockItem[index] = value;
                }
                else
                {
                    Console.WriteLine("Lagret är fullt!");
                    Console.ReadLine();
                }
            }
        }
        public int Length { get { return stockItem.Length; } }
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
                if (stockItem[itemId] != null && stockItem[itemId].Id == itemId)
                {
                    return stockItem[itemId];
                }
            return null;
        }

    }
}
