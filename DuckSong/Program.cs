using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                if (i > 2)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day,Over the hill and far away.  Mother duck said quack quack quack quack, but only {i - 1} little ducks came back.");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day,Over the hill and far away.  Mother duck said quack quack quack quack, but only {i - 1} little duck came back.");

                }
                else
                {
                    Console.WriteLine($" 1 little duck went swimming one day over the hill and far away,  The sad mother duck said quack quack quack quack ,but no little duck came back .");
                }

            }
            Console.WriteLine("Sad mother duck went out one day, over the hill and far away. The sad mother duck said, Quack quack quack quack ,and all the 5 little ducks came back.");

        }
    }
}

        
    

