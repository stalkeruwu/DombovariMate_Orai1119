using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai1119
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozo(string sor)
        {
            var split = sor.Split(";");
            Nev = split[0];
            Nem = split[1] == "férfi";
            Reszleg = split[2];
            Belepes = int.Parse(split[3]);
            Ber = int.Parse(split[4]);
        }
        override public string ToString()
        {
            return $"{Nev} {(Nem ? "férfi" : "nő")} {Reszleg} {Belepes} {Ber}";
        }

    }
}
