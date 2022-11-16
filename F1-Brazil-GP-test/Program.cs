﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Brazil_AbuDhabi_2022
{
    public class Display
    {
        public static void F1Logo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("     ______________  __" +
                            "\n   /  ____________//  /" +
                            "\n  /  /  _________//  /" +
                            "\n /__/__/         /__/" +
                            "\n\n|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BRAZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
        }
        public static void F1LogoAnimation()
        {
            Console.CursorVisible = false;
            Console.Write("" +
                "" +
                "\n" +
                "\n" +
                "\n" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "_" +
                "\n/" +
                "\n" +
                "\n" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "__" +
                "\n /" +
                "\n/" +
                "\n" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  " __" +
                "\n  /" +
                "\n /" +
                "\n/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("22");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "  __" +
                "\n/  /" +
                "\n  /" +
                "\n_/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "_  __" +
                "\n//  /" +
                "\n/  /" +
                "\n__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "__  __" +
                "\n_//  /" +
                "\n//  /" +
                "\n/__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "___  __" +
                "\n__//  /" +
                "\n_//  /" +
                "\n /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "____  __" +
                "\n___//  /" +
                "\n__//  /" +
                "\n  /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "_____  __" +
                "\n____//  /" +
                "\n___//  /" +
                "\n   /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "______  __" +
                "\n_____//  /" +
                "\n____//  /" +
                "\n    /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("HABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "_______  __" +
                "\n______//  /" +
                "\n_____//  /" +
                "\n     /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "________  __" +
                "\n_______//  /" +
                "\n______//  /" +
                "\n      /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "_________  __" +
                "\n________//  /" +
                "\n_______//  /" +
                "\n       /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("U DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "__________  __" +
                "\n_________//  /" +
                "\n________//  /" +
                "\n        /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "___________  __" +
                "\n__________//  /" +
                "\n_________//  /" +
                "\n         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "____________  __" +
                "\n___________//  /" +
                "\n _________//  /" +
                "\n/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "____________  __" +
                "\n____________//  /" +
                "\n  _________//  /" +
                "\n_/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("L/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "______________  __" +
                "\n ____________//  /" +
                "\n/  _________//  /" +
                "\n__/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("IL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  " ______________  __" +
                "\n  ____________//  /" +
                "\n /  _________//  /" +
                "\n/__/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "  ______________  __" +
                "\n/  ____________//  /" +
                "\n  /  _________//  /" +
                "\n_/__/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("AZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "   ______________  __" +
                "\n /  ____________//  /" +
                "\n/  /  _________//  /" +
                "\n__/__/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("RAZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write(    "" +
                  "    ______________  __" +
                "\n  /  ____________//  /" +
                "\n /  /  _________//  /" +
                "\n/__/__/         /__/" +
                "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BRAZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.SetCursorPosition(0, Console.CursorTop - 6);
            Task.Delay(15).Wait();
            Console.Write("" +
                  "     ______________  __" +
                "\n   /  ____________//  /" +
                "\n  /  /  _________//  /" +
                "\n /__/__/         /__/" +
                "\n\n|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BRAZIL/ABU DHABI 2022");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|");
            Console.CursorVisible = true;
        }

        public static void MapBrazil()
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nLength - 4.31KM");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("  Lap record");
                Console.ForegroundColor = ConsoleColor.White;
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
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
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
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
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
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
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
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
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
                    Console.Write("                       ____" +
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
                else if (keyPressed == ConsoleKey.Enter)
                { i++; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
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
        public static void MapAbuDhabi()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("" +
                "                              F1F1\n" +
                "                              F1 F1F1F1\n" +
                "                     ABU-DHABI       F1F1F1\n" +
                "                  F1F1         F1F1F1F    F1F1F1\n" +
                "               F1F1       F1F1F1    F1          F1F1F1\n" +
                "             F1F          F1        S1               F1F1F1\n" +
                "           F1F F1F1F1     F1        T1                    F1F1F1\n" +
                "        F1F F1F     F1    F1        A1                         F1F1F1\n" +
                "      F1F F1F       F1    F1        R1                              F1F1F1\n" +
                "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1\n" +
                "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                " F1F    F1                          F1           F1                  F1F1F1F1F1\n" +
                "F1F    F1F                           F1-58-LAPS-F1\n" +
                "  F1F1F1");
            for (int i = 0; i < 1;)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nLength - 5.28KM");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("  Lap record");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" - 1.26.103 M. Verstappen (2021)");
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
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
                    Console.Write("" +
                        "                              F1F1                                              \n" +
                        "                              F1 F1F1F1                                         \n" +
                        "                     ABU-DHABI       F1F1F1                                     \n" +
                        "                  F1F1         F1F1F1F    F1F1F1                                \n" +
                        "               F1F1       F1F1F1    F1          F1F1F1                          \n" +
                        "             F1F          F1        S1               F1F1F1                     \n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1                \n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1           \n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1      \n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 \n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1 \n" +
                        "F1F    F1F                           F1-58-LAPS-F1\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(0, Console.CursorTop - 8);
                    Console.Write("" +
                        "             F1F          F1        S1\r\n" +
                        "           F1F F1F1F1     F1        T1\r\n" +
                        "        F1F F1F     F1    F1        A1\r\n" +
                        "      F1F F1F       F1    F1        R1\r\n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1\r\n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1\r\n" +
                        " F1F    F1                          F1           F1                  F1F1F\r\n" +
                        "F1F    F1F                           F1-58-LAPS-F1\r\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 8);
                    Console.Write("" +
                        "             F1F          F1\r\n" +
                        "           F1F F1F1F1     F1\r\n" +
                        "        F1F F1F     F1    F1\r\n" +
                        "      F1F F1F       F1    F1\r\n" +
                        "    F1F  F1          F1F1F1\r\n" +
                        "   F1    F1\r\n" +
                        " F1F    F1\r\n" +
                        "F1F    F1F\r\n" +
                        "  F1F1F1\n");
                }
                else if (keyPressed == ConsoleKey.D2)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
                    Console.Write("" +
                        "                              F1F1                                              \n" +
                        "                              F1 F1F1F1                                         \n" +
                        "                     ABU-DHABI       F1F1F1                                     \n" +
                        "                  F1F1         F1F1F1F    F1F1F1                                \n" +
                        "               F1F1       F1F1F1    F1          F1F1F1                          \n" +
                        "             F1F          F1        S1               F1F1F1                     \n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1                \n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1           \n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1      \n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 \n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1 \n" +
                        "F1F    F1F                           F1-58-LAPS-F1\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(0, Console.CursorTop - 13);
                    Console.Write("" +
                        "                              F1F1\n" +
                        "                              F1 F1F1F1\n" +
                        "                     ABU-DHABI       F1F1F1\n" +
                        "                  F1F1         F1F1F1F    F1F1F1\n" +
                        "               F1F1       F1F1F1    F1          F1F1F1\n" +
                        "             F1F          F1        S1               F1F1F1\n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1\n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1\n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1\n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1\n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 8);
                    Console.Write("" +
                        "                  F1F1         F1F1F1F\n" +
                        "               F1F1       F1F1F1    F1\n" +
                        "             F1F          F1        S1\n" +
                        "           F1F F1F1F1     F1        T1\n" +
                        "        F1F F1F     F1    F1        A1\n" +
                        "      F1F F1F       F1    F1        R1\n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1\n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1\n" +
                        " F1F    F1                          F1           F1                  F1F1F");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(0, Console.CursorTop - 8);
                    Console.Write("" +
                        "                  F1F1\n" +
                        "               F1F1\n" +
                        "             F1F\n" +
                        "           F1F\n" +
                        "        F1F\n" +
                        "      F1F\n" +
                        "    F1F\n" +
                        "   F1\n\n\n\n");
                }
                else if (keyPressed == ConsoleKey.D3)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
                    Console.Write("" +
                        "                              F1F1                                              \n" +
                        "                              F1 F1F1F1                                         \n" +
                        "                     ABU-DHABI       F1F1F1                                     \n" +
                        "                  F1F1         F1F1F1F    F1F1F1                                \n" +
                        "               F1F1       F1F1F1    F1          F1F1F1                          \n" +
                        "             F1F          F1        S1               F1F1F1                     \n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1                \n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1           \n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1      \n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 \n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1 \n" +
                        "F1F    F1F                           F1-58-LAPS-F1\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(0, Console.CursorTop - 10);
                    Console.Write("" +
                        "                  F1F1         F1F1F1F\n" +
                        "               F1F1       F1F1F1    F1\n" +
                        "             F1F          F1\n" +
                        "           F1F F1F1F1     F1\n" +
                        "        F1F F1F     F1    F1\n" +
                        "      F1F F1F       F1    F1\n" +
                        "    F1F  F1          F1F1F1\n" +
                        "   F1    F1\n" +
                        " F1F    F1\n" +
                        "F1F    F1F\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 10);
                    Console.Write("" +
                        "                  F1F1\n" +
                        "               F1F1\n" +
                        "             F1F\n" +
                        "           F1F\n" +
                        "        F1F\n" +
                        "      F1F\n" +
                        "    F1F\n" +
                        "   F1\n\n\n\n");
                }
                else if (keyPressed == ConsoleKey.D || keyPressed == ConsoleKey.D4)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
                    Console.Write("" +
                        "                              F1F1                                              \n" +
                        "                              F1 F1F1F1                                         \n" +
                        "                     ABU-DHABI       F1F1F1                                     \n" +
                        "                  F1F1         F1F1F1F    F1F1F1                                \n" +
                        "               F1F1       F1F1F1    F1          F1F1F1                          \n" +
                        "             F1F          F1        S1               F1F1F1                     \n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1                \n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1           \n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1      \n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 \n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1 \n" +
                        "F1F    F1F                           F1-58-LAPS-F1\n" +
                        "  F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, Console.CursorTop - 13);
                    Console.Write("" +
                        "                              F1F1\\____\n" +
                        "                              F1 F1F1F1\\___\n" +
                        "                     ABU-DHABI       F1F1F1\\____\n" +
                        "                  F1F1         F1F1F1F    F1F1F1\\_____\n" +
                        "               F1F1       F1F1F1    F1          F1F1F1\\____\n" +
                        "             F1F          F1        S1               F1F1F1\\____\n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1\\____\n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1\\___");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 7);
                    Console.Write("" +
                        "                              F1F1\n" +
                        "                              F1 F1F1F1\n" +
                        "                     ABU-DHABI       F1F1F1\n" +
                        "                  F1F1         F1F1F1F    F1F1F1\n" +
                        "               F1F1       F1F1F1    F1          F1F1F1\n" +
                        "             F1F          F1        S1               F1F1F1\n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1\n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1\n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1\n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1\n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\r" +
                        " F1F    F1                          F1           F1                  F1F1");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r" +
                        " F1F    F1                          F1           F1                  F1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, Console.CursorTop - 9);
                    Console.Write("" +
                        "                  __/ABU-D\n" +
                        "               __/\n" +
                        "             _/\n" +
                        "            /\n" +
                        "        __/\n" +
                        "      _/\n" +
                        "    _/\n" +
                        "   /\n" +
                        " _/\n" +
                        "/");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 9);
                    Console.Write("" +
                        "                  __/ABU-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\r" +
                        "                  __/\n\n\n\n\n\n\n\n\n\n\n\n");
                }
                else if (keyPressed == ConsoleKey.Enter)
                { i++; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(0, Console.CursorTop - 17);
                    Console.Write("" +
                        "                              F1F1                                              \n" +
                        "                              F1 F1F1F1                                         \n" +
                        "                     ABU-DHABI       F1F1F1                                     \n" +
                        "                  F1F1         F1F1F1F    F1F1F1                                \n" +
                        "               F1F1       F1F1F1    F1          F1F1F1                          \n" +
                        "             F1F          F1        S1               F1F1F1                     \n" +
                        "           F1F F1F1F1     F1        T1                    F1F1F1                \n" +
                        "        F1F F1F     F1    F1        A1                         F1F1F1           \n" +
                        "      F1F F1F       F1    F1        R1                              F1F1F1      \n" +
                        "    F1F  F1          F1F1F1         T1              F1F1F1               F1F1F1 \n" +
                        "   F1    F1                         F1            F1F    F-16-TURNS-1         F1\n" +
                        " F1F    F1                          F1           F1                  F1F1F1F1F1 \n" +
                        "F1F    F1F                           F1-58-LAPS-F1\n" +
                        "  F1F1F1\n");
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            ConsoleKeyInfo key;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            var teamList = new List<string> { "Mercedes", "Red Bull", "Ferrari", "McLaren", "Alpine", "AlphaTauri", "Aston Martin", "Williams", "Alfa Romeo", "Haas" };
            var racerList = new List<string> { "Charles Leclerc", "Max Verstappen", "Carlos Sainz", "Sergio Perez", "Lewis Hamilton", "George Russell", "Fernando Alonso", "Lando Norris", "Esteban Ocon", "Valtteri Bottas", "Daniel Ricciardo", "Pierre Gasly", "Kevin Magnussen", "Nyck De Vries", "Yuki Tsunoda", "Mick Schumacher", "Zhou Guanyu", "Sebastian Vettel", "Alexander Albon", "Lance Stroll" };
            var racerListS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
            string userTeam = "Audi";
            Display.F1LogoAnimation();
            Console.ForegroundColor = ConsoleColor.White;
            var userNameFullAndShort = program.Names();
            string userName = userNameFullAndShort[0];
            string userNameS = userNameFullAndShort[1];
            if (racerListS.Contains(userNameS))
                userNameS = "YOU";
            Console.Clear();
            Console.Write("For ");
            //teams
            for (int i = 0; i < 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int writeTeams = 0;
                Console.Write($"which team do you wish to play ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{userName}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("?");
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
            Random rnd = new Random();
            bool abuDhabi = false;
            for (int x = 0; x < 2; x++)
            {
                var lineupS = new List<string> { "LEC", "VER", "SAI", "PER", "HAM", "RUS", "ALO", "NOR", "OCO", "BOT", "RIC", "GAS", "MAG", "DEV", "TSU", "MSC", "ZHO", "VET", "ALB", "STR" };
                string pole; string pos2; string pos3; string pos4; string pos5; string pos6; string pos7; string pos8; string pos9; string pos10; string pos11; string pos12; string pos13; string pos14; string pos15; string pos16; string pos17; string pos18; string pos19; string pos20;
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
                Console.Clear();
                int writeLineup;
                int rndWeather = rnd.Next(100);
                double weather;
                if (abuDhabi)
                {
                    if (rndWeather < 60)
                        weather = 1.1;
                    else if (rndWeather < 80)
                        weather = 1;
                    else if (rndWeather < 90)
                        weather = 1.7;
                    else if (rndWeather < 96)
                        weather = 4.5;
                    else
                        weather = 6.9;
                }
                else
                {
                    if (rndWeather < 30)
                        weather = 1.1;
                    else if (rndWeather < 60)
                        weather = 1;
                    else if (rndWeather < 80)
                        weather = 1.7;
                    else if (rndWeather < 93)
                        weather = 4.5;
                    else
                        weather = 6.9;
                }
                for (int min = 30; min < 60; min++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (abuDhabi)
                        Console.WriteLine($"Date: Sun, Nov 20, 2022, 4:{min}PM");
                    else
                        Console.WriteLine($"Date: Sun, Nov 13, 2022, 9:{min}PM");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("FORMULA 1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (abuDhabi)
                        Console.Write("Abu Dhabi");
                    else
                        Console.Write("Sao Paulo");
                    Console.WriteLine(" Grand Prix\n\nThe Race is about to begin\nYou may: 1 - Check starting positions" +
                      "\n         2 - Check the circuit\n         3 - Weather forcast\n         4 - Start the Race");
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
                        if (abuDhabi)
                            Display.MapAbuDhabi();
                        else
                            Display.MapBrazil();
                        Console.Clear();
                    }
                    else if (preRace == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (rndWeather < 30)
                        {
                            Console.WriteLine("\n   \\_|_/      It's sunny\n __/   \\__\n   \\___/\n   / | \\");
                        }
                        else if (rndWeather < 60)
                        {
                            Console.WriteLine("\n     .--.      It's cloudy\n  .-(    ).\n (___.__)__)");
                        }
                        else if (rndWeather < 80)
                        {
                            Console.WriteLine("\n     .--.      It's raining\n  .-(    ).    Intensity: 1\n (___.__)__)\n   |  |  |");
                        }
                        else if (rndWeather < 93)
                        {
                            Console.WriteLine("\n     .--.      It's raining\n  .-(    ).    Intensity: 2\n (___.__)__)\n  | | | | |");
                        }
                        else
                        {
                            Console.WriteLine("\n     .--.      It's raining\n  .-(    ).    Intensity: 3\n (___.__)__)\n  |||||||||");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("\nPress 'Enter' to continue");
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
                Display.RedLights();
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
                bool flPlayed = false;
                int flHolder = 100;
                bool outTextShown = false;
                bool userGotFL = false;
                double randomDNF;
                string userShort = userNameS;
                var raceLineupS = lineupS;
                for (int race = 0; race < 8; race++)
                {
                    Console.Clear();
                    int score = 0;
                    if (USER < 1000)
                    {
                        random = rnd.Next(3);
                        if (abuDhabi)
                            if (race == 7)
                                Console.WriteLine($"LAP 58/58");
                            else
                                Console.WriteLine($"LAP {lapCount}/58");
                        else
                            Console.WriteLine($"LAP {lapCount}/71");
                        Console.Write($"Challenge {challengeCount} - ");
                        if (race == 0)
                        {
                            score = program.MiniGameLap1();
                        }
                        else if (random == 1 && USERp != 0
                            )
                        {
                            score = program.MiniGameDRS();
                        }
                        else if (random == 0 && pitCount < 2 && race > 2 && race < 7)
                        {
                            pitCount++;
                            score = program.MiniGamePit();
                        }
                        else if (random == 2 && flPlayed == false)
                        {
                            score = program.MiniGameFL();
                            flPlayed = true;
                            if (score <= 10) { userGotFL = true; flHolder = 100; }
                        }
                        else
                        {
                            program.MiniGameGear();
                            score = program.MiniGameGear1();
                        }
                    }
                    challengeCount++;
                    Console.Clear();
                    for (int i = 0; i < 1;)
                    {
                        for (int j = 0; j < raceLineupS.Count; j++)
                        {
                            if (raceLineupS[j] == "VER")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 27, 27 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(27, 27 + (VERp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.002)
                                {
                                    random = (9 - race) * 1000 + 1;
                                }
                                VER = random;
                            }
                            else if (raceLineupS[j] == "LEC")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 33, 33 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(33, 33 + (LECp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.003)
                                {
                                    random = (9 - race) * 1000 + 2;
                                }
                                LEC = random;
                            }
                            else if (raceLineupS[j] == "HAM")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 46, 46 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(46, 46 + (HAMp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.001)
                                {
                                    random = (9 - race) * 1000 + 3;
                                }
                                HAM = random;
                            }
                            else if (raceLineupS[j] == "RUS")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 45, 45 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(45, 45 + (RUSp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.001)
                                {
                                    random = (9 - race) * 1000 + 4;
                                }
                                RUS = random;
                            }
                            else if (raceLineupS[j] == "PER")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 38, 38 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(38, 38 + (PERp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.003)
                                {
                                    random = (9 - race) * 1000 + 5;
                                }
                                PER = random;
                            }
                            else if (raceLineupS[j] == "SAI")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 35, 35 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(35, 35 + (SAIp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.005)
                                {
                                    random = (9 - race) * 1000 + 6;
                                }
                                SAI = random;
                            }
                            else if (raceLineupS[j] == "NOR")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 78, 78 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(78, 78 + (NORp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.001)
                                {
                                    random = (9 - race) * 1000 + 7;
                                }
                                NOR = random;
                            }
                            else if (raceLineupS[j] == "RIC")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 117, 117 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(117, 117 + (RICp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.002)
                                {
                                    random = (9 - race) * 1000 + 8;
                                }
                                RIC = random;
                            }
                            else if (raceLineupS[j] == "OCO")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 82, 82 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(82, 82 + (OCOp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.002)
                                {
                                    random = (9 - race) * 1000 + 9;
                                }
                                OCO = random;
                            }
                            else if (raceLineupS[j] == "ALO")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 88, 88 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(88, 88 + (ALOp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.005)
                                {
                                    random = (9 - race) * 1000 + 10;
                                }
                                ALO = random;
                            }
                            else if (raceLineupS[j] == "GAS")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 112, 112 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(112, 112 + (GASp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.005)
                                {
                                    random = (9 - race) * 1000 + 11;
                                }
                                GAS = random;
                            }
                            else if (raceLineupS[j] == "TSU")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 128, 128 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(128, 128 + (TSUp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.007)
                                {
                                    random = (9 - race) * 1000 + 12;
                                }
                                TSU = random;
                            }
                            else if (raceLineupS[j] == "STR")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 117, 117 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(117, 117 + (STRp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.003)
                                {
                                    random = (9 - race) * 1000 + 13;
                                }
                                STR = random;
                            }
                            else if (raceLineupS[j] == "VET")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 105, 105 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(105, 105 + (VETp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.004)
                                {
                                    random = (9 - race) * 1000 + 14;
                                }
                                VET = random;
                            }
                            else if (raceLineupS[j] == "ALB")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 126, 126 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(126, 126 + (ALBp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.004)
                                {
                                    random = (9 - race) * 1000 + 15;
                                }
                                ALB = random;
                            }
                            else if (raceLineupS[j] == "DEV")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 100, 100 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(100, 100 + (DEVp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.004)
                                {
                                    random = (9 - race) * 1000 + 16;
                                }
                                DEV = random;
                            }
                            else if (raceLineupS[j] == "BOT")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 102, 102 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(102, 102 + (BOTp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.005)
                                {
                                    random = (9 - race) * 1000 + 17;
                                }
                                BOT = random;
                            }
                            else if (raceLineupS[j] == "ZHO")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 130, 130 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(130, 130 + (ZHOp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.006)
                                {
                                    random = (9 - race) * 1000 + 18;
                                }
                                ZHO = random;
                            }
                            else if (raceLineupS[j] == "MAG")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 129, 129 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(129, 129 + (MAGp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.004)
                                {
                                    random = (9 - race) * 1000 + 19;
                                }
                                MAG = random;
                            }
                            else if (raceLineupS[j] == "MSC")
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(j + 135, 135 + (j + 1) * 10); }
                                else
                                { random = rnd.Next(135, 135 + (MSCp + 1) * 15); }
                                randomDNF = rnd.NextDouble() * weather;
                                if (randomDNF < 0.002)
                                {
                                    random = (9 - race) * 1000 + 20;
                                }
                                MSC = random;
                            }
                            //user input here
                            else if (raceLineupS[j] == userNameS)
                            {
                                if (lapCount == 1)
                                { random = rnd.Next(score, score + (j + 1) * 15); }
                                else
                                { random = rnd.Next(score, score + (USERp + 1) * 15); }
                                if (score > 1001)
                                {
                                    random = (9 - race) * 1000;
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
                    if (USER > 1000 && outTextShown == false)
                    {
                        outTextShown = true;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You are out of the race");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Press 'Enter' to continue");
                        do
                        {
                            key = Console.ReadKey(true);
                        } while (key.Key != ConsoleKey.Enter);
                        Console.Clear();
                    }
                    lap.Sort();
                    lap.RemoveAt(0);
                    for (int i = 0; i < lap.Count; i++)
                    {
                        if (lap[i] > 1000)
                        {
                            if (lap[i] == VER)
                            {
                                raceLineupS.Remove("VER");
                            }
                            else if (lap[i] == LEC)
                            {
                                raceLineupS.Remove("LEC");
                            }
                            else if (lap[i] == HAM)
                            {
                                raceLineupS.Remove("HAM");
                            }
                            else if (lap[i] == RUS)
                            {
                                raceLineupS.Remove("RUS");
                            }
                            else if (lap[i] == PER)
                            {
                                raceLineupS.Remove("PER");
                            }
                            else if (lap[i] == SAI)
                            {
                                raceLineupS.Remove("SAI");
                            }
                            else if (lap[i] == NOR)
                            {
                                raceLineupS.Remove("NOR");
                            }
                            else if (lap[i] == RIC)
                            {
                                raceLineupS.Remove("RIC");
                            }
                            else if (lap[i] == OCO)
                            {
                                raceLineupS.Remove("OCO");
                            }
                            else if (lap[i] == ALO)
                            {
                                raceLineupS.Remove("ALO");
                            }
                            else if (lap[i] == GAS)
                            {
                                raceLineupS.Remove("GAS");
                            }
                            else if (lap[i] == TSU)
                            {
                                raceLineupS.Remove("TSU");
                            }
                            else if (lap[i] == STR)
                            {
                                raceLineupS.Remove("STR");
                            }
                            else if (lap[i] == VET)
                            {
                                raceLineupS.Remove("VET");
                            }
                            else if (lap[i] == ALB)
                            {
                                raceLineupS.Remove("ALB");
                            }
                            else if (lap[i] == DEV)
                            {
                                raceLineupS.Remove("DEV");
                            }
                            else if (lap[i] == BOT)
                            {
                                raceLineupS.Remove("BOT");
                            }
                            else if (lap[i] == ZHO)
                            {
                                raceLineupS.Remove("ZHO");
                            }
                            else if (lap[i] == MAG)
                            {
                                raceLineupS.Remove("MAG");
                            }
                            else if (lap[i] == MSC)
                            {
                                raceLineupS.Remove("MSC");
                            }
                            else if (lap[i] == USER)
                            {
                                raceLineupS.Remove(userNameS);
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
                    random = rnd.Next(92);
                    for (int i = 0; i < lap.Count; i++)
                    {
                        if (lap[i] < 1001 && userGotFL == false)
                        {
                            if (lap[i] == VER && random < 20)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == LEC && 19 < random && random < 32)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == HAM && 31 < random && random < 40)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == RUS && 39 < random && random < 52)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == PER && 51 < random && random < 64)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == SAI && 63 < random && random < 72)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == NOR && 71 < random && random < 76)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == RIC && random == 76)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == OCO && random == 77)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == ALO && random == 78)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == GAS && random == 79)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == TSU && random == 80)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == STR && random == 81)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == VET && random == 82)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == ALB && random == 83)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == DEV && random == 84)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == BOT && random == 85)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == ZHO && 85 < random && random < 90)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == MAG && random == 90)
                            {
                                flHolder = i;
                            }
                            else if (lap[i] == MSC && random == 91)
                            {
                                flHolder = i;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (abuDhabi)
                    {
                        if (race == 7)
                            Console.WriteLine("▀▄▀▄▀▄▀▄");
                        else
                            Console.WriteLine($"LAP {lapCount}/58");
                        lapCount += 8;
                    }
                    else
                    {
                        if (race == 7)
                            Console.WriteLine("▀▄▀▄▀▄▀▄");
                        else
                            Console.WriteLine($"LAP {lapCount}/71");
                        lapCount += 10;
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        if (i < 10)
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
                        { Console.Write(" VER"); }
                        else if (lap[i] == PER)
                        { Console.Write(" PER"); }
                        else if (lap[i] == SAI)
                        { Console.Write(" SAI"); }
                        else if (lap[i] == LEC)
                        { Console.Write(" LEC"); }
                        else if (lap[i] == RUS)
                        { Console.Write(" RUS"); }
                        else if (lap[i] == HAM)
                        { Console.Write(" HAM"); }
                        else if (lap[i] == NOR)
                        { Console.Write(" NOR"); }
                        else if (lap[i] == RIC)
                        { Console.Write(" RIC"); }
                        else if (lap[i] == OCO)
                        { Console.Write(" OCO"); }
                        else if (lap[i] == ALO)
                        { Console.Write(" ALO"); }
                        else if (lap[i] == GAS)
                        { Console.Write(" GAS"); }
                        else if (lap[i] == TSU)
                        { Console.Write(" TSU"); }
                        else if (lap[i] == STR)
                        { Console.Write(" STR"); }
                        else if (lap[i] == VET)
                        { Console.Write(" VET"); }
                        else if (lap[i] == ALB)
                        { Console.Write(" ALB"); }
                        else if (lap[i] == DEV)
                        { Console.Write(" DEV"); }
                        else if (lap[i] == BOT)
                        { Console.Write(" BOT"); }
                        else if (lap[i] == ZHO)
                        { Console.Write(" ZHO"); }
                        else if (lap[i] == MAG)
                        { Console.Write(" MAG"); }
                        else if (lap[i] == MSC)
                        { Console.Write(" MSC"); }
                        else if (lap[i] == USER)
                        {
                            Console.Write($" {userShort}");
                            if (userGotFL)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("♦");
                            }
                        }
                        if (i == flHolder)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("♦");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Press 'Enter' to continue");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Clear();
                if (USER > 1000)
                {
                    Console.Write("That concludes the race\n\nYou");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" DNF ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("and got " + (USERp + 1));
                    switch (USERp)
                    {
                        case 0:
                            Console.WriteLine("st position, what?");
                            break;
                        case 1:
                            Console.WriteLine("nd position, lucky, lucky");
                            break;
                        case 2:
                            Console.WriteLine("rd position, good job?");
                            break;
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            Console.WriteLine("th position, better luck next time");
                            break;
                    }
                }
                else
                {
                    Console.Write("That concludes the race\n\nYou finished " + (USERp + 1));
                    switch (USERp)
                    {
                        case 0:
                            Console.WriteLine("st, congratulations!");
                            break;
                        case 1:
                            Console.WriteLine("nd, good race");
                            break;
                        case 2:
                            Console.WriteLine("rd, nice job");
                            break;
                        case 3:
                            Console.WriteLine("th, close");
                            break;
                        case 4:
                            Console.WriteLine("th, nice");
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("th, not bad");
                            break;
                        case 9:
                            Console.WriteLine("th, at least it's a point");
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                            Console.WriteLine("th, disappointing");
                            break;
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            Console.WriteLine("th, bad");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Press 'Enter' to continue");
                do
                {
                    key = Console.ReadKey(true);
                } while (key.Key != ConsoleKey.Enter);
                Console.Clear();
                var points = new List<int> { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int flPoint;
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 20; i++)
                {
                    flPoint = 0;
                    if (i < 10)
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
                    { Console.Write(" VER"); }
                    else if (lap[i] == PER)
                    { Console.Write(" PER"); }
                    else if (lap[i] == SAI)
                    { Console.Write(" SAI"); }
                    else if (lap[i] == LEC)
                    { Console.Write(" LEC"); }
                    else if (lap[i] == RUS)
                    { Console.Write(" RUS"); }
                    else if (lap[i] == HAM)
                    { Console.Write(" HAM"); }
                    else if (lap[i] == NOR)
                    { Console.Write(" NOR"); }
                    else if (lap[i] == RIC)
                    { Console.Write(" RIC"); }
                    else if (lap[i] == OCO)
                    { Console.Write(" OCO"); }
                    else if (lap[i] == ALO)
                    { Console.Write(" ALO"); }
                    else if (lap[i] == GAS)
                    { Console.Write(" GAS"); }
                    else if (lap[i] == TSU)
                    { Console.Write(" TSU"); }
                    else if (lap[i] == STR)
                    { Console.Write(" STR"); }
                    else if (lap[i] == VET)
                    { Console.Write(" VET"); }
                    else if (lap[i] == ALB)
                    { Console.Write(" ALB"); }
                    else if (lap[i] == DEV)
                    { Console.Write(" DEV"); }
                    else if (lap[i] == BOT)
                    { Console.Write(" BOT"); }
                    else if (lap[i] == ZHO)
                    { Console.Write(" ZHO"); }
                    else if (lap[i] == MAG)
                    { Console.Write(" MAG"); }
                    else if (lap[i] == MSC)
                    { Console.Write(" MSC"); }
                    else if (lap[i] == USER)
                    {
                        Console.Write($" {userShort}");
                        if (userGotFL)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("♦");
                            if (lap[i] < 1001)
                            { flPoint = 1; }
                        }
                    }
                    if (i == flHolder)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("♦");
                        if (lap[i] < 1001)
                        { flPoint = 1; }
                    }
                    if (lap[i] > 1001)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (lap[i] == USER && userGotFL)
                            Console.Write(" DNF");
                        else
                            Console.Write("  DNF");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (i < 10)
                    {
                        if (i == flHolder)
                            Console.Write(" ");
                        else if (lap[i] == USER && userGotFL)
                            Console.Write(" ");
                        else
                            Console.Write("  ");
                        Console.Write((points[i] + flPoint) + "Pts");
                    }
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
                    if (i < 3)
                    {
                        Console.Write("_______\n" +
                                        "              _\\═.o.═/_\n" +
                                        "             |_|_____|_|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (abuDhabi == false)
                {
                    Console.Write("Press 'Enter' to proceed to Abu Dhabi Grand Prix");
                    do
                    {
                        key = Console.ReadKey(true);
                    } while (key.Key != ConsoleKey.Enter);
                    abuDhabi = true;
                }
            }
            Console.Write("Press 'Enter' to exit");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }
        public List<string> Names()
        {
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
            Console.Write("And your last name?    \n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{userFirstName} ");
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.CursorVisible = false;
            Console.Write($"{userFirstName} {userLastName}");
            Console.ForegroundColor = ConsoleColor.White;
            var names = new List<string> { userName, userNameS };
            return names;
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
            int miniGameDRS = rnd.Next(2860, 8650);
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
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 11);
            }
            else if (stopwatch.ElapsedMilliseconds < 401 && keyPressed == ConsoleKey.D)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 6);
            }
            else if (stopwatch.ElapsedMilliseconds > 400 && keyPressed == ConsoleKey.D)
            {
                Console.Write("Your time was ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 3);
            }
            else
            {
                Console.WriteLine($"You pressed the wrong button, specifically '{keyPressed}'");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
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
            int score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 35);
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
            if (stopwatch.IsRunning) { stopwatch.Stop(); }
            Console.CursorVisible = true;
            if (lives == 0)
            {
                Console.WriteLine("\n\nYou got too cocky");
                score = Convert.ToInt32(stopwatch.Elapsed.Milliseconds * 2.5);
            }
            else if (stopwatch.ElapsedMilliseconds < 2540)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (stopwatch.Elapsed.Seconds < 2)
                { Console.WriteLine("\n1.0" + (10 - (2 - stopwatch.Elapsed.Seconds)) + "." + stopwatch.Elapsed.Milliseconds); }
                else
                { Console.WriteLine("\n1.1" + (stopwatch.Elapsed.Seconds - 2) + "." + stopwatch.Elapsed.Milliseconds); }
                Console.WriteLine("YOU JUST SET A NEW LAP RECORD");
                score = 1;
            }

            else if (stopwatch.ElapsedMilliseconds < 3000)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1.1" + (stopwatch.Elapsed.Seconds - 2) + "." + stopwatch.Elapsed.Milliseconds);
                Console.WriteLine("You got the fastest lap");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 250);
            }
            else if (stopwatch.Elapsed.Seconds < 12)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1.1" + (stopwatch.Elapsed.Seconds - 2) + "." + stopwatch.Elapsed.Milliseconds);
                Console.WriteLine("Not good");
                score = Convert.ToInt32(stopwatch.ElapsedMilliseconds / 200);
            }
            else if (stopwatch.Elapsed.Seconds < 62)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n1." + (stopwatch.Elapsed.Seconds - 2) + "." + stopwatch.Elapsed.Milliseconds);
                Console.WriteLine("Thats bad, real bad");
                score = 680;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nYou fell asleep");
                score = 1000;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return score;
        }
        public void MiniGameGear()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Gearing Up");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Gear up to 8th as fast as possible\nPress 'Space' when the pointer is in the middle");
            Console.WriteLine("\n\n" +
                "  1   2   3   4   5   6   7   8");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n" +
                "  █   █   █   █   █   █   █   █\n" +
                "  █   █   █   █   █   █   █   █\n" +
                "══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣\n" +
                "  █   █   █   █   █   █   █   █\n" +
                "  █   █   █   █   █   █   █   █");
            Console.SetCursorPosition(0, Console.CursorTop - 10);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Gear up to 8th as fast as possible\nPress 'Space' when the pointer is in the middle");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.CursorVisible = false;
        }
        public int MiniGameGear1()
        {
            //idk how cars work btw
            int score = 0;
            int gear = 0;
            Stopwatch stopwatch = new Stopwatch();
            bool rightTimeing = false;
            stopwatch.Start();
            //gear 1
            while (!Console.KeyAvailable)
            {
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █\n" +
                                  "══╬═══\n" +
                                  "  █\n" +
                                  "  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("══╬═══\n" +
                                  "  █\n" +
                                  "  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █\n" +
                                  "  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █\n" +
                                  "  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █\n" +
                                  "  █\n" +
                                  "══╬═══");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █\n" +
                                  "  █\n" +
                                  "══╬═══\n" +
                                  "  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █\n" +
                                  "  █\n" +
                                  "══╬═══");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █\n" +
                                  "  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █\n" +
                                  "  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("══╬═══\n" +
                                  "  █\n" +
                                  "  █");
                Task.Delay(170).Wait();
                if (!Console.KeyAvailable == false) { gear = 1; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █\n" +
                                  "══╬═══\n" +
                                  "  █\n" +
                                  "  █");
            }
            //gear 2
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █\n  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █\n  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █\n  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █\n  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █\n  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █\n  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █\n  █   █");
                Task.Delay(160).Wait();
                if (!Console.KeyAvailable == false) { gear = 2; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █\n  █   █");
                rightTimeing = true;
            }
            //gear 3
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █\n  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █\n  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █\n  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █\n  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █\n  █   █   █");
                Task.Delay(150).Wait();
                if (!Console.KeyAvailable == false) { gear = 3; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █\n  █   █   █");
                rightTimeing = true;
            }
            //gear 4
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █\n  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █\n  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █\n  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █\n  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █\n  █   █   █   █");
                Task.Delay(140).Wait();
                if (!Console.KeyAvailable == false) { gear = 4; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █\n  █   █   █   █");
                rightTimeing = true;
            }
            //gear 5
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █\n  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █\n  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █\n  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █\n  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █\n  █   █   █   █   █");
                Task.Delay(130).Wait();
                if (!Console.KeyAvailable == false) { gear = 5; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █\n  █   █   █   █   █");
                rightTimeing = true;
            }
            //gear 6
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █\n  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █\n  █   █   █   █   █   █");
                Task.Delay(120).Wait();
                if (!Console.KeyAvailable == false) { gear = 6; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █\n  █   █   █   █   █   █");
                rightTimeing = true;
            }
            //gear 7
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╬\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬═══╬");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █\n  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Task.Delay(110).Wait();
                if (!Console.KeyAvailable == false) { gear = 7; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╬\n  █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                rightTimeing = true;
            }
            //gear 8
            while (!Console.KeyAvailable && rightTimeing == true)
            {
                rightTimeing = false;
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╣\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("╣\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { rightTimeing = true; Console.ReadKey(); break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   █\n══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                Task.Delay(100).Wait();
                if (!Console.KeyAvailable == false) { gear = 8; break; }
                Console.SetCursorPosition(0, Console.CursorTop - 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   █");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("  █   █   █   █   █   █   █   █");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("══╬═══╬═══╬═══╬═══╬═══╬═══╬═══");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╣\n  █   █   █   █   █   █   █   █\n  █   █   █   █   █   █   █   █");
                rightTimeing = true;
            }
            stopwatch.Stop();
            Console.CursorVisible = true;
            if (rightTimeing == true)
            {
                if (stopwatch.Elapsed.Seconds < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nPerfect acceleration, Time - {stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds}");
                    score = 6;
                }
                else if (stopwatch.Elapsed.Seconds < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"\nGood acceleration, Time - {stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds}");
                    score = 15;
                }
                else if (stopwatch.Elapsed.Seconds < 13)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nNormal acceleration, Time - {stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds}");
                    score = 35;
                }
                else if (stopwatch.Elapsed.Seconds < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nBad acceleration, Time - {stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds}");
                    score = 80;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nSnale pace, Time - {stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds}");
                    score = 200;
                }
            }
            else
            {
                Console.Write($"\nYou got to gear {gear - 1} - ");
                switch (gear)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sucky");
                        score = 1000;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("super bad");
                        score = 950;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("very bad");
                        score = 900;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("bad");
                        score = 200;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("mid bad");
                        score = 200;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("whatever");
                        score = 200;
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("oke");
                        score = 100;
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("eh");
                        score = 100;
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ConsoleKeyInfo key;
            Console.Write("Press 'Enter' to continue");
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
            return score;
        }
    }
}
