using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    enum StockMenu { Skapa_vara = 1, Inventera_vara, Lista_varor, Avsluta }
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput;
            int itemChoice;
            Stock stock = new Stock();
            bool loops = true;
            do
            {
                Console.Clear();
                int counter = 1;
                foreach (var item in Enum.GetNames(typeof(StockMenu)))
                {
                    Console.WriteLine($"{counter++}: {item}");
                }
                int inNumber;
                if (int.TryParse(Console.ReadLine(), out inNumber))
                {
                    StockMenu choice = (StockMenu)inNumber;
                    switch (choice)
                    {
                        case StockMenu.Skapa_vara:
                            CreateItemsInStock(stock);
                            break;
                        case StockMenu.Inventera_vara:
                            CheckItems(out validInput, out itemChoice, stock);
                            break;
                        case StockMenu.Lista_varor:
                            ListMyItems(stock);
                            break;
                        case StockMenu.Avsluta:
                            loops = false;
                            Console.WriteLine("Hej då!");
                            System.Threading.Thread.Sleep(1500);
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Fel inmatning.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
            while (loops);
        }
        private static void CreateItemsInStock(Stock stock)
        {
            Console.Clear();         
                //Console.WriteLine("Skapa vara och lägg till det i stock!");
                Console.WriteLine("Skriv vilket ID det ska vara, namn, samt antalet i lager: ");
                StockItem stockItem = new StockItem()
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    StockCountInt = int.Parse(Console.ReadLine())
                };
                stock.AddItem(stockItem);

        }
        private static void CheckItems(out bool validInput, out int item, Stock stock)
        {
            Console.Clear();
            Console.WriteLine("Inventera varor: ");
            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] != null)
                {
                    Console.WriteLine(i.ToString() + " " + stock[i]);
                }
            }
            Console.WriteLine("Skriv ett nummer för att välja item: ");
            validInput = int.TryParse(Console.ReadLine(), out item);
            if (validInput)
            {
                Console.WriteLine("Skriv in ett nytt värde för lager: ");
                stock[item].StockCountInt = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Måste skriva en siffra!");
            }
        }

        private static void ListMyItems(Stock stock)
        {
            Console.Clear();
            Console.WriteLine("Alla varor: ");
            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] is EcoStockItem && stock[i] != null)
                {
                    Console.WriteLine(stock[i] + " + ECO produkt! <3");
                }
                else if (stock[i] != null)
                {
                    Console.WriteLine(stock[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
