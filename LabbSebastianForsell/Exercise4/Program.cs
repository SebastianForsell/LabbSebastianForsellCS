using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1
            Bil kupe = new Bil("Honda", 4, "Grön", "kupe");
            Bil suv = new Bil("Audi", 6, "Black", "suv");
            Console.WriteLine(kupe);
            Console.WriteLine(suv); //typen blir null eftersom suv är inte en kombi eller kupe
            Console.ReadLine();

            //Uppgift 2
            Radio radio = new Radio();
            radio.Volume = 34;
            radio.Frequency = 95.43;
            Console.WriteLine(radio);
            Console.ReadLine();

            // Uppgift 3
            Radio myNewRadio = new Radio(20, 54.68);
            Console.WriteLine($"Din radio är för tillfället avstängd med en volym på {myNewRadio.Volume} och en frekvens på {myNewRadio.Frequency}");
        }
    }
}
