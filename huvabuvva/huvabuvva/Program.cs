using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huvabuvva
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat() { Name = "Kajsa", Age = 42};
            //cat.PrintInfo();
            Console.WriteLine(cat);
            Animal dog = new Dog() { Name = "Dogge", Age = 666};
            //dog.PrintInfo();
            Console.WriteLine(dog);
            //Vehicle vehicle = new Car();
            Console.ReadLine();
            
            //Cykel cykel = new Cykel();
            //Fordon fordon = (Fordon)cykel;
            //Bil bil = new Bil();
            //Fordon[] fordonare = new Fordon[3] { cykel, fordon, bil};
            //foreach (var item in fordonare)
            //{
            //    item.print();
            //}
            //fordonare[0] = cykel;
            //fordonare[1] = fordon;
            //fordonare[2] = bil;
            //cykel.print();
            //fordon.print();
            Console.ReadLine();
        }
    }
}
