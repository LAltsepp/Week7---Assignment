using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                string userName;
                string Password;
                Console.WriteLine("Sisesta PIN");
                string PIN = Console.ReadLine();
                Console.WriteLine("Sisesta kasutajatunnus");
                userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool");
                Password = Console.ReadLine();

                if (PIN == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else if ((userName == "user1") && (Password == "password1") && (PIN == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((userName != "user1") && (Password == "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti");
                }
                else if ((userName == "user1") && (Password != "password1"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Proovi uuesti {3 - i} katset on jäänud");
                }

            }
            
            
        }
    }
}
