using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ships {
    class Plocha {
        public static Plocha[,] plocha = new Plocha[10, 10];
        private static List<Policko> ShipToPolicko = new List<Policko>();
        private List<Ship> ships = new List<Ship>();

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

        public void ShipToPolicka(int x, int y, State state) {
            ShipToPolicko.Add(new Policko {
                X = x,
                Y = y,
                state = state
            });
        }

        public static void ShowPlocha() {
            List<Policko> vytvorenepole = GeneratePlocha();
            bool dalsipole = false;
            int index2 = 1;
            foreach (Policko vytvorenepolicko in vytvorenepole) {
                foreach (Policko ShipToPolicko in ShipToPolicko) {
                    if (vytvorenepolicko.X == ShipToPolicko.X && vytvorenepolicko.Y == ShipToPolicko.Y) {
                        if (ShipToPolicko.state == State.Placed) {
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("L");
                            dalsipole = true;
                        }
                        if (ShipToPolicko.state == State.Missed) {
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("X");
                        }
                    }
                }

                if (!dalsipole) {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    Console.Write("L");
                }
                dalsipole = false;

                if (index2 == plocha.GetLength(0)) {
                    Console.WriteLine();
                    index2 = 0;
                }
                index2++;
            }
        }
    }
}
