using System;
using System.Collections.Generic;
using System.Threading;

namespace F1_Brazil_GP_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamList = new List<string> { "Mercedes", "Red Bull", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas" };
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("F1 Brazilian GP Test Game");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWhat's Your First Name?");
            string userFirstName = Console.ReadLine();
            if (userFirstName.Length == 1)
            {
                userFirstName += ".";
            }
            else if (userFirstName.Length == 0)
            {
                userFirstName = "john";
            }
            userFirstName = userFirstName.Remove(1).ToUpper() + userFirstName.Remove(0, 1).ToLower();
            Console.WriteLine("And Your Last Name?");
            string userLastName = Console.ReadLine();
            if (userLastName.Length == 1)
            {
                userLastName += ".";
            }
            else if (userLastName.Length == 0)
            {
                userLastName = "doe";
            }
            userLastName = userLastName.Remove(1).ToUpper() + userLastName.Remove(0, 1).ToLower();
            bool teamChosen;
            //teams
            var racerList = new List<string> { "Charles Leclerc", "Max Verstappen", "Carlos Sainz", "Sergio Perez", "Lewis Hamilton", "George Russell", "Fernando Alonso", "Lando Norris", "Esteban Ocon", "Valtteri Bottas", "Daniel Ricciardo", "Pierre Gasly", "Kevin Magnussen", "Nyck De Vries", "Yuki Tsunoda", "Mick Schumacher", "Zhou Guanyu", "Sebastian Vettel", "Alexander Albon", "Lance Stroll" };
            do
            {
                teamChosen = true;
                int writeTeams = 0;
                Console.WriteLine($"For which team do you wish to play {userFirstName} {userLastName}?");
                foreach (string item in teamList)
                {
                    Console.WriteLine(writeTeams + 1 + " - " + teamList[writeTeams]);
                    writeTeams++;
                }
                string userTeam = Console.ReadLine().ToLower();
                Console.Clear();
                switch (userTeam)
                {
                    case "1":
                    case "mercedes":
                    case "mersedes":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;     
                        userTeam = teamList[0];
                        Console.WriteLine(userTeam);
                        break;

                    case "2":
                    case "red":
                    case "bull":
                    case "redbull":
                    case "red bull":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        userTeam = teamList[1];
                        Console.WriteLine(userTeam);
                        break;

                    case "3":
                    case "ferari":
                    case "ferrari":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        userTeam = teamList[2];
                        Console.WriteLine(userTeam);
                        break;

                    case "4":
                    case "mcl":
                    case "mclaren":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        userTeam = teamList[3];
                        Console.WriteLine(userTeam);
                        break;

                    case "5":
                    case "alpine":
                    case "alpin":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        userTeam = teamList[4];
                        Console.WriteLine(userTeam);
                        break;

                    case "6":
                    case "alphatauri":
                    case "alpha tauri":
                    case "tauri":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        userTeam = teamList[5];
                        Console.WriteLine(userTeam);
                        break;

                    case "7":
                    case "aston martin":
                    case "astonmartin":
                    case "aston":
                    case "martin":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        userTeam = teamList[6];
                        Console.WriteLine(userTeam);
                        break;

                    case "8":
                    case "willliams":
                    case "wiliams":
                    case "wil":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        userTeam = teamList[7];
                        Console.WriteLine(userTeam);
                        break;

                    case "9":
                    case "alfa romeo":
                    case "alfaromeo":
                    case "alfa":
                    case "romeo":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        userTeam = teamList[8];
                        Console.WriteLine(userTeam);
                        break;

                    case "10":
                    case "haas":

                        Console.Write("You are racing for ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        userTeam = teamList[9];
                        Console.WriteLine(userTeam);
                        break; 

                    default:

                        Console.WriteLine($"There's no such team as {userTeam}, try again");
                        teamChosen = false;
                        break;
                }
            } while (teamChosen == false);
            int minute = 30;
            //preRace
            string pole;
            string pos2;
            string pos3;
            string pos4;
            string pos5;
            string pos6;
            string pos7;
            string pos8;
            string pos9;
            string pos10;
            string pos11;
            string pos12;
            string pos13;
            string pos14;
            string pos15;
            string pos16;
            string pos17;
            string pos18;
            string pos19;
            string pos20;
            Random rnd = new Random();
            int startRnd = rnd.Next(24);
            if (startRnd - 18 < 0)
            {
                if (startRnd > 9)
                { pole = racerList[1]; }
                else
                { pole = racerList[0]; }
            }
            else
            { pole = racerList[startRnd - 18]; }

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 18 < 0)
                { pos2 = racerList[1]; }
                else
                { pos2 = racerList[startRnd - 18]; }
            } while (pole == pos2);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 16 < 0)
                { pos3 = racerList[2]; }
                else
                { pos3 = racerList[startRnd - 16]; }
            } while (pole == pos3 || pos2 == pos3);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 15 < 0)
                { pos4 = racerList[3]; }
                else
                { pos4 = racerList[startRnd - 15]; }
            } while (pole == pos4 || pos2 == pos4 || pos3 == pos4);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 14 < 0)
                { pos5 = racerList[4]; }
                else
                { pos5 = racerList[startRnd - 14]; }
            } while (pole == pos5 || pos2 == pos5 || pos3 == pos5 || pos4 == pos5);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 13 < 0)
                { pos6 = racerList[5]; }
                else
                { pos6 = racerList[startRnd - 13]; }
            } while (pole == pos6 || pos2 == pos6 || pos3 == pos6 || pos4 == pos6 || pos5 == pos6);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 12 < 0)
                { pos7 = racerList[6]; }
                else
                { pos7 = racerList[startRnd - 12]; }
            } while (pole == pos7 || pos2 == pos7 || pos3 == pos7 || pos4 == pos7 || pos5 == pos7 || pos6 == pos7);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 12 < 0)
                { pos8 = racerList[7]; }
                else
                { pos8 = racerList[startRnd - 12]; }
            } while (pole == pos8 || pos2 == pos8 || pos3 == pos8 || pos4 == pos8 || pos5 == pos8 || pos6 == pos8 || pos7 == pos8);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 9 < 0)
                { pos9 = racerList[8]; }
                else
                { pos9 = racerList[startRnd - 9]; }
            } while (pole == pos9 || pos2 == pos9 || pos3 == pos9 || pos4 == pos9 || pos5 == pos9 || pos6 == pos9 || pos7 == pos9 || pos8 == pos9);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 9 < 0)
                { pos10 = racerList[9]; }
                else
                { pos10 = racerList[startRnd - 9]; }
            } while (pole == pos10 || pos2 == pos10 || pos3 == pos10 || pos4 == pos10 || pos5 == pos10 || pos6 == pos10 || pos7 == pos10 || pos8 == pos10 || pos9 == pos10);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 8 < 0)
                { pos11 = racerList[10]; }
                else
                { pos11 = racerList[startRnd - 8]; }
            } while (pole == pos11 || pos2 == pos11 || pos3 == pos11 || pos4 == pos11 || pos5 == pos11 || pos6 == pos11 || pos7 == pos11 || pos8 == pos11 || pos9 == pos11 || pos10 == pos11);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 8 < 0)
                { pos12 = racerList[11]; }
                else
                { pos12 = racerList[startRnd - 8]; }
            } while (pole == pos12 || pos2 == pos12 || pos3 == pos12 || pos4 == pos12 || pos5 == pos12 || pos6 == pos12 || pos7 == pos12 || pos8 == pos12 || pos9 == pos12 || pos10 == pos12 || pos11 == pos12);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 7 < 0)
                { pos13 = racerList[12]; }
                else
                { pos13 = racerList[startRnd - 7]; }
            } while (pole == pos13 || pos2 == pos13 || pos3 == pos13 || pos4 == pos13 || pos5 == pos13 || pos6 == pos13 || pos7 == pos13 || pos8 == pos13 || pos9 == pos13 || pos9 == pos13 || pos10 == pos13 || pos11 == pos13 || pos12 == pos13);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 7 < 0)
                { pos14 = racerList[13]; }
                else
                { pos14 = racerList[startRnd - 7]; }
            } while (pole == pos14 || pos2 == pos14 || pos3 == pos14 || pos4 == pos14 || pos5 == pos14 || pos6 == pos14 || pos7 == pos14 || pos8 == pos14 || pos9 == pos14 || pos9 == pos14 || pos10 == pos14 || pos11 == pos14 || pos12 == pos14 || pos13 == pos14);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 6 < 0)
                { pos15 = racerList[14]; }
                else
                { pos15 = racerList[startRnd - 6]; }
            } while (pole == pos15 || pos2 == pos15 || pos3 == pos15 || pos4 == pos15 || pos5 == pos15 || pos6 == pos15 || pos7 == pos15 || pos8 == pos15 || pos9 == pos15 || pos9 == pos15 || pos10 == pos15 || pos11 == pos15 || pos12 == pos15 || pos13 == pos15 || pos14 == pos15);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 6 < 0)
                { pos16 = racerList[15]; }
                else
                { pos16 = racerList[startRnd - 6]; }
            } while (pole == pos16 || pos2 == pos16 || pos3 == pos16 || pos4 == pos16 || pos5 == pos16 || pos6 == pos16 || pos7 == pos16 || pos8 == pos16 || pos9 == pos16 || pos9 == pos16 || pos10 == pos16 || pos11 == pos16 || pos12 == pos16 || pos13 == pos16 || pos14 == pos16 || pos15 == pos16);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 6 < 0)
                { pos17 = racerList[16]; }
                else
                { pos17 = racerList[startRnd - 6]; }
            } while (pole == pos17 || pos2 == pos17 || pos3 == pos17 || pos4 == pos17 || pos5 == pos17 || pos6 == pos17 || pos7 == pos17 || pos8 == pos17 || pos9 == pos17 || pos9 == pos17 || pos10 == pos17 || pos11 == pos17 || pos12 == pos17 || pos13 == pos17 || pos14 == pos17 || pos15 == pos17 || pos16 == pos17);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 5 < 0)
                { pos18 = racerList[17]; }
                else
                { pos18 = racerList[startRnd - 5]; }
            } while (pole == pos18 || pos2 == pos18 || pos3 == pos18 || pos4 == pos18 || pos5 == pos18 || pos6 == pos18 || pos7 == pos18 || pos8 == pos18 || pos9 == pos18 || pos9 == pos18 || pos10 == pos18 || pos11 == pos18 || pos12 == pos18 || pos13 == pos18 || pos14 == pos18 || pos15 == pos18 || pos16 == pos18 || pos17 == pos18);

            do
            {
                startRnd = rnd.Next(24);
                if (startRnd - 4 < 0)
                { pos19 = racerList[18]; }
                else
                { pos19 = racerList[startRnd - 4]; }
            } while (pole == pos19 || pos2 == pos19 || pos3 == pos19 || pos4 == pos19 || pos5 == pos19 || pos6 == pos19 || pos7 == pos19 || pos8 == pos19 || pos9 == pos19 || pos9 == pos19 || pos10 == pos19 || pos11 == pos19 || pos12 == pos19 || pos13 == pos19 || pos14 == pos18 || pos15 == pos19 || pos16 == pos19 || pos17 == pos19 || pos18 == pos19);

            do
            {
                startRnd = rnd.Next(20);
                pos20 = racerList[startRnd];
            } while (pole == pos20 || pos2 == pos20 || pos3 == pos20 || pos4 == pos20 || pos5 == pos20 || pos6 == pos20 || pos7 == pos20 || pos8 == pos20 || pos9 == pos20 || pos9 == pos20 || pos10 == pos20 || pos11 == pos20 || pos12 == pos20 || pos13 == pos20 || pos14 == pos20 || pos15 == pos20 || pos16 == pos20 || pos17 == pos20 || pos18 == pos20 || pos19 == pos20);

            do
            {

                if (minute > 30)
                { Console.Clear(); }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Date: Sun, Nov 13, 2022, 9:{minute}PM");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                minute++;
                Console.Write("FORMULA 1 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sao Paulo Grand Prix\n\nThe Race is about to begin\nYou may: 1 Check starting positions\n         2 Check the circuit\n         3 Read the tutorial\n         4 Start the Race");
                var preRace = Console.ReadLine().ToLower();
                if (preRace == "1")
                {
                    Console.Clear();
                    var lineup = new List<string> { pole, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20 };
                    int writeLineup = 0;
                    foreach (string item in lineup)
                    {
                        Console.WriteLine(writeLineup + 1 +" - "  + lineup[writeLineup]);
                        writeLineup++;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                }
                else if (preRace == "2")
                {
                    Console.Clear();
                    Map();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                }
                else if (preRace == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Placeholder");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                }
                else if (preRace == "4")
                {
                    minute = 60;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, type just the number");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadLine();
                }
            } while (minute < 60);
            Console.ForegroundColor = ConsoleColor.White;
            RedLights();
            Console.Clear();
            Console.Write("Theres no Gameplay rofl\nCool lights tho");
            Console.ReadKey();
        }
        public static void Map()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                        F1-BRAZILIAN-GP-F1F       \n                    F1F1              F1  F1F     ");
            Console.WriteLine("                 F1F1   F1F1F1    F1F1 F1    F1   \n             F1F1    F1F1   F1  F1F  F1F      F1F ");
            Console.WriteLine("        F1F1F       F1      F1F1F1  F1          F1\n    F1F1            F1F            F1          F1 ");
            Console.WriteLine(" F1F                   F1F1F         F1F1F      F1\n F1F                        F1F1F1F       F1F1F1  ");
            Console.WriteLine("   F1F                             F1F1           \n   F1                                 F1          ");
            Console.WriteLine("   F1                                 F1          \n    F1                                F1          ");
            Console.WriteLine("      F1F1F1F-14-LAPS-15-TURNS-F1F1F1F1           \n");
        }
        public static void RedLights()
        {
            Console.Clear();
            Console.Write("·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\r·");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r··");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r···");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }
    }
}
