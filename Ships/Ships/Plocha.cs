using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ships {
    class Plocha {
        public static Plocha[,] plocha = new Plocha[10, 10];
        private static List<Policko> ShipToPolicko = new List<Policko>();
        private static List<EnemyPolicko> EnemyShipToPolicko = new List<EnemyPolicko>();
        private static List<P1Policko> P1ToPolicko = new List<P1Policko>();
        private List<Ship> ships = new List<Ship>();
        public bool exit = false;
        public bool NextP = false;
        public int ShipsPlaced = 0;
        public int Xlodi = 3;
        public int Ylodi = 3;
        public int P1Kills = 0;
        public int P2Kills = 0;
        public bool Win = false;

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

        public static List<EnemyPolicko> GenerateEnemyPlocha() {
            List<EnemyPolicko> policka = new List<EnemyPolicko>();
            for (int x = 0; x < plocha.GetLength(0); x++) {
                for (int y = 0; y < plocha.GetLength(1); y++) {
                    policka.Add(new EnemyPolicko {
                        X = x,
                        Y = y,
                        enemystate = State.Empty
                    });
                }
            }
            return policka;
        }

        public static List<P1Policko> GenerateP1Plocha() {
            List<P1Policko> policka = new List<P1Policko>();
            for (int x = 0; x < plocha.GetLength(0); x++) {
                for (int y = 0; y < plocha.GetLength(1); y++) {
                    policka.Add(new P1Policko {
                        X = x,
                        Y = y,
                        p1state = State.Empty
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

        public void EnemyShipToPolicka(int x, int y, State enemystate) {
            EnemyShipToPolicko.Add(new EnemyPolicko {
                X = x,
                Y = y,
                enemystate = enemystate
            });
        }

        public void P1ToPolicka(int x, int y, State p1state) {
            P1ToPolicko.Add(new P1Policko {
                X = x,
                Y = y,
                p1state = p1state
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
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("Q");
                                dalsipole = true;
                            }
                        }
                        if (ShipToPolicko.state == State.PlacedbyShip) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.Write("Q");
                                dalsipole = true;
                            }

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

        public static void ShowEnemyPlocha() {
            List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
            bool dalsipole = false;
            int index2 = 1;
            foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                    if (vytvorenepolicko.X == EnemyShipToPolicko.X && vytvorenepolicko.Y == EnemyShipToPolicko.Y) {
                        if (EnemyShipToPolicko.enemystate == State.Placed) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("Q");
                                dalsipole = true;
                            }
                        }
                        if (EnemyShipToPolicko.enemystate == State.PlacedbyShip) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.Write("Q");
                                dalsipole = true;
                            }

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

        public static void ShowP1plays() {
            List<P1Policko> vytvorenepole = GenerateP1Plocha();
            bool dalsipole = false;
            int index3 = 1;
            foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                    if (vytvorenepolicko.X == P1ToPolicko.X && vytvorenepolicko.Y == P1ToPolicko.Y) {
                        if (P1ToPolicko.p1state == State.Placed) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Write("O");
                                dalsipole = true;
                            }
                        }
                        if (P1ToPolicko.p1state == State.Missed) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("0");
                                dalsipole = true;
                            }
                        }
                        if (P1ToPolicko.p1state == State.Hit) {
                            if (!dalsipole) {
                                Console.Write(" ");
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("X");
                                dalsipole = true;
                            }
                        }
                    }
                }

                if (!dalsipole) {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    Console.Write("L");
                }
                dalsipole = false;

                if (index3 == plocha.GetLength(0)) {
                    Console.WriteLine();
                    index3 = 0;
                }
                index3++;
            }
        }

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
            }
            if (key.Key == ConsoleKey.Enter) {
                return 7;
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
                Console.WriteLine("Exiting game...");
                Console.Write(" ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \n");
                Console.Write("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗ \n");
                Console.Write("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝ \n");
                Console.Write("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗ \n");
                Console.Write("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║ \n");
                Console.Write(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝ \n");
            }
            if (sellection == 7) {
                List<Policko> vytvorenepole = GeneratePlocha();
                foreach (Policko vytvorenepolicko in vytvorenepole) {
                    foreach (Policko ShipToPolicko in ShipToPolicko) {
                        if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                            if (ShipToPolicko.state != State.PlacedbyShip) {
                                if (ShipToPolicko.state == State.Placed) {
                                    ShipToPolicko.state = State.PlacedbyShip;
                                    ShipsPlaced++;
                                    if (ShipsPlaced == 15) {
                                        NextP = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int GetEnemyKey() {
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
            }
            if (key.Key == ConsoleKey.Enter) {
                return 7;
            } else {
                return 5;
            }
        }
        public void EnemyPohyb() {
            Plocha plocha = new Plocha();
            int sellection = GetEnemyKey();

            if (sellection == 1) {
                if (Xlodi >= 1) {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi - 1;
                } else {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 2) {
                if (Ylodi >= 1) {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi - 1;
                } else {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 3) {
                if (Ylodi <= 8) {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi + 1;
                } else {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 4) {
                if (Xlodi <= 6) {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi + 1;
                } else {
                    List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                    foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                        foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 5) {
                List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                    foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                        if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                            if (EnemyShipToPolicko.enemystate == State.Placed) {
                                EnemyShipToPolicko.enemystate = State.Empty;
                            }
                        }
                    }
                }
            }
            if (sellection == 6) {
                exit = true;
                Console.Clear();
                Console.WriteLine("Exiting game...");
                Console.Write(" ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \n");
                Console.Write("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗ \n");
                Console.Write("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝ \n");
                Console.Write("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗ \n");
                Console.Write("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║ \n");
                Console.Write(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝ \n");
            }
            if (sellection == 7) {
                List<EnemyPolicko> vytvorenepole = GenerateEnemyPlocha();
                foreach (EnemyPolicko vytvorenepolicko in vytvorenepole) {
                    foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                        if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                            if (EnemyShipToPolicko.enemystate != State.PlacedbyShip) {
                                if (EnemyShipToPolicko.enemystate == State.Placed) {
                                    EnemyShipToPolicko.enemystate = State.PlacedbyShip;
                                    ShipsPlaced--;
                                    if (ShipsPlaced == 0) {
                                        NextP = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public int GetP1Key() {
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
            }
            if (key.Key == ConsoleKey.Enter) {
                return 7;
            } else {
                return 5;
            }
        }
        public void P1Pohyb() {
            Plocha plocha = new Plocha();
            int sellection = GetP1Key();

            if (sellection == 1) {
                if (Xlodi >= 1) {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi - 1;
                } else {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 2) {
                if (Ylodi >= 1) {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi - 1;
                } else {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 3) {
                if (Ylodi <= 8) {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                    Ylodi = Ylodi + 1;
                } else {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 4) {
                if (Xlodi <= 8) {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                    Xlodi = Xlodi + 1;
                } else {
                    List<P1Policko> vytvorenepole = GenerateP1Plocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                        foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                            if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                if (P1ToPolicko.p1state == State.Placed) {
                                    P1ToPolicko.p1state = State.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (sellection == 5) {
                List<P1Policko> vytvorenepole = GenerateP1Plocha();
                foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                    foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                        if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                            if (P1ToPolicko.p1state == State.Placed) {
                                P1ToPolicko.p1state = State.Empty;
                            }
                        }
                    }
                }
            }
            if (sellection == 6) {
                exit = true;
                Console.Clear();
                Console.WriteLine("Exiting game...");
                Console.Write(" ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \n");
                Console.Write("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗ \n");
                Console.Write("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝ \n");
                Console.Write("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗ \n");
                Console.Write("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║ \n");
                Console.Write(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝ \n");
            }
            if (sellection == 7) {
                List<P1Policko> vytvorenepole = GenerateP1Plocha();
                List<EnemyPolicko> vytvorenepolenew = GenerateEnemyPlocha();
                    foreach (P1Policko vytvorenepolicko in vytvorenepole) {
                    foreach (P1Policko P1ToPolicko in P1ToPolicko) {
                        foreach (EnemyPolicko vytvorenepolickonew in vytvorenepolenew) {
                            foreach (EnemyPolicko EnemyShipToPolicko in EnemyShipToPolicko) {
                                if (vytvorenepolicko.X == Xlodi && vytvorenepolicko.Y == Ylodi) {
                                        if (vytvorenepolickonew.X == Xlodi && vytvorenepolickonew.Y == Ylodi) {
                                            if (EnemyShipToPolicko.enemystate == State.Empty) {
                                            P1ToPolicko.p1state = State.Missed;
                                            }
                                            if (EnemyShipToPolicko.enemystate == State.PlacedbyShip) {
                                                P1ToPolicko.p1state = State.Hit;
                                            P1Kills = P1Kills + 1;
                                            }
                                        }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
