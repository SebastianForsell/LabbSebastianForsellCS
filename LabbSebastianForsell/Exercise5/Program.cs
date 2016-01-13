using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    enum StockMenu { Skapa_vara = 1, Inventera_vara, Lista_varor, Avsluta}
    class Program
    {
        static void Main(string[] args)
        {
            StockItem stockItem = new StockItem();
            Stock stock = new Stock();
            bool loops = true;
            do
            {
                Console.Clear();
                byte counter = 1;
                foreach (var item in Enum.GetNames(typeof(StockMenu)))
                {
                    Console.WriteLine($"{counter++}: {item}");
                }
                byte inNumber;
                if (byte.TryParse(Console.ReadLine(), out inNumber))
                {
                    StockMenu choice = (StockMenu)inNumber;
                    switch (choice)
                    {
                        case StockMenu.Skapa_vara:
                            Console.Clear();
                            Console.WriteLine("Vad ska varan ha för ID? ");
                            stockItem.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vad ska varan heta? ");
                            stockItem.Name = Console.ReadLine();
                            Console.WriteLine("Hur många varor av denna varan vill ni ha: ");
                            stockItem.StockCountInt = int.Parse(Console.ReadLine());
                            stock.AddItem(stockItem);

                            break;
                        case StockMenu.Inventera_vara:
                            Console.Clear();
                            Console.WriteLine("Ange ID nummer för vara: ");
                            StockItem stockCheck = stock.GetItem(int.Parse(Console.ReadLine()));
                            Console.WriteLine($"Name: {stockItem.Name}, Antal: {stockItem.StockCountInt}");
                            Console.WriteLine("Vad ska det nya antalet vara?: ");
                            stockItem.StockCountInt = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Uppdaterade varan: Name: {stockItem.Name}, Antal: {stockItem.StockCountInt}");
                            Console.ReadLine();
                            
                            break;
                        case StockMenu.Lista_varor:
                            Console.Clear();
                            
                            Console.WriteLine("Alla varor: ");
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
    }
}
