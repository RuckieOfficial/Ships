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
        public bool exit = false;

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
                            Console.Write("Q");
                            dalsipole = true;
                        }
                        if (ShipToPolicko.state == State.Missed) {
                            Console.Write(" ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("0");
                        }
                        if (ShipToPolicko.state == State.Hit) {
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
            }
            if (key.Key == ConsoleKey.Escape) {
                return 6;
            } else {
                return 5;
            }
        }
        public void Pohyb() {
            Plocha plocha = new Plocha();
            int sellection = GetKey();

            if (sellection == 1) {
                if (Xlodi >= 1) {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi - 1;
                } else {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 2) {
                if (Ylodi >= 1) {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi - 1;
                } else {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 3) {
                if (Ylodi <= 8) {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi + 1;
                } else {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 4) {
                if (Xlodi <= 6) {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi + 1;
                } else {
                    List<Policko> vytvorenepole = GeneratePlocha();
                    foreach (Policko vytvorenepolicko in vytvorenepole) {
                        foreach (Policko ShipToPolicko in ShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 5) {
                List<Policko> vytvorenepole = GeneratePlocha();
                foreach (Policko vytvorenepolicko in vytvorenepole) {
                    foreach (Policko ShipToPolicko in ShipToPolicko) {
                        if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                            if (ShipToPolicko.state == State.Placed) {
                                ShipToPolicko.state = State.Empty;
                            }
                        }
                    }
                }
            }
            if (sellection == 6) {
                exit = true;
                Console.Clear();
                Console.WriteLine("Ukončil jste hru!");
                Console.Write(" ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \n");
                Console.Write("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗ \n");
                Console.Write("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝ \n");
                Console.Write("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗ \n");
                Console.Write("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║ \n");
                Console.Write(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝ \n");
            }
        }
    }
}
