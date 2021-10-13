using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.");
        }
    }
}
