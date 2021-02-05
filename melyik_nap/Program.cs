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
                if (számít && 1<= szám && szám < 29)
                {
                    switch (szám % 7)
                    {
                        case 1:
                            Console.WriteLine("2021 februárjában " + szám + ". Hétfő.");
                            break;
                        case 2:
                            Console.WriteLine("2021 februárjában " + szám + ". Kedd.");
                            break;
                        case 3:
                            Console.WriteLine("2021 februárjában " + szám + ". Szerda.");
                            break;
                        case 4:
                            Console.WriteLine("2021 februárjában " + szám + ". Csütörtök.");
                            break;
                        case 5:
                            Console.WriteLine("2021 februárjában " + szám + ". Péntek.");
                            break;
                        case 6:
                            Console.WriteLine("2021 februárjában " + szám + ". Szombat.");
                            break;
                        default:
                            Console.WriteLine("2021 februárjában " + szám + ". Vasárnap.");
                            break;
                    }
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("Ügyes vagy :)");
                    }
                    //if (szám % 7 == 1)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Hétfő.");
                    //}
                    //else if (szám % 7 == 2)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Kedd.");
                    //}
                    //else if (szám % 7 == 3)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Szerda.");
                    //}
                    //else if (szám % 7 == 4)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Csütörtök.");
                    //}
                    //else if (szám % 7 == 5)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Péntek.");
                    //}
                    //else if (szám % 7 == 6)
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Szombat.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("2021 februárjában " + szám + ". Vasárnap.");
                    //}

                }
                else
                {
                    Console.WriteLine("Nem megfelelő adatot adott.");
                }
                //int alma = 0;
                //while (alma <100)
                //{
                //    Console.WriteLine("Ügyes vagy :)");
                //    alma++; // == alma += 1; == alma = alma + 1; == ++alma
                //}
            }
        }
    }
}
