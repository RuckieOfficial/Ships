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
                Console.WriteLine("Welcome to Ships!\nMove: Arrows, Rotate: R, Place: Enter, Exit: Esc");
                Console.WriteLine("Player1: ");
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                Plocha.ShowPlocha();
                Console.WriteLine("Player2: ");
                Plocha.ShowEnemyPlocha();
                plocha.Pohyb();
            } while (plocha.exit == false && plocha.NextP == false);
            if (plocha.exit == true) {

            } else {
                plocha.Xlodi = 3;
                plocha.Ylodi = 3;
                do {
                    Console.Clear();
                    Console.WriteLine("Welcome to Ships!\nMove: Arrows, Rotate: R, Place: Enter, Exit: Esc");
                    Console.WriteLine("Player2: ");
                    plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                    plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                    plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                    Plocha.ShowEnemyPlocha();
                    Console.WriteLine();
                    Console.WriteLine("Player1: ");
                    Plocha.ShowPlocha();
                    plocha.EnemyPohyb();
                } while (plocha.exit == false && plocha.NextP == true);
                if (plocha.exit == true) {

                } else {
                    plocha.Xlodi = 3;
                    plocha.Ylodi = 3;
                    do {
                        Console.Clear();
                        Console.WriteLine("Welcome to Ships!\nMove: Arrows, Rotate: R, Place: Enter, Exit: Esc");
                        Console.WriteLine("Player1: ");
                        Plocha.ShowPlocha();
                        Console.WriteLine("Player2: ");
                        Plocha.ShowEnemyPlocha();
                        plocha.EnemyPohyb();
                    } while (plocha.exit == false && plocha.NextP == false);
                }
            }
        }
    }
}



