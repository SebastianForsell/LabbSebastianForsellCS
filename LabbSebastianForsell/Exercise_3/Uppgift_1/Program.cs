using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1
            Person klasse = new Person();
            Person adam = new Person();
            Person bert = new Person();
            klasse.SetName("Klasse");
            adam.SetName("Adam");
            bert.SetName("Bert");
            Console.WriteLine(klasse.GetName());
            Console.WriteLine(adam.GetName());
            Console.WriteLine(bert.GetName());
            Console.ReadLine();

            //Uppgift 2
            Circle litenCirkel = new Circle();
            Circle mellanCirkel = new Circle();
            Circle storCirkel = new Circle();
            litenCirkel.SetDiameter(3.0);
            mellanCirkel.SetDiameter(5.0);
            storCirkel.SetDiameter(10.0);
            Console.WriteLine($"Den lilla cirkeln är {litenCirkel.GetDiameter()}cm i diametern och {litenCirkel.GetCircumference()}cm i omkrets");
            Console.WriteLine($"Den mellanstora cirkeln är {mellanCirkel.GetDiameter()}cm i diametern och {mellanCirkel.GetCircumference()}cm i omkrets");
            Console.WriteLine($"Den stora cirkeln är {storCirkel.GetDiameter()}cm i diametern och {storCirkel.GetCircumference()}cm i omkrets");
            Console.ReadLine();

            //Uppgift 4
            Point coordinate = new Point();
            coordinate.SetX(4);
            coordinate.SetY(2);
            Circle greatCircle = new Circle();
            greatCircle.SetDiameter(15);
            greatCircle.SetCentre(coordinate);
            Console.WriteLine($"X-axeln är {greatCircle.GetCentre().GetX()} och Y-axeln är {greatCircle.GetCentre().GetY()}.");
            Console.ReadLine();

            //Uppgift 5
            Table table = new Table();
            table.SetWidth(50);
            table.SetHeight(100);
            table.SetNumberOfLegs(3);
            table.SetColour("Mahogny");
            House house = new House();
            house.SetNumberOfDoors(2);
            house.SetNumberOfWindows(6);
            house.SetRoofColour("Hot pink");
            house.SetFacade("Marmor");
            house.SetTable(table);
            Console.WriteLine(house);
        }
    }
}
