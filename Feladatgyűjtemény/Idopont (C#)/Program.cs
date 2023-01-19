using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idopont;

namespace _2023_01_11_12A
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat - Pozitív egész szám bekérése
            Console.Write("Kérek egy pozitív egész számot > ");
            int EgeszSzam = int.Parse(Console.ReadLine());
            if (EgeszSzam % 4 == 0)
            {
                Console.WriteLine("A maradék 0."); //Szám = a * 4 + 0
            }
            else if (EgeszSzam % 4 == 1)
            {
                Console.WriteLine("A maradék 1."); //Szám = a * 4 + 1
            }
            else if (EgeszSzam % 4 == 2)
            {
                Console.WriteLine("A maradék 2."); //Szám = a * 4 + 2
            }
            else
            {
                Console.WriteLine("A maradék 3."); //Szám = a * 4 + 3
            }

            //2. Feladat - Háromjegyű számok kiíratása, melyek számjegyeinek összege 10.
            /*
            for (int i = 100; i < 1000; i++)
            {
                int Szazas = i / 100; // 258 / 100 = 2,58 => 2
                int Adat = i - Szazas * 100; // 258 - 2 * 100 = 58
                int Tizes = Adat / 10; // 58 / 10 = 5,8 => 5
                int Egyes = Adat - Tizes * 10; // 58 - 5 * 10 = 8
                int Osszeg = Szazas + Tizes + Egyes;

                if (Osszeg % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //3. Feladat - Tízjegyű szám bekérése és annak kiíratása fordított sorrendben
            Console.Write("\nKérek egy tízjegyű számot > ");
            string Ertek = Console.ReadLine();
            
            char[] Tomb = Ertek.ToCharArray();
            Array.Reverse(Tomb);

            string UjErtek = new String(Tomb);
            Console.WriteLine($"Fordítva > {UjErtek}");

            //4. Feladat - Véletlen időpont létrehozása tömb segítségével, majd ebből generálunk óra, perc, másodperc értéket (02:48:35).
            string[] SzamTomb = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            
            Idopont.IdopontSzamol ISZ = new IdopontSzamol();


            string Ora = Idopont.IdopontSzamol.IdopontGeneral(SzamTomb, 0, 23);
            string Perc = Idopont.IdopontSzamol.IdopontGeneral(SzamTomb, 00, 59);
            string MasodPerc = Idopont.IdopontSzamol.IdopontGeneral(SzamTomb, 00, 59);
            Console.WriteLine($"\n{Ora}:{Perc}:{MasodPerc}");

            Console.ReadKey(true);
        }

        /*
        public static string IdopontGeneral(string[] Tomb, int also, int felso)
        {
            Random r = new Random();
            string Idopont = "-1";
            while (int.Parse(Idopont) < also || int.Parse(Idopont) > felso)
            {
                Idopont = "";
                Idopont += Tomb[r.Next(9)];
                Idopont += Tomb[r.Next(9)];
            }

            return Idopont;
        }
        */
    }
}
