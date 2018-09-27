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
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi+1, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi+2, State.Placed);
                Plocha.ShowPlocha();
                plocha.Pohyb();
            } while (1 > 0);
        }
    }
}



