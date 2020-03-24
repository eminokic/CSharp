using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello traveler, what is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
