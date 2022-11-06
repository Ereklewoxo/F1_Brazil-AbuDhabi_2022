using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace F1_Brazil_GP_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamList = new List<string> { "Mercedes", "Red Bull", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas" };
            var racerList = new List<string> { "Charles Leclerc", "Max Verstappen", "Carlos Sainz", "Sergio Perez", "Lewis Hamilton", "George Russell", "Fernando Alonso", "Lando Norris", "Esteban Ocon", "Valtteri Bottas", "Daniel Ricciardo", "Pierre Gasly", "Kevin Magnussen", "Nyck De Vries", "Yuki Tsunoda", "Mick Schumacher", "Zhou Guanyu", "Sebastian Vettel", "Alexander Albon", "Lance Stroll" };
            var racerListS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
            string userTeam = "Audi";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            F1Logo();
            Console.WriteLine("F1 Brazilian GP Game");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWhat's Your First Name?");
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
            Console.WriteLine("And Your Last Name?");
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
            string userNameS = userLastName;
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
            string replace;
            //teams
            for (int i = 0; i < 1; i++)
            {
                int writeTeams = 0;
                Console.WriteLine($"For which team do you wish to play {userName}?");
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
                switch (userTeam)
                {
                    case "1":
                    case "mercedes":
                    case "mersedes":
                        userTeam = teamList[0];
                        for (int j = 0; j < 1; j++)
                        {
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[4] = userName;
                                    racerListS[4] = userNameS;
                                    break;
                                case "2":
                                    racerList[5] = userName;
                                    racerListS[5] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
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
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[1] = userName;
                                    racerListS[1] = userNameS;
                                    break;
                                case "2":
                                    racerList[3] = userName;
                                    racerListS[3] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
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
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[0] = userName;
                                    racerListS[0] = userNameS;
                                    break;
                                case "2":
                                    racerList[2] = userName;
                                    racerListS[2] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write("Invalid input, type just the number");
                                    Console.ReadKey();
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
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[10] = userName;
                                    racerListS[10] = userNameS;
                                    break;
                                case "2":
                                    racerList[7] = userName;
                                    racerListS[7] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
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
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[8] = userName;
                                    racerListS[8] = userNameS;
                                    break;
                                case "2":
                                    racerList[6] = userName;
                                    racerListS[6] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
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
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[11] = userName;
                                    racerListS[11] = userNameS;
                                    break;
                                case "2":
                                    racerList[14] = userName;
                                    racerListS[14] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
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
                        for (int t = 0; t < 1; t++)
                        {
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[17] = userName;
                                    racerListS[17] = userNameS;
                                    break;
                                case "2":
                                    racerList[19] = userName;
                                    racerListS[19] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
                                    t--;
                                    break;
                            }
                        }
                        break;
                    case "8":
                    case "willliams":
                    case "wiliams":
                    case "wil":
                        userTeam = teamList[7];
                        for (int t = 0; t < 1; t++)
                        {
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[13] = userName;
                                    racerListS[13] = userNameS;
                                    break;
                                case "2":
                                    racerList[18] = userName;
                                    racerListS[18] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
                                    t--;
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
                        for (int t = 0; t < 1; t++)
                        {
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[9] = userName;
                                    racerListS[9] = userNameS;
                                    break;
                                case "2":
                                    racerList[16] = userName;
                                    racerListS[16] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
                                    t--;
                                    break;
                            }
                        } 
                        break;
                    case "0":
                    case "haas":
                    case "has":
                        userTeam = teamList[9];
                        for (int t = 0; t < 1; t++)
                        {
                            Console.Clear();
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
                            replace = Console.ReadLine();
                            switch (replace)
                            {
                                case "1":
                                    racerList[12] = userName;
                                    racerListS[12] = userNameS;
                                    break;
                                case "2":
                                    racerList[15] = userName;
                                    racerListS[15] = userNameS;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Invalid input, type just the number");
                                    Console.ReadKey();
                                    t--;
                                    break;
                            }
                        } 
                        break;
                    default:
                        i--;
                        Console.WriteLine($"There's no such team as {userTeam}, try again");
                        break;
                }
            } 
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
            var lineupS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
            Random rnd = new Random();
            do
            {
                int startRnd = rnd.Next(24);
                if (startRnd - 18 < 0)
                {
                    if (startRnd > 14)
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
                } while (pole == pos16 || pos2 == pos16 || pos3 == pos16 || pos4 == pos16 || pos5 == pos16 || pos6 == pos16 || pos7 == pos16 || pos8 == pos16 || pos9 == pos16 || pos10 == pos16 || pos11 == pos16 || pos12 == pos16 || pos13 == pos16 || pos14 == pos16 || pos15 == pos16 );
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
                } while (pole == pos18 || pos2 == pos18 || pos3 == pos18 || pos4 == pos18 || pos5 == pos18 || pos6 == pos18 || pos7 == pos18 || pos8 == pos18 || pos9 == pos18 || pos10 == pos18 || pos11 == pos18 || pos12 == pos18 || pos13 == pos18 || pos14 == pos18 || pos15 == pos18 || pos16 == pos18 || pos17 == pos18 );
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
                } while (pole == pos19 || pos2 == pos19 || pos3 == pos19 || pos4 == pos19 || pos5 == pos19 || pos6 == pos19 || pos7 == pos19 || pos8 == pos19 || pos9 == pos19 || pos10 == pos19 || pos11 == pos19 || pos12 == pos19 || pos13 == pos19 || pos14 == pos19 || pos15 == pos19 || pos16 == pos19 || pos17 == pos19 || pos18 == pos19 );
                do
                {
                    startRnd = rnd.Next(20);
                    pos20 = racerList[startRnd];
                    lineupS[19] = racerListS[startRnd];
                } while (pole == pos20 || pos2 == pos20 || pos3 == pos20 || pos4 == pos20 || pos5 == pos20 || pos6 == pos20 || pos7 == pos20 || pos8 == pos20 || pos9 == pos20 || pos10 == pos20 || pos11 == pos20 || pos12 == pos20 || pos13 == pos20 || pos14 == pos20 || pos15 == pos20 || pos16 == pos20 || pos17 == pos20 || pos18 == pos20 || pos19 == pos20);
            } while (pole == pos2);
            var lineup = new List<string> { pole, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20 };
            Console.WriteLine(lineup);
            int writeLineup;
            for (int min = 30; min < 60; min++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Date: Sun, Nov 13, 2022, 9:{min}PM");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("FORMULA 1 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sao Paulo Grand Prix\n\nThe Race is about to begin\nYou may: 1 - Check starting positions\n         2 - Check the circuit\n         3 - Read the tutorial\n         4 - Start the Race");
                var preRace = Console.ReadLine().ToLower();
                if (preRace == "1")
                {
                    Console.Clear();
                    writeLineup = 0;
                    foreach (string item in lineupS)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (lineupS[writeLineup] == userNameS)
                        {
                            Console.Write(writeLineup + 1 + $" - ");
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
                            Console.Write($"{lineupS[writeLineup]} ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(lineup[writeLineup]);
                        }
                        else
                        {
                            Console.Write(writeLineup + 1 + $" - {lineupS[writeLineup]} ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(lineup[writeLineup]);
                        }
                        writeLineup++;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadKey();
                }
                else if (preRace == "2")
                {
                    Console.Clear();
                    Map();
                }
                else if (preRace == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Placeholder");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadKey();
                }
                else if (preRace == "4")
                {
                    min = 60;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, type just the number");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Press 'Enter' to continue");
                    Console.ReadKey();
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
                Console.WriteLine($"/");
            }
            RedLights();
            Console.Clear();
            Console.Write("It's linghts out and away we go");
            Console.ReadKey();
        }
        public static void Map()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("" +
              "\n                        F1-BRAZILIAN-GP-F1F" +
              "\n                                          F1F" +
              "\n                                             F1" +
              "\n                                              F1" +
              "\n                                               F*" +
              "\n                                                F1" +
              "\n                                                F1" +
              "\n                                            1F1F");
            Console.SetCursorPosition(0, Console.CursorTop - 7);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("" +
              "\n\r                                     F1" +
              "\n\r                       F1F1F1    F1F1 F1" +
              "\n\r                    F1F1   F1  F1F   1F" +
              "\n\r                    F1      F1F1F   F1" +
              "\n\r                    F1F            F1" +
              "\n\r                       F1F1F         F1F1F" +
              "\n\r                           F1F1F1        F1F" +
              "\n\r                                 f1F1F1" +
              "\n\r                                      F1" +
              "\n\r                                       F1" +
              "\n\r                                      F1" +
              "\n\r                                  1F1F1");
            Console.SetCursorPosition(0, Console.CursorTop - 12);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("" +
              "\n\r                    F1F1" +
              "\n\r                F1F1");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("" +
              "\n\r            START" +
              "\n\r        F1F1" +
              "\n\r     F1F" +
              "\n\r  F1F" +
              "\n\r F*F" +
              "\n\r   F1F" +
              "\n\r   F1" +
              "\n\r   F1" +
              "\n\r    F1" +
              "\n\r      F1F1F1F-71-LAPS-15-TURNS-F1F\n");
            Console.SetCursorPosition(0, Console.CursorTop - 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\r         <<<");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n■ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Sector 1");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("   ■ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Sector 2");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("   ■ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Sector 3");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("DRS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("* Zones - 2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress 'Enter' to continue");
            var enter = Console.ReadKey();
        }
        public static void RedLights()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop - 21);
            Console.Write("\r      ·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\r      ·");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r      ··");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r      ···");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r      ····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.Write("\r      ·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\r      ·····");
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }
        public static void F1Logo()
        {
            Console.WriteLine("    ______________  __" +
                            "\n  /  ____________//  /       _______" +
                            "\n /  /  _________//  /       _\\=.o.=/_" +
                            "\n/__/__/         /__/       |_|_____|_|" +
                            "\n");
        }
    }
}
