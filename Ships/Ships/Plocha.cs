using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Plocha {
        public static Plocha[,] plocha = new Plocha[10, 10];

        public static List<Policko> GeneratePlocha() {
            List<Policko> policka = new List<Policko>();
            for (int x = 0; x < plocha.GetLength(0); x++) {
                for (int y = 0; y < plocha.GetLength(1); y++) {
                    policka.Add(new Policko {
                        X = x,
                        Y = y,
                        state = State.Empty
                    });
                }
            }
            return policka;
        }

        public void ShowPlocha() {
            List<Policko> policka = GeneratePlocha();
            foreach (Policko policko in policka) {
                if (policko.X == 5 && policko.Y == 5 || policko.X == 5 && policko.Y == 6 || policko.X == 5 && policko.Y == 7) {
                    policko.state = State.Placed;
                }
            }
            int index = 0;
            foreach (Policko policko in policka) {
                if (policko.state == State.Empty) {
                    Console.Write(" L");
                    index++;
                }
                if (policko.state == State.Placed) {
                    Console.Write(" X");
                    index++;
                }
                if (index > plocha.GetLength(0)) {
                    Console.WriteLine();
                    index = 0;
                }

            }

        }
    }
}