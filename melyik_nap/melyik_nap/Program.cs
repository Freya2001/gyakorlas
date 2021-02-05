using System;

namespace melyik_nap
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Adj egy számot 1-28 között");
                string számocska = Console.ReadLine();
                int szám;
                bool számít = int.TryParse(számocska, out szám);
                if (számít)
                {
                    if (szám % 7 == 1)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Hétfő.");
                    }
                    if (szám % 7 == 2)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Kedd.");
                    }
                    if (szám % 7 == 3)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Szerda.");
                    }
                    if (szám % 7 == 4)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Csütörtök.");
                    }
                    if (szám % 7 == 5)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Péntek.");
                    }
                    if (szám % 7 == 6)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Szombat.");
                    }
                    if (szám % 7 == 0)
                    {
                        Console.WriteLine("2021 februárjában " + szám + ". Vasárnap.");
                    }
                }
                else
                {
                    Console.WriteLine("Nem megfelelő adatot adott.");
                }
            }
        }
    }
}
