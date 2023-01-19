using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JelszoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jelszo.txt állományba 50 darab 20 karakter hosszússágú jelszó legenerálása és kiíraiása

            char @char;
            string[] @string = new string[50];
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                string password = "";
                char[] array = new char[20];
                for (int q = 0; q < 20; q++)
                {
                    int veletlen = random.Next(33, 126);
                    @char = (char)veletlen;
                    array[q] = @char;
                }

                password = new string(array);
                Console.WriteLine(password);
                @string[i] = password;
            }


            using (StreamWriter sw = new StreamWriter ("Password.txt", false, Encoding.ASCII))
            {
                for (int i = 0; i < 50; i++)
                {
                    sw.WriteLine(@string[i]);
                }
            }

            Console.Write("\nKérem a felhasználónevet >> ");
            string felhasznalo = Console.ReadLine();
            Console.Write("Kérem a jelszót >> ");
            string jelszo = Console.ReadLine();

            List<int> DB = new List<int>();
            for (int i = 0; i < jelszo.Length; i++)
            {
                int szam = jelszo[i];
                DB.Add(szam);
            }

            using(StreamWriter sw = new StreamWriter("Password2.txt", false, Encoding.ASCII))
            {
                string kiir = $"{felhasznalo} - ";
                for (int i = 0; i < DB.Count; i++)
                {
                    kiir += DB[i];
                }
                sw.Write(kiir);
            }

            using (StreamReader sr = new StreamReader("Password2.txt"))
            {
                string sor = "";
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                }
                Console.WriteLine($"\n{sor}");
            }

            if (felhasznalo != jelszo)
            {
                Console.WriteLine("\nNem megfelelő felhasználó vagy jelszó!");
            }
            else
            {
                Console.WriteLine("Sikeres belépés!");
            }

            Console.ReadKey(true);
        }
    }
}
