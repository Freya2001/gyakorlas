using System;

namespace Ugyfelszolgalat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Adj egy számot, b+!");
                string input = Console.ReadLine();
                int inputSzam;
                bool sikerultKonvertalni = int.TryParse(input, out inputSzam);
                if (sikerultKonvertalni)
                {
                    if (inputSzam % 2 != 0)
                    {
                        Console.WriteLine("A(z) " + inputSzam + " páratlan.");
                    }
                    else
                    {
                        Console.WriteLine("A(z) " + inputSzam + " páros.");
                    }
                }
                else
                {
                    Console.WriteLine("Hülye vagy b+!");
                }
            }
            // for ciklus legközelebb
        }
    }
}