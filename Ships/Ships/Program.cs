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
                Console.WriteLine("Welcome to Ships!\nMove: Arrows, Place: Enter, Exit: Esc");
                Console.WriteLine("Player1: ");

                if (plocha.Typylodi == 1) {
                    plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                }
                if (plocha.Typylodi == 2) {
                    plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                }
                if (plocha.Typylodi == 3) { 
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                }

                if (plocha.Typylodi == 4) {
                    plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi - 1, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 1, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 2, State.Placed);
                    plocha.ShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 3, State.Placed);
                }

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
                    Console.WriteLine("Welcome to Ships!\nMove: Arrows, Place: Enter, Exit: Esc");
                    Console.WriteLine("Player2: ");

                    if (plocha.Typylodi == 1) {
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                    }
                    if (plocha.Typylodi == 2) {
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                    }
                    if (plocha.Typylodi == 3) {
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 1, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                    }

                    if (plocha.Typylodi == 4) {
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi, plocha.Xlodi + 2, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi - 1, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 1, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 2, State.Placed);
                        plocha.EnemyShipToPolicka(plocha.Ylodi + 1, plocha.Xlodi + 3, State.Placed);
                    }

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
                        if (plocha.NextP == false) {
                            Console.Clear();
                            Console.WriteLine("Welcome to Ships!\nMove: Arrows, Place: Enter, Exit: Esc");
                            Console.WriteLine("Player1: ");
                            plocha.P1ToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                            Plocha.ShowP1plays();
                            Console.WriteLine("Player2: ");
                            Plocha.ShowEnemyPlocha();
                            plocha.P1Pohyb();
                        } else {
                            /*Console.Clear();
                            Console.WriteLine("Welcome to Ships!\nMove: Arrows, Place: Enter, Exit: Esc");
                            Console.WriteLine("Player2: ");
                            plocha.P2ToPolicka(plocha.Ylodi, plocha.Xlodi, State.Placed);
                            Plocha.ShowP2plays();
                            Console.WriteLine("Player1: ");
                            Plocha.ShowPlocha();
                            plocha.P2Pohyb();*/
                        }
                    } while (plocha.exit == false && plocha.P1Kills < 3375 && plocha.P2Kills < 3375);
                    /*if (plocha.P1Kills == 15) {
                        Console.WriteLine("Player 1 Wins!!! \nCongratulations!");
                    } else {
                        Console.WriteLine("Player 2 Wins!!! \nCongratulations!");
                    }*/
                }
            }
        }
    }
}



