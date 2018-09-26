using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Program {
        static void Main(string[] args) {
            Plocha plocha = new Plocha();
            Ship lode = new Ship();
            do {
                Console.Clear();
                Console.WriteLine("Welcome to Ships!");
                plocha.ShipToPolicka(lode.Xlodi, lode.Ylodi, State.Placed);
                plocha.ShipToPolicka(lode.Xlodi, lode.Ylodi+1, State.Placed);
                plocha.ShipToPolicka(lode.Xlodi, lode.Ylodi+2, State.Placed);
                Plocha.ShowPlocha();
                lode.Pohyb();
            } while (1 > 0);
        }
    }
}



