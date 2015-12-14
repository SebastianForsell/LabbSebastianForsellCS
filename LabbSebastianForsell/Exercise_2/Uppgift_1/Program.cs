using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJones = 4.6;
            double nasdaq = 4.1;
            double stockholm = -2.4;
            double milano = -6.7;
            double paris = -5.5;
            //Console.WriteLine($"Dow Jones sjönk med {dowJones} procent och Nasdaq med {Nasdaq} procent.\n"
            //+"Stockholm {Stockholm} procent, Milano {Milano} procent, Paris {Paris} procent.\n");
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent.\n"
                + "Stockholm {2} procent, Milano {3} procent, Paris {4} procent.\n", dowJones, nasdaq, stockholm, milano, paris);

            const double PI = Math.PI;
            Console.WriteLine("Talet pi är cirka {0} men kan avrundas till {1 :F2} och kan lite grovt skrivas som {2 :F0}.\n", PI, PI, PI);

            //PI = 5; Går ej att ändra för att variabeln är deklarerad som en konstant!

            dowJones = -4.6;
            nasdaq = 12.8;
            stockholm = -9.2;
            milano = 1.7;
            paris = -42.4;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent.\n"
                + "Stockholm {2} procent, Milano {3} procent, Paris {4} procent.\n", dowJones, nasdaq, stockholm, milano, paris);

            string name = "Jonas";
            string city = "Helsingborg";
            string street = "Stattena";
            string streetDescription = "Hemköp";
            Console.WriteLine("Han heter {0} och bor i {1} på {2} vid {3}.\n", name, city, street, streetDescription);

            name = "Ivan";
            city = "Höganäs";
            street = "Oscarsgatan";
            streetDescription = "koloniområdet";
            Console.WriteLine("Han heter {0} och bor i {1} på {2} vid {3}.\n", name, city, street, streetDescription);
        }
    }
}
