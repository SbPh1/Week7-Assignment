using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;

            if (firstNameLenght > 5)
            {
                for (int i = firstNameLenght - 1; i >= 0; i--)
                {
                    Console.WriteLine(firstName[i]);
                }
            }
            else
            {
                Console.WriteLine($"{firstName}");
            }
        }
    }
}
