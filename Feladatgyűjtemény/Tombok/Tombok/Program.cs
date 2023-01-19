using System;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = TombFeltolt(6);
            Array.Sort(array);
            Array.Reverse(array);
            Array.Clear(array, 2, 3);
            TombKiir(array);
            int @int = Array.IndexOf(array, 54);
            Console.WriteLine(@int);

            int[,] TobbTomb = new int[3, 3];

            Console.ReadKey(true);
        }
        static int[] TombFeltolt(int elemSzam)
        {
            int[] array = new int[elemSzam];
            Random r = new Random();
            for (int q = 0; q < array.GetLength(0); q++)
            {
                int szam = r.Next(10, 90);
                bool @bool = false;
                for (int p = 0; p < q; p++)
                {
                    if (array[q] == szam)
                    {
                        @bool = true;
                        q--;
                        break;
                    }
                }
                if (!@bool)
                {
                    array[q] = szam;
                }
            }
            return array;
        }
        static void TombKiir(int[] array)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Console.WriteLine(array[k]);
            }
        }
        static int[,] TobbTombFeltolt(int szel, int magas)
        {
            int[,] arrayT = new int[szel, magas];
            Random r = new Random();
            for (int v = 0; v < arrayT.GetLength(0); v++)
            {
                for (int x = 0; x < arrayT.GetLength(1); x++)
                {
                    arrayT[v, x] = r.Next(10, 70);
                }
            }
            return arrayT;
        }
        static void TobbtombKiir(int[,] tomb)
        {
            Random rnd = new Random();

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
