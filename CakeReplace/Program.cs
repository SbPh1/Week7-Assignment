using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string thecakeislie = "The c4ke i3 l1e.";

            thecakeislie = thecakeislie.Replace('4', 'a');
            thecakeislie = thecakeislie.Replace('1', 'i');
            thecakeislie = thecakeislie.Replace('3', 's');

            Console.WriteLine(thecakeislie);
        }
    }
}
