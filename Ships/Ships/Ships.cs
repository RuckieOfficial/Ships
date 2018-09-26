using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Ship {
        public int Xlodi = 3;
        public int Ylodi = 3;

        public int GetKey() {
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.LeftArrow) {
                return 1;
            }
            if (key.Key == ConsoleKey.UpArrow) {
                return 2;
            }
            if (key.Key == ConsoleKey.DownArrow) {
                return 3;
            }
            if (key.Key == ConsoleKey.RightArrow) {
                return 4;
            } else {
                return 5;
            }
        }
        public void Pohyb() {
            Plocha plocha = new Plocha();
            int sellection = GetKey();

            if (sellection == 1) {
                Ylodi = Ylodi - 2;
            }
            if (sellection == 2) {
                Xlodi = Xlodi - 1;
            }
            if (sellection == 3) {
                Xlodi = Xlodi + 1;
            }
            if (sellection == 1) {
                Ylodi = Ylodi + 1;
            }
            if (sellection == 5) {
                Console.WriteLine("Use only arrows!");
            }
        }

        public ShipType Ships { get; set; }
        public ShipState State { get; set; }
    }

    enum ShipType {
        Submarine,
        Destroyer,
        Cruiser,
    }

    enum ShipState {
        Flow,
        Hit,
        Destroyed,
    }
}
