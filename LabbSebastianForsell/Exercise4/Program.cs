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
            Uppgift1();

            Uppgift2();

            Uppgift3();

            Uppgift5();

            Uppgift6();
        }        

        private static void Uppgift1()
        {
            Bil kupe = new Bil("Honda", 4, "Grön", "kupe");
            Bil suv = new Bil("Audi", 6, "Black", "suv");
            Console.WriteLine(kupe);
            Console.WriteLine(suv); //typen blir null eftersom suv är inte en kombi eller kupe
            Console.ReadLine();
        }

        private static void Uppgift2()
        {
            Radio radio = new Radio();
            radio.Volume = 34;
            radio.Frequency = 95.43;
            Console.WriteLine(radio);
            Console.ReadLine();
        }

        private static void Uppgift3()
        {
            Radio myNewRadio = new Radio(20, 54.68);
            Console.WriteLine($"Din radio är för tillfället avstängd med en volym på {myNewRadio.Volume} och en frekvens på {myNewRadio.Frequency}");
            Console.ReadLine();
        }

        private static void Uppgift5()
        {
            Radio radioFM = new Radio() {Volume = 25, Frequency = 45.36};
            Radio radioKristianstad = new Radio() {Volume = 42, Frequency = 36.83};
            Radio radioP3 = new Radio() {Volume = 14, Frequency = 95.89};
            Radio radioP4 = new Radio() {Volume = 28, Frequency = 76.27};
            Radio radioP1 = new Radio() {Volume = 42, Frequency = 66.66};
        }

        private static void Uppgift6()
        {
            Lastbil smallLorry = new Lastbil() { NumberOfGears = 8, NumberOfWheels = 6 };
            Console.WriteLine(smallLorry);
            Console.WriteLine($"tuta: ...{smallLorry.HornSound}");
            Console.Beep(smallLorry.HornFrequency, smallLorry.HornSpeed);
            Console.Beep(smallLorry.HornFrequency, smallLorry.HornSpeed);
            Console.ReadLine();
            Lastbil mediumLorry = new Lastbil() { NumberOfGears = 11, NumberOfWheels = 8, CargoType = "Mat", HornFrequency = 600, HornSound = "Vrum Vrum"};
            Console.WriteLine(mediumLorry);
            Console.WriteLine($"tuta: ...{mediumLorry.HornSound}");
            Console.Beep(mediumLorry.HornFrequency, mediumLorry.HornSpeed);
            Console.Beep(mediumLorry.HornFrequency, mediumLorry.HornSpeed);
            Console.ReadLine();
            Lastbil bigLorry = new Lastbil() { NumberOfGears = 12, NumberOfWheels = 11, CargoType = "Flyktingar", HornFrequency = 350,
                                               HornSpeed = 1000, HornSound = "VRROOOOM VROOOOM" };
            Console.WriteLine(bigLorry);
            Console.WriteLine($"tuta: ... {bigLorry.HornSound}");
            Console.Beep(bigLorry.HornFrequency, bigLorry.HornSpeed);
            Console.Beep(bigLorry.HornFrequency, bigLorry.HornSpeed);
            Console.WriteLine($"antal instanser: {Lastbil.InstanceCounter}");
            Console.ReadLine();
        }
    }
}
