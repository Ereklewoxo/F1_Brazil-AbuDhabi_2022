using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Brazil_GP
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            var teamList = new List<string> { "Mercedes", "Red Bull", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas" };
            var racerList = new List<string> { "Charles Leclerc", "Max Verstappen", "Carlos Sainz", "Sergio Perez", "Lewis Hamilton", "George Russell", "Fernando Alonso", "Lando Norris", "Esteban Ocon", "Valtteri Bottas", "Daniel Ricciardo", "Pierre Gasly", "Kevin Magnussen", "Nyck De Vries", "Yuki Tsunoda", "Mick Schumacher", "Zhou Guanyu", "Sebastian Vettel", "Alexander Albon", "Lance Stroll" };
            var racerListS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
            string userTeam = "Audi";
            ConsoleKeyInfo key;
            program.MiniGameFL();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            F1Logo();
            Console.WriteLine("  /BRAZIL 2022 GP/");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWhat's your first name?");
            string userFirstName = Console.ReadLine();
            if (userFirstName.Length == 1)
            {
                userFirstName = userFirstName.ToUpper();
            }
            else if (userFirstName.Length == 0)
            {
                userFirstName = "John";
            }
            else
            {
                userFirstName = userFirstName.Remove(1).ToUpper() + userFirstName.Remove(0, 1).ToLower();
            }
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.Write($"And your last name?    \n{userFirstName} ");
            string userLastName = Console.ReadLine();
            if (userLastName.Length == 1)
            {
                userLastName = userLastName.ToUpper();
            }
            else if (userLastName.Length == 0)
            {
                userLastName = "Doe";
            }
            else
            {
                userLastName = userLastName.Remove(1).ToUpper() + userLastName.Remove(0, 1).ToLower();
            }
            string userName = userFirstName + " " + userLastName;
            string userNameS;
            if (userLastName.Length == 3)
            {
                userNameS = userLastName;
            }
            else if (userFirstName.Length + userLastName.Length < 3)
            {
                userNameS = userFirstName + userLastName;
            }
            else if (userFirstName.Length + userLastName.Length == 3)
            {
                userNameS = userFirstName + userLastName;
            }
            else if (userFirstName.Length > 1 && userLastName.Length == 1)
            {
                userNameS = userFirstName.Remove(2) + userLastName;
            }
            else if (userFirstName.Length > 1 && userLastName.Length < 3)
            {
                userNameS = userFirstName.Remove(1) + userLastName;
            }
            else
            {
                userNameS = userLastName.Remove(3);
            }
            userNameS = userNameS.ToUpper();
            if(racerListS.Contains(userNameS))
            { userNameS = "YOU";  }
            Console.Clear();
            Console.Write("For ");
            //teams
            for (int i = 0; i < 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int writeTeams = 0;
                Console.WriteLine($"which team do you wish to play {userName}?");
                foreach (string item in teamList)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (writeTeams + 1 == 10)
                    {
                        Console.Write(0 + " - " + teamList[writeTeams]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(writeTeams + 1 + " - " + teamList[writeTeams]);
                        switch (teamList[writeTeams])
                        {
                            case "Mercedes":
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            case "Red Bull":
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                break;
                            case "Ferrari":
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                            case "McLaren":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "Alpine":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "AlphaTauri":
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case "Aston Martin":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "Williams":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case "Alfa Romeo":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                        }
                    }
                    Console.WriteLine("/");
                    writeTeams++;
                }
                userTeam = Console.ReadLine().ToLower();
                Console.Clear();
                ConsoleKey replace;
                switch (userTeam)
                {
                    case "1":
                    case "mercedes":
                    case "mersedes":
                        userTeam = teamList[0];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"1 - {racerList[4]}/\n2 - {racerList[5]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[4]}\n\r2 - {racerList[5]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[4] = userName;
                                    racerListS[4] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[5] = userName;
                                    racerListS[5] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "2":
                    case "red":
                    case "bull":
                    case "redbull":
                    case "red bull":
                        userTeam = teamList[1];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"1 - {racerList[1]}/\n2 - {racerList[3]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[1]}\n\r2 - {racerList[3]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[1] = userName;
                                    racerListS[1] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[3] = userName;
                                    racerListS[3] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "3":
                    case "ferari":
                    case "ferrari":
                        userTeam = teamList[2];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"1 - {racerList[0]}/\n2 - {racerList[2]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[0]}\n\r2 - {racerList[2]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[0] = userName;
                                    racerListS[0] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[2] = userName;
                                    racerListS[2] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "4":
                    case "mcl":
                    case "mclaren":
                        userTeam = teamList[3];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"1 - {racerList[10]}/\n2 - {racerList[7]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[10]}\n\r2 - {racerList[7]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[10] = userName;
                                    racerListS[10] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[7] = userName;
                                    racerListS[7] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "5":
                    case "alpine":
                    case "alpin":
                        userTeam = teamList[4];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"1 - {racerList[8]}/\n2 - {racerList[6]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[8]}\n\r2 - {racerList[6]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[8] = userName;
                                    racerListS[8] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[6] = userName;
                                    racerListS[6] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "6":
                    case "alphatauri":
                    case "alpha tauri":
                    case "tauri":
                        userTeam = teamList[5];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"1 - {racerList[11]}/\n2 - {racerList[14]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[11]}\n\r2 - {racerList[14]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[11] = userName;
                                    racerListS[11] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[14] = userName;
                                    racerListS[14] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "7":
                    case "aston martin":
                    case "astonmartin":
                    case "aston":
                    case "martin":
                        userTeam = teamList[6];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"1 - {racerList[17]}/\n2 - {racerList[19]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[17]}\n\r2 - {racerList[19]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[17] = userName;
                                    racerListS[17] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[19] = userName;
                                    racerListS[19] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "8":
                    case "willliams":
                    case "wiliams":
                    case "wil":
                        userTeam = teamList[7];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"1 - {racerList[13]}/\n2 - {racerList[18]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[13]}\n\r2 - {racerList[18]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[13] = userName;
                                    racerListS[13] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[18] = userName;
                                    racerListS[18] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "9":
                    case "alfa romeo":
                    case "alfaromeo":
                    case "alfa":
                    case "romeo":
                        userTeam = teamList[8];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"1 - {racerList[9]}/\n2 - {racerList[16]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[9]}\n\r2 - {racerList[16]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[9] = userName;
                                    racerListS[9] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[16] = userName;
                                    racerListS[16] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    case "0":
                    case "haas":
                    case "has":
                        userTeam = teamList[9];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("You are racing for ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(userTeam);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Who should you replace?");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine($"1 - {racerList[12]}/\n2 - {racerList[15]}/");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                            Console.WriteLine($"\r1 - {racerList[12]}\n\r2 - {racerList[15]}");
                            replace = Console.ReadKey().Key;
                            switch (replace)
                            {
                                case ConsoleKey.D1:
                                    racerList[12] = userName;
                                    racerListS[12] = userNameS;
                                    break;
                                case ConsoleKey.D2:
                                    racerList[15] = userName;
                                    racerListS[15] = userNameS;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    j--;
                                    break;
                            }
                        }
                        break;
                    default:
                        i--;
                        Console.Clear();
                        Console.WriteLine($"Invalid input - '{userTeam}'");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Again, for ");
                        break;
                }
            }
            string pole; string pos2; string pos3; string pos4; string pos5; string pos6; string pos7; string pos8; string pos9; string pos10; string pos11; string pos12; string pos13; string pos14; string pos15; string pos16; string pos17; string pos18; string pos19; string pos20;
            var lineupS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
            Random rnd = new Random();
            //starting lineup generator ☻ ☺
            do
            {
                int startRnd = rnd.Next(24);
                if (startRnd - 18 < 0)
                {
                    if (startRnd > 18)
                    {
                        pole = racerList[1];
                        lineupS[0] = racerListS[1];
                    }
                    else
                    {
                        pole = racerList[0];
                        lineupS[0] = racerListS[0];
                    }
                }
                else
                {
                    pole = racerList[startRnd - 18];
                    lineupS[0] = racerListS[startRnd - 18];
                }
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 18 < 0)
                    {
                        pos2 = racerList[1];
                        lineupS[1] = racerListS[1];
                    }
                    else if (startRnd > 18)
                    {
                        pos2 = racerList[0];
                        lineupS[1] = racerListS[0];
                    }
                    else
                    {
                        pos2 = racerList[startRnd - 18];
                        lineupS[1] = racerListS[startRnd - 18];
                    }
                } while (pole == pos2);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 16 < 0)
                    {
                        pos3 = racerList[2];
                        lineupS[2] = racerListS[2];
                    }
                    else
                    {
                        pos3 = racerList[startRnd - 16];
                        lineupS[2] = racerListS[startRnd - 16];
                    }
                } while (pole == pos3 || pos2 == pos3);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 15 < 0)
                    {
                        pos4 = racerList[3];
                        lineupS[3] = racerListS[3];
                    }
                    else
                    {
                        pos4 = racerList[startRnd - 15];
                        lineupS[3] = racerListS[startRnd - 15];
                    }
                } while (pole == pos4 || pos2 == pos4 || pos3 == pos4);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 14 < 0)
                    {
                        pos5 = racerList[4];
                        lineupS[4] = racerListS[4];
                    }
                    else
                    {
                        pos5 = racerList[startRnd - 14];
                        lineupS[4] = racerListS[startRnd - 14];
                    }
                } while (pole == pos5 || pos2 == pos5 || pos3 == pos5 || pos4 == pos5);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 13 < 0)
                    {
                        pos6 = racerList[5];
                        lineupS[5] = racerListS[5];
                    }
                    else
                    {
                        pos6 = racerList[startRnd - 13];
                        lineupS[5] = racerListS[startRnd - 13];
                    }
                } while (pole == pos6 || pos2 == pos6 || pos3 == pos6 || pos4 == pos6 || pos5 == pos6);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 12 < 0)
                    {
                        pos7 = racerList[6];
                        lineupS[6] = racerListS[6];
                    }
                    else
                    {
                        pos7 = racerList[startRnd - 12];
                        lineupS[6] = racerListS[startRnd - 12];
                    }
                } while (pole == pos7 || pos2 == pos7 || pos3 == pos7 || pos4 == pos7 || pos5 == pos7 || pos6 == pos7);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 12 < 0)
                    {
                        pos8 = racerList[7];
                        lineupS[7] = racerListS[7];
                    }
                    else
                    {
                        pos8 = racerList[startRnd - 12];
                        lineupS[7] = racerListS[startRnd - 12];
                    }
                } while (pole == pos8 || pos2 == pos8 || pos3 == pos8 || pos4 == pos8 || pos5 == pos8 || pos6 == pos8 || pos7 == pos8);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 9 < 0)
                    {
                        pos9 = racerList[8];
                        lineupS[8] = racerListS[8];
                    }
                    else
                    {
                        pos9 = racerList[startRnd - 9];
                        lineupS[8] = racerListS[startRnd - 9];
                    }
                } while (pole == pos9 || pos2 == pos9 || pos3 == pos9 || pos4 == pos9 || pos5 == pos9 || pos6 == pos9 || pos7 == pos9 || pos8 == pos9);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 9 < 0)
                    {
                        pos10 = racerList[9];
                        lineupS[9] = racerListS[9];
                    }
                    else
                    {
                        pos10 = racerList[startRnd - 9];
                        lineupS[9] = racerListS[startRnd - 9];
                    }
                } while (pole == pos10 || pos2 == pos10 || pos3 == pos10 || pos4 == pos10 || pos5 == pos10 || pos6 == pos10 || pos7 == pos10 || pos8 == pos10 || pos9 == pos10);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 8 < 0)
                    {
                        pos11 = racerList[10];
                        lineupS[10] = racerListS[10];
                    }
                    else
                    {
                        pos11 = racerList[startRnd - 8];
                        lineupS[10] = racerListS[startRnd - 8];
                    }
                } while (pole == pos11 || pos2 == pos11 || pos3 == pos11 || pos4 == pos11 || pos5 == pos11 || pos6 == pos11 || pos7 == pos11 || pos8 == pos11 || pos9 == pos11 || pos10 == pos11);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 7 < 0)
                    {
                        pos12 = racerList[11];
                        lineupS[11] = racerListS[11];
                    }
                    else
                    {
                        pos12 = racerList[startRnd - 7];
                        lineupS[11] = racerListS[startRnd - 7];
                    }
                } while (pole == pos12 || pos2 == pos12 || pos3 == pos12 || pos4 == pos12 || pos5 == pos12 || pos6 == pos12 || pos7 == pos12 || pos8 == pos12 || pos9 == pos12 || pos10 == pos12 || pos11 == pos12);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 6 < 0)
                    {
                        pos13 = racerList[12];
                        lineupS[12] = racerListS[12];
                    }
                    else
                    {
                        pos13 = racerList[startRnd - 6];
                        lineupS[12] = racerListS[startRnd - 6];
                    }
                } while (pole == pos13 || pos2 == pos13 || pos3 == pos13 || pos4 == pos13 || pos5 == pos13 || pos6 == pos13 || pos7 == pos13 || pos8 == pos13 || pos9 == pos13 || pos10 == pos13 || pos11 == pos13 || pos12 == pos13);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos14 = racerList[13];
                        lineupS[13] = racerListS[13];
                    }
                    else
                    {
                        pos14 = racerList[startRnd - 5];
                        lineupS[13] = racerListS[startRnd - 5];
                    }
                } while (pole == pos14 || pos2 == pos14 || pos3 == pos14 || pos4 == pos14 || pos5 == pos14 || pos6 == pos14 || pos7 == pos14 || pos8 == pos14 || pos9 == pos14 || pos10 == pos14 || pos11 == pos14 || pos12 == pos14 || pos13 == pos14);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos15 = racerList[14];
                        lineupS[14] = racerListS[14];
                    }
                    else
                    {
                        pos15 = racerList[startRnd - 5];
                        lineupS[14] = racerListS[startRnd - 5];
                    }
                } while (pole == pos15 || pos2 == pos15 || pos3 == pos15 || pos4 == pos15 || pos5 == pos15 || pos6 == pos15 || pos7 == pos15 || pos8 == pos15 || pos9 == pos15 || pos10 == pos15 || pos11 == pos15 || pos12 == pos15 || pos13 == pos15 || pos14 == pos15);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos16 = racerList[15];
                        lineupS[15] = racerListS[15];
                    }
                    else
                    {
                        pos16 = racerList[startRnd - 5];
                        lineupS[15] = racerListS[startRnd - 5];
                    }
                } while (pole == pos16 || pos2 == pos16 || pos3 == pos16 || pos4 == pos16 || pos5 == pos16 || pos6 == pos16 || pos7 == pos16 || pos8 == pos16 || pos9 == pos16 || pos10 == pos16 || pos11 == pos16 || pos12 == pos16 || pos13 == pos16 || pos14 == pos16 || pos15 == pos16);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos17 = racerList[16];
                        lineupS[16] = racerListS[16];
                    }
                    else
                    {
                        pos17 = racerList[startRnd - 5];
                        lineupS[16] = racerListS[startRnd - 5];
                    }
                } while (pole == pos17 || pos2 == pos17 || pos3 == pos17 || pos4 == pos17 || pos5 == pos17 || pos6 == pos17 || pos7 == pos17 || pos8 == pos17 || pos9 == pos17 || pos10 == pos17 || pos11 == pos17 || pos12 == pos17 || pos13 == pos17 || pos14 == pos17 || pos15 == pos17 || pos16 == pos17);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos18 = racerList[17];
                        lineupS[17] = racerListS[17];
                    }
                    else
                    {
                        pos18 = racerList[startRnd - 5];
                        lineupS[17] = racerListS[startRnd - 5];
                    }
                } while (pole == pos18 || pos2 == pos18 || pos3 == pos18 || pos4 == pos18 || pos5 == pos18 || pos6 == pos18 || pos7 == pos18 || pos8 == pos18 || pos9 == pos18 || pos10 == pos18 || pos11 == pos18 || pos12 == pos18 || pos13 == pos18 || pos14 == pos18 || pos15 == pos18 || pos16 == pos18 || pos17 == pos18);
                do
                {
                    startRnd = rnd.Next(24);
                    if (startRnd - 5 < 0)
                    {
                        pos19 = racerList[18];
                        lineupS[18] = racerListS[18];
                    }
                    else
                    {
                        pos19 = racerList[startRnd - 5];
                        lineupS[18] = racerListS[startRnd - 5];
                    }
                } while (pole == pos19 || pos2 == pos19 || pos3 == pos19 || pos4 == pos19 || pos5 == pos19 || pos6 == pos19 || pos7 == pos19 || pos8 == pos19 || pos9 == pos19 || pos10 == pos19 || pos11 == pos19 || pos12 == pos19 || pos13 == pos19 || pos14 == pos19 || pos15 == pos19 || pos16 == pos19 || pos17 == pos19 || pos18 == pos19);
                do
                {
                    startRnd = rnd.Next(20);
                    pos20 = racerList[startRnd];
                    lineupS[19] = racerListS[startRnd];
                } while (pole == pos20 || pos2 == pos20 || pos3 == pos20 || pos4 == pos20 || pos5 == pos20 || pos6 == pos20 || pos7 == pos20 || pos8 == pos20 || pos9 == pos20 || pos10 == pos20 || pos11 == pos20 || pos12 == pos20 || pos13 == pos20 || pos14 == pos20 || pos15 == pos20 || pos16 == pos20 || pos17 == pos20 || pos18 == pos20 || pos19 == pos20);
            } while (pole == pos2);
            var lineup = new List<string> { pole, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20 };
            int writeLineup;
            Console.Clear();
            for (int min = 30; min < 60; min++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Date: Sun, Nov 13, 2022, 9:{min}PM");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("FORMULA 1 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sao Paulo Grand Prix\n\nThe Race is about to begin\nYou may: 1 - Check starting positions" +
                                  "\n         2 - Check the circuit\n         3 - Read the tutorial\n         4 - Start the Race");
                var preRace = Console.ReadKey().Key;
                if (preRace == ConsoleKey.D1)
                {
                    Console.Clear();
                    writeLineup = 0;
                    foreach (string item in lineupS)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (lineupS[writeLineup] == userNameS)
                        {
                            Console.Write(writeLineup + 1 + $" - ");
                            Console.Write($"{lineupS[writeLineup]}");
                            switch (userTeam)
                            {
                                case "Mercedes":
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    break;
                                case "Red Bull":
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    break;
                                case "Ferrari":
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    break;
                                case "McLaren":
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    break;
                                case "Alpine":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case "AlphaTauri":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    break;
                                case "Aston Martin":
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    break;
                                case "Williams":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;
                                case "Alfa Romeo":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case "Haas":
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                            }
                            Console.Write("/ ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(lineup[writeLineup]);
                        }
                        else
                        {
                            Console.Write(writeLineup + 1 + $" - {lineupS[writeLineup]}");
                            switch (lineupS[writeLineup])
                            {
                                case "HAM":
                                case "RUS":
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    break;
                                case "VER":
                                case "PER":
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    break;
                                case "LEC":
                                case "SAI":
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    break;
                                case "NOR":
                                case "RIC":
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    break;
                                case "OCO":
                                case "ALO":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case "GAS":
                                case "TSU":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    break;
                                case "VET":
                                case "STR":
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    break;
                                case "ALB":
                                case "DEV":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;
                                case "BOT":
                                case "ZHO":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case "MSC":
                                case "MAG":
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                            }
                            Console.Write("/ ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(lineup[writeLineup]);
                        }
                        writeLineup++;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Press 'Enter' to continue");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                    Console.Clear();
                }
                else if (preRace == ConsoleKey.D2)
                {
                    Console.Clear();
                    Map();
                    Console.Clear();
                }
                else if (preRace == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("For now this is just sim");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Press 'Enter' to continue");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                    Console.Clear();
                }
                else if (preRace == ConsoleKey.D4)
                { min = 60; }
                else if (preRace == ConsoleKey.Enter)
                { Console.Clear(); }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, type just the number");
                }
            }
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < lineup.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i % 2 == 0)
                { Console.Write($"   {lineupS[i]}"); }
                else
                { Console.Write($"           {lineupS[i]}"); }
                if (lineupS[i] == userNameS)
                {
                    switch (userTeam)
                    {
                        case "Mercedes":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case "Red Bull":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "Ferrari":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case "McLaren":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "Alpine":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "AlphaTauri":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "Aston Martin":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case "Williams":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case "Alfa Romeo":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "Haas":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                }
                else
                {
                    switch (lineupS[i])
                    {
                        case "HAM":
                        case "RUS":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case "VER":
                        case "PER":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "LEC":
                        case "SAI":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case "NOR":
                        case "RIC":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "OCO":
                        case "ALO":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "GAS":
                        case "TSU":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case "VET":
                        case "STR":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case "ALB":
                        case "DEV":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case "BOT":
                        case "ZHO":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "MSC":
                        case "MAG":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                }
                Console.WriteLine("/");
            }
            RedLights();
            Console.Clear();
            Console.WriteLine("It's lights out and away we go");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            Console.ForegroundColor = ConsoleColor.White;
            int VER = 0; int LEC = 0; int HAM = 0; int RUS = 0; int PER = 0; int SAI = 0; int STR = 0; int RIC = 0; int NOR = 0; int GAS = 0;
            int ZHO = 0; int BOT = 0; int ALB = 0; int MAG = 0; int DEV = 0; int MSC = 0; int TSU = 0; int ALO = 0; int OCO = 0; int VET = 0; int USER = 0;
            int VERp = 0; int LECp = 0; int HAMp = 0; int RUSp = 0; int PERp = 0; int SAIp = 0; int STRp = 0; int RICp = 0; int NORp = 0; int GASp = 0;
            int ZHOp = 0; int BOTp = 0; int ALBp = 0; int MAGp = 0; int DEVp = 0; int MSCp = 0; int TSUp = 0; int ALOp = 0; int OCOp = 0; int VETp = 0; int USERp = 0;
            //race
            var lap = new List<int>();
            int lapCount = 1;
            int pitCount = 0;
            int challengeCount = 1;
            int random;
            double randomDNF;
            string userShort = userNameS;
            for (int race = 0; race < 8; race++)
            {
                Console.Clear();
                int scoreLap1 = 0;
                int scoreDRS = 0;
                int scorePit = 0;
                if (USER < 1000)
                {
                    random = rnd.Next(2);
                    Console.WriteLine($"LAP {lapCount}/71");
                    Console.Write($"Challenge {challengeCount} - ");
                    if (race == 0)
                    {
                        scoreLap1 = program.MiniGameLap1();
                    }
                    else if (random == 1 && USERp != 1)
                    {
                        scoreDRS = program.MiniGameDRS();
                    }
                    else if (random == 0 && pitCount < 2 && race > 1)
                    {
                        pitCount++;
                        scorePit = program.MiniGamePit();
                    }
                }
                int score = scoreLap1 + scoreDRS + scorePit;
                challengeCount++;
                Console.Clear();
                for (int i = 0; i < 1;)
                {
                    for (int j = 0; j < lineupS.Count; j++)
                    {
                        if (lineupS[j] == "VER")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(27, 27 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(27, 27 + (VERp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.002)
                            { 
                                random = (16 - race) * 1000 + random;
                            }
                            VER = random;
                        }
                        else if (lineupS[j] == "LEC")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(33, 33 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(33, 33 + (LECp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.003)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            LEC = random;
                        }
                        else if (lineupS[j] == "HAM")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(46, 46 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(46, 46 + (HAMp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.001)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            HAM = random;
                        }
                        else if (lineupS[j] == "RUS")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(45, 45 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(45, 45 + (RUSp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.001)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            RUS = random;
                        }
                        else if (lineupS[j] == "PER")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(38, 38 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(38, 38 + (PERp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.003)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            PER = random;
                        }
                        else if (lineupS[j] == "SAI")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(35, 35 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(35, 35 + (SAIp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.005)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            SAI = random;
                        }
                        else if (lineupS[j] == "NOR")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(78, 78 + (NORp + 1) * 15); }
                            else
                            { random = rnd.Next(78, 78 + (j + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.001)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            NOR = random;
                        }
                        else if (lineupS[j] == "RIC")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(117, 117 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(117, 117 + (RICp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.002)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            RIC = random;
                        }
                        else if (lineupS[j] == "OCO")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(82, 82 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(82, 82 + (OCOp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.002)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            OCO = random;
                        }
                        else if (lineupS[j] == "ALO")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(88, 88 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(88, 88 + (ALOp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.005)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            ALO = random;
                        }
                        else if (lineupS[j] == "GAS")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(112, 112 + (GASp + 1) * 15); }
                            else
                            { random = rnd.Next(112, 112 + (j + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.005)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            GAS = random;
                        }
                        else if (lineupS[j] == "TSU")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(128, 128 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(128, 128 + (TSUp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.007)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            TSU = random;
                        }
                        else if (lineupS[j] == "STR")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(117, 117 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(117, 117 + (STRp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.003)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            STR = random;
                        }
                        else if (lineupS[j] == "VET")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(105, 105 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(105, 105 + (VETp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.004)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            VET = random;
                        }
                        else if (lineupS[j] == "ALB")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(126, 126 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(126, 126 + (ALBp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.004)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            ALB = random;
                        }
                        else if (lineupS[j] == "DEV")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(100, 100 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(100, 100 + (DEVp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.004)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            DEV = random;
                        }
                        else if (lineupS[j] == "BOT")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(102, 102 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(102, 102 + (BOTp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.005)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            BOT = random;
                        }
                        else if (lineupS[j] == "ZHO")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(130, 130 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(130, 130 + (ZHOp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.006)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            ZHO = random;
                        }
                        else if (lineupS[j] == "MAG")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(129, 129 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(129, 129 + (MAGp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.004)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            MAG = random;
                        }
                        else if (lineupS[j] == "MSC")
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(135, 135 + (j + 1) * 15); }
                            else
                            { random = rnd.Next(135, 135 + (MSCp + 1) * 15); }
                            randomDNF = rnd.NextDouble();
                            if (randomDNF < 0.002)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            MSC = random;
                        }
                        //user input here
                        else if (lineupS[j] == userNameS)
                        {
                            if (lapCount == 1)
                            { random = rnd.Next(score, score + (j + 1) * 15); }
                            else
                            { random = rnd.Next(score, score + (USERp + 1) * 15); }
                            if (score > 1000)
                            {
                                random = (16 - race) * 1000 + random;
                            }
                            USER = random;
                        }
                    }
                    lap = new List<int> { VER, LEC, HAM, RUS, PER, SAI, STR, RIC, NOR, GAS, ZHO, BOT, ALB, MAG, DEV, MSC, TSU, ALO, OCO, VET, USER };
                    if (lap.Count() == lap.Distinct().Count())
                    {
                        i++;
                    }
                }
                lap.Sort();
                lap.RemoveAt(0);
                for (int i = 0; i < lap.Count; i++)
                { 
                    if (lap[i] > 1000)
                    {
                        if (lap[i] == VER)
                        {
                            lineupS.Remove("VER");
                        }
                        else if (lap[i] == LEC)
                        {
                            lineupS.Remove("LEC");
                        }
                        else if (lap[i] == HAM)
                        {
                            lineupS.Remove("HAM");
                        }
                        else if (lap[i] == RUS)
                        {
                            lineupS.Remove("RUS");
                        }
                        else if (lap[i] == PER)
                        {
                            lineupS.Remove("PER");
                        }
                        else if (lap[i] == SAI)
                        {
                            lineupS.Remove("SAI");
                        }
                        else if (lap[i] == NOR)
                        {
                            lineupS.Remove("NOR");
                        }
                        else if (lap[i] == RIC)
                        {
                            lineupS.Remove("RIC");
                        }
                        else if (lap[i] == OCO)
                        {
                            lineupS.Remove("OCO");
                        }
                        else if (lap[i] == ALO)
                        {
                            lineupS.Remove("ALO");
                        }
                        else if (lap[i] == GAS)
                        {
                            lineupS.Remove("GAS");
                        }
                        else if (lap[i] == TSU)
                        {
                            lineupS.Remove("TSU");
                        }
                        else if (lap[i] == STR)
                        {
                            lineupS.Remove("STR");
                        }
                        else if (lap[i] == VET)
                        {
                            lineupS.Remove("VET");
                        }
                        else if (lap[i] == ALB)
                        {
                            lineupS.Remove("ALB");
                        }
                        else if (lap[i] == DEV)
                        {
                            lineupS.Remove("DEV");
                        }
                        else if (lap[i] == BOT)
                        {
                            lineupS.Remove("BOT");
                        }
                        else if (lap[i] == ZHO)
                        {
                            lineupS.Remove("ZHO");
                        }
                        else if (lap[i] == MAG)
                        {
                            lineupS.Remove("MAG");
                        }
                        else if (lap[i] == MSC)
                        {
                            lineupS.Remove("MSC");
                        }
                        else if (lap[i] == USER)
                        {
                            lineupS.Remove(userNameS);
                        }
                    }
                }
                for (int i = 0; i < lap.Count; i++)
                {
                    if (lap[i] == VER)
                    {
                        VERp = i;
                    }
                    else if (lap[i] == LEC)
                    {
                        LECp = i;
                    }
                    else if (lap[i] == HAM)
                    {
                        HAMp = i;
                    }
                    else if (lap[i] == RUS)
                    {
                        RUSp = i;
                    }
                    else if (lap[i] == PER)
                    {
                        PERp = i;
                    }
                    else if (lap[i] == SAI)
                    {
                        SAIp = i;
                    }
                    else if (lap[i] == NOR)
                    {
                        NORp = i;
                    }
                    else if (lap[i] == RIC)
                    {
                        RICp = i;
                    }
                    else if (lap[i] == OCO)
                    {
                        OCOp = i;
                    }
                    else if (lap[i] == ALO)
                    {
                        ALOp = i;
                    }
                    else if (lap[i] == GAS)
                    {
                        GASp = i;
                    }
                    else if (lap[i] == TSU)
                    {
                        TSUp = i;
                    }
                    else if (lap[i] == STR)
                    {
                        STRp = i;
                    }
                    else if (lap[i] == VET)
                    {
                        VETp = i;
                    }
                    else if (lap[i] == ALB)
                    {
                        ALBp = i;
                    }
                    else if (lap[i] == DEV)
                    {
                        DEVp = i;
                    }
                    else if (lap[i] == BOT)
                    {
                        BOTp = i;
                    }
                    else if (lap[i] == ZHO)
                    {
                        ZHOp = i;
                    }
                    else if (lap[i] == MAG)
                    {
                        MAGp = i;
                    }
                    else if (lap[i] == MSC)
                    {
                        MSCp = i;
                    }
                    else if (lap[i] == USER)
                    {
                        USERp = i;
                    }
                }
                { Console.ForegroundColor = ConsoleColor.White; }
                Console.WriteLine($"LAP {lapCount}/71");
                lapCount += 10;
                for (int i = 0; i < 20; i++)
                {
                    if (i <10)
                    { Console.ForegroundColor = ConsoleColor.Yellow; }
                    if (i < 9)
                    { Console.Write(" " + (i + 1)); }
                    else
                    { Console.Write(i + 1); }
                    if (lap[i] == USER)
                    {
                        switch (userTeam)
                        {
                            case "Mercedes":
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            case "Red Bull":
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                break;
                            case "Ferrari":
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                            case "McLaren":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "Alpine":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "AlphaTauri":
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case "Aston Martin":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "Williams":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case "Alfa Romeo":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "Haas":
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }
                    }
                    else
                    {
                        if (lap[i] == VER || lap[i] == PER)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        else if (lap[i] == SAI || lap[i] == LEC)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        else if (lap[i] == RUS || lap[i] == HAM)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                        else if (lap[i] == NOR || lap[i] == RIC)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (lap[i] == OCO || lap[i] == ALO)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (lap[i] == GAS || lap[i] == TSU)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (lap[i] == STR || lap[i] == VET)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else if (lap[i] == ALB || lap[i] == DEV)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (lap[i] == BOT || lap[i] == ZHO)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (lap[i] == MAG || lap[i] == MSC)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    { Console.Write(" |"); }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lap[i] > 1000)
                    { Console.ForegroundColor = ConsoleColor.DarkGray; }
                    if (lap[i] == VER)
                    { Console.WriteLine(" VER"); }
                    else if (lap[i] == PER)
                    { Console.WriteLine(" PER"); }
                    else if (lap[i] == SAI)
                    { Console.WriteLine(" SAI"); }
                    else if (lap[i] == LEC)
                    { Console.WriteLine(" LEC"); }
                    else if (lap[i] == RUS)
                    { Console.WriteLine(" RUS"); }
                    else if (lap[i] == HAM)
                    { Console.WriteLine(" HAM"); }
                    else if (lap[i] == NOR)
                    { Console.WriteLine(" NOR"); }
                    else if (lap[i] == RIC)
                    { Console.WriteLine(" RIC"); }
                    else if (lap[i] == OCO)
                    { Console.WriteLine(" OCO"); }
                    else if (lap[i] == ALO)
                    { Console.WriteLine(" ALO"); }
                    else if (lap[i] == GAS)
                    { Console.WriteLine(" GAS"); }
                    else if (lap[i] == TSU)
                    { Console.WriteLine(" TSU"); }
                    else if (lap[i] == STR)
                    { Console.WriteLine(" STR"); }
                    else if (lap[i] == VET)
                    { Console.WriteLine(" VET"); }
                    else if (lap[i] == ALB)
                    { Console.WriteLine(" ALB"); }
                    else if (lap[i] == DEV)
                    { Console.WriteLine(" DEV"); }
                    else if (lap[i] == BOT)
                    { Console.WriteLine(" BOT"); }
                    else if (lap[i] == ZHO)
                    { Console.WriteLine(" ZHO"); }
                    else if (lap[i] == MAG)
                    { Console.WriteLine(" MAG"); }
                    else if (lap[i] == MSC)
                    { Console.WriteLine(" MSC"); }
                    else if (lap[i] == USER)
                    { Console.WriteLine($" {userShort}"); }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Press 'Enter' to continue");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void F1Logo()
        {
            Console.WriteLine("     ______________  __" +
                            "\n   /  ____________//  /" +
                            "\n  /  /  _________//  /" +
                            "\n /__/__/         /__/" +
                            "\n");
        }
        public static void Map()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n                       F1F1-BRAZILIAN-GP-F1F1" +
                          "\n                    F1F                F1F   F1" +
                          "\n                 F1F      F1F1F1    F1F  F1    F1" +
                          "\n             START     F1F1   F1  F1F   F1F      F1 " +
                          "\n           F1F        F1       F1F1   F1          F1" +
                          "\n        F1F           F1F            F1           F1" +
                          "\n     F1F                 F1F1F         F1F1F      F1" +
                          "\n   F1F                        F1F1F1F       F1F1F1" +
                          "\n     F1F                             F1F1" +
                          "\n     F1                                 F1" +
                          "\n     F1                                  F1" +
                          "\n      F1                                F1" +
                          "\n        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1\n");
            for (int i = 0; i < 1;)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Length - 4.31KM");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("  Lap record");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" - 1.10.540 V. Bottas (2018)");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("■ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("- Sector 1");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("  ■ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("- Sector 2");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  ■ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("- Sector 3");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  DRS ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Zones - 2");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Or press 'Enter' to continue");
                Console.ForegroundColor = ConsoleColor.Black;
                var keyPressed = Console.ReadKey().Key;
                if (keyPressed == ConsoleKey.D1)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 16);
                    Console.Write("                                               " +
                                  "\n\r                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n\r                    F1F                F1F   F1" +
                                  "\n\r                 F1F      F1F1F1    F1F  F1    F1" +
                                  "\n\r             START     F1F1   F1  F1F   F1F      F1 " +
                                  "\n\r           F1F        F1       F1F1   F1          F1" +
                                  "\n\r        F1F           F1F            F1           F1" +
                                  "\n\r     F1F                 F1F1F         F1F1F      F1" +
                                  "\n\r   F1F                        F1F1F1F       F1F1F1" +
                                  "\n\r     F1F                             F1F1" +
                                  "\n\r     F1                                 F1" +
                                  "\n\r     F1                                  F1" +
                                  "\n\r      F1                                F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(0, Console.CursorTop - 10);
                    Console.Write("\n\r             START" +
                                  "\n\r           F1F" +
                                  "\n\r        F1F" +
                                  "\n\r     F1F" +
                                  "\n\r   F1F" +
                                  "\n\r     F1F" +
                                  "\n\r     F1" +
                                  "\n\r     F1" +
                                  "\n\r      F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F\n");
                }
                else if (keyPressed == ConsoleKey.D2)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 16);
                    Console.Write("                                               " +
                                  "\n\r                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n\r                    F1F                F1F   F1" +
                                  "\n\r                 F1F      F1F1F1    F1F  F1    F1" +
                                  "\n\r             START     F1F1   F1  F1F   F1F      F1 " +
                                  "\n\r           F1F        F1       F1F1   F1          F1" +
                                  "\n\r        F1F           F1F            F1           F1" +
                                  "\n\r     F1F                 F1F1F         F1F1F      F1" +
                                  "\n\r   F1F                        F1F1F1F       F1F1F1" +
                                  "\n\r     F1F                             F1F1" +
                                  "\n\r     F1                                 F1" +
                                  "\n\r     F1                                  F1" +
                                  "\n\r      F1                                F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(0, Console.CursorTop - 12);
                    Console.Write("\n\r                                       F1F" +
                                  "\n\r                          F1F1F1    F1F  F1" +
                                  "\n\r                       F1F1   F1  F1F   F1F" +
                                  "\n\r                      F1       F1F1   F1" +
                                  "\n\r                      F1F            F1" +
                                  "\n\r                         F1F1F         F1F1F" +
                                  "\n\r                              F1F1F1F       F1F" +
                                  "\n\r                                     F1F1" +
                                  "\n\r                                        F1" +
                                  "\n\r                                         F1" +
                                  "\n\r                                        F1" +
                                  "\n\r                                    1F1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 12);
                    Console.Write("\n\r                    F1F" +
                                  "\n\r                 F1F" +
                                  "\n\r             START" +
                                  "\n\r           F1F" +
                                  "\n\r        F1F" +
                                  "\n\r     F1F" +
                                  "\n\r   F1F" +
                                  "\n\r     F1F" +
                                  "\n\r     F1" +
                                  "\n\r     F1" +
                                  "\n\r      F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F\n");
                }
                else if (keyPressed == ConsoleKey.D3)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 16);
                    Console.Write("                                               " +
                                  "\n\r                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n\r                    F1F                F1F   F1" +
                                  "\n\r                 F1F      F1F1F1    F1F  F1    F1" +
                                  "\n\r             START     F1F1   F1  F1F   F1F      F1 " +
                                  "\n\r           F1F        F1       F1F1   F1          F1" +
                                  "\n\r        F1F           F1F            F1           F1" +
                                  "\n\r     F1F                 F1F1F         F1F1F      F1" +
                                  "\n\r   F1F                        F1F1F1F       F1F1F1" +
                                  "\n\r     F1F                             F1F1" +
                                  "\n\r     F1                                 F1" +
                                  "\n\r     F1                                  F1" +
                                  "\n\r      F1                                F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(0, Console.CursorTop - 13);
                    Console.Write("\n\r                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n\r                                             F1" +
                                  "\n\r                                               F1" +
                                  "\n\r                                                 F1" +
                                  "\n\r                                                  F1" +
                                  "\n\r                                                  F1" +
                                  "\n\r                                                  F1" +
                                  "\n\r                                               1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 7);
                    Console.Write("\n\r                                       F1F" +
                                  "\n\r                          F1F1F1    F1F  F1" +
                                  "\n\r             START     F1F1   F1  F1F   F1F" +
                                  "\n\r           F1F        F1       F1F1   F1" +
                                  "\n\r        F1F           F1F            F1" +
                                  "\n\r     F1F                 F1F1F         F1F1F" +
                                  "\n\r   F1F                        F1F1F1F       F1F" +
                                  "\n\r     F1F                             F1F1" +
                                  "\n\r     F1                                 F1" +
                                  "\n\r     F1                                  F1" +
                                  "\n\r      F1                                F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(0, Console.CursorTop - 12);
                    Console.Write("\n\r                    F1F" +
                                  "\n\r                 F1F\n\n\n\n\n\n\n\n\n\n\n");
                }
                else if (keyPressed == ConsoleKey.D || keyPressed == ConsoleKey.D4)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 16);
                    Console.Write("\n                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n                    F1F                F1F   F1" +
                                  "\n                 F1F      F1F1F1    F1F  F1    F1" +
                                  "\n             START     F1F1   F1  F1F   F1F      F1 " +
                                  "\n           F1F        F1       F1F1   F1          F1" +
                                  "\n        F1F           F1F            F1           F1" +
                                  "\n     F1F                 F1F1F         F1F1F      F1" +
                                  "\n   F1F                        F1F1F1F       F1F1F1" +
                                  "\n     F1F                             F1F1" +
                                  "\n     F1                                 F1" +
                                  "\n     F1                                  F1" +
                                  "\n      F1                                F1" +
                                  "\n        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, Console.CursorTop - 13);
                    Console.Write(    "                       ____" +
                                  "\n\r                    __/" +
                                  "\n\r                 __/" +
                                  "\n\r             ___/" +
                                  "\n\r           _/                                    F1" +
                                  "\n\r        __/" +
                                  "\n\r      _/" +
                                  "\n\r" +
                                  "\n\r   F1F" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r         ______________________________");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 9);
                    Console.Write("\n\r             START     F1F1   F1  F1F   F1F" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r" +
                                  "\n\r      F1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, Console.CursorTop - 9);
                    Console.Write("\n\r           _/\n\n\n\n\n\n\n\n\n\n");
                }
                else if(keyPressed == ConsoleKey.Enter)
                { i++; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 16);
                    Console.Write("                                               " + 
                                  "\n\r                       F1F1-BRAZILIAN-GP-F1F1" +
                                  "\n\r                    F1F                F1F   F1" +
                                  "\n\r                 F1F      F1F1F1    F1F  F1    F1" +
                                  "\n\r             START     F1F1   F1  F1F   F1F      F1 " +
                                  "\n\r           F1F        F1       F1F1   F1          F1" +
                                  "\n\r        F1F           F1F            F1           F1" +
                                  "\n\r     F1F                 F1F1F         F1F1F      F1" +
                                  "\n\r   F1F                        F1F1F1F       F1F1F1" +
                                  "\n\r     F1F                             F1F1" +
                                  "\n\r     F1                                 F1" +
                                  "\n\r     F1                                  F1" +
                                  "\n\r      F1                                F1" +
                                  "\n\r        F1F1F1F-71-LAPS-15-TURNS-F1F1F1F1\n");
                }
            }
        }
        public static void RedLights()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop - 21);
            Console.Write("\r      ·····");
            Task.Delay(1000).Wait();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\r      ·");
            Task.Delay(1000).Wait();
            Console.Write("\r      ··");
            Task.Delay(1000).Wait();
            Console.Write("\r      ···");
            Task.Delay(1000).Wait();
            Console.Write("\r      ····");
            Task.Delay(1000).Wait();
            Console.Write("\r      ·····");
            Task.Delay(1000).Wait();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\r      ·····");
            Task.Delay(1000).Wait();
            Console.CursorVisible = true;
        }
        public int MiniGameLap1()
        {
            int score;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Five");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Red ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Lights");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Press 'W' as soon as the red lights go out\nYour goal is 200ms or less");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\r        ·····");
            Task.Delay(1000).Wait();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\r        ·");
            Task.Delay(1000).Wait();
            Console.Write("\r        ··");
            Task.Delay(1000).Wait();
            Console.Write("\r        ···");
            Task.Delay(1000).Wait();
            Console.Write("\r        ····");
            Task.Delay(1000).Wait();
            Console.Write("\r        ·····");
            Task.Delay(1002).Wait();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\r        ·····");
            Console.ForegroundColor = ConsoleColor.Black;
            stopwatch.Start();
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed == ConsoleKey.W)
            {
                stopwatch.Stop();
            }
            Task.Delay(1000).Wait();
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.CursorVisible = true;
            if (stopwatch.ElapsedMilliseconds < 3 && keyPressed == ConsoleKey.W)
            {
                Console.WriteLine($"False Start, you've been penalised with a five second penalty");
                score = 500;
            }
            else if (stopwatch.ElapsedMilliseconds < 201 && keyPressed == ConsoleKey.W)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 5);
            }
            else if (stopwatch.ElapsedMilliseconds > 200 && keyPressed == ConsoleKey.W)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 2);
                if (score > 680) { score = 650; }
            }
            else
            {
                Console.WriteLine($"You pressed the wrong button, specifically '{keyPressed}'");
                score = 650;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press 'Enter' to continue");
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return score;
        }
        public int MiniGameDRS()
        {
            int score;
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();
            Console.ForegroundColor = ConsoleColor.White;
            int miniGameDRS = rnd.Next(3000, 9000);
            Console.Write("Turning On");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" DRS");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Press 'D' only when DRS turns green\nYour goal is 300ms or less");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\n        DRS");
            Console.ForegroundColor = ConsoleColor.Green;
            Task.Delay(miniGameDRS).Wait();
            Console.WriteLine("\r        DRS");
            Console.ForegroundColor = ConsoleColor.Black;
            stopwatch.Start();
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed == ConsoleKey.D)
            {
                stopwatch.Stop();
            }
            Task.Delay(800).Wait();
            Console.CursorVisible = true;
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            if (stopwatch.ElapsedMilliseconds < 3 && keyPressed == ConsoleKey.D)
            {
                Console.WriteLine($"'D' was pressed at a wrong time");
                score = 500;
            }
            else if (stopwatch.ElapsedMilliseconds < 301 && keyPressed == ConsoleKey.D)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 10);
            }
            else if (stopwatch.ElapsedMilliseconds > 300 && keyPressed == ConsoleKey.D)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 4);
            }
            else
            {
                Console.WriteLine($"You pressed the wrong button, specifically '{keyPressed}'");
                score =  Convert.ToInt32(stopwatch.ElapsedMilliseconds);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return score;
        }
        public int MiniGamePit()
        {
            Console.WriteLine("Box, box");
            Console.ReadLine();
            ConsoleKeyInfo key;
            Random rnd = new Random();
            int badPitRnd = rnd.Next(33);
            int miniGamePit;
            if (badPitRnd == 0)
            {
                miniGamePit = rnd.Next(4100, 12000);
            }
            else 
            {
                miniGamePit = rnd.Next(2000, 4100);
            }
            Stopwatch stopwatch = new Stopwatch();
            Console.CursorVisible = false;
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < miniGamePit)
            {
                if (stopwatch.Elapsed.Seconds < 2.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (stopwatch.Elapsed.Seconds < 3.5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (stopwatch.Elapsed.Seconds < 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (stopwatch.Elapsed.Seconds < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (stopwatch.Elapsed.Seconds < 11)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (stopwatch.Elapsed.Seconds < 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                Console.Write("Stop Time " + stopwatch.Elapsed.Seconds.ToString() + "." + stopwatch.Elapsed.Milliseconds);
                Console.Write('\r');
            }
            stopwatch.Stop();
            Console.CursorVisible = true;
            int score = Convert.ToInt32(stopwatch.ElapsedMilliseconds/45);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nPress 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return score;
        }
        public int MiniGameFL()
        {
            int score;
            int lives = 3;
            Stopwatch stopwatch = new Stopwatch();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Fastest Lap");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You have the chance to set the fastest lap\nPress the keys in the right order");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("♦ ♦ ♦");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" - You're allowed 3 mistakes, < > - These represent arrow keys");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r♦ ♦ ♦                                                                \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("< > < D < < > > > < > < < < < D <");
            Console.ForegroundColor = ConsoleColor.Magenta;
            stopwatch.Start();
            while (stopwatch.IsRunning)
            {
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if ( lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        { 
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r<");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.RightArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.RightArrow);
                if (lives == 0) { break; }
                Console.Write("\r< >");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.D) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.D);
                if (lives == 0) { break; }
                Console.Write("\r< > < D");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.RightArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.RightArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < >");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.RightArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.RightArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > >");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.RightArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.RightArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > >");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.RightArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.RightArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < >");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < > <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < > < <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < > < < <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < > < < < <");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.D) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.D);
                if (lives == 0) { break; }
                Console.Write("\r< > < D < < > > > < > < < < < D");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.LeftArrow) { lives -= 1; }
                    if (lives < 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        switch (lives)
                        {
                            case 2:
                                Console.WriteLine("\r♦ ♦  \n");
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\r♦    \n");
                                break;
                            case 0:
                                Console.WriteLine("\r     \n");
                                break;
                        }
                    }
                    if (lives == 0) { break; }
                } while (key.Key != ConsoleKey.LeftArrow);
                if (lives == 0) { break; }
                stopwatch.Stop();
                Console.WriteLine("\r< > < D < < > > > < > < < < < D <");
            }
            Console.CursorVisible = true;
            if (lives == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\nYou made a mistake");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds); ;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return 0;
        }
    }
}
