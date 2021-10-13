using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisestage Kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage parool:");
                string userPassWord = Console.ReadLine();
                Console.WriteLine("Sisestage PIN-kood:");
                string userPIN = Console.ReadLine();
                int userPINLenght = userPIN.Length;

                if (userPINLenght > 4)
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }
                else if (userName == "user1" && userPassWord == "password1" && userPIN == "1532")
                {
                    Console.WriteLine("Tere Tulemast!");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Midagi läks valesti. Proovi uuesti.");
                }
            }


        }
    }
}
