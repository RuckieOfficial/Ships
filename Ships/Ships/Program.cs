using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Program {
        static void Main(string[] args) {
            Plocha plocha = new Plocha();
            Console.WriteLine("Welcome to Ships!");
            plocha.ShipToPolicka(3, 5, State.Placed);
            plocha.ShipToPolicka(3, 6, State.Placed);
            plocha.ShipToPolicka(3, 7, State.Placed);
            Plocha.ShowPlocha();
        }
    }
}



