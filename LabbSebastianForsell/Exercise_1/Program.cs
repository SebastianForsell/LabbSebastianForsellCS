using System;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            string name = "Bob";
            Console.WriteLine("Hi there!");
            Console.WriteLine("{0} is not at home right now, there is a {1 :p3} he will be back in a week. ", name, 0.42666);
            Console.WriteLine("this a random number: {0 :N9}.", 2136223.14235864552434864);
            Console.ReadLine();
        }
    }
}
