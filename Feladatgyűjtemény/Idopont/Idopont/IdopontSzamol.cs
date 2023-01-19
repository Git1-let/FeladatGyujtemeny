using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idopont
{
    public class IdopontSzamol
    {
        public string IdopontGeneral(string[] Tomb, int also, int felso)
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
    }
}
