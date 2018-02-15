using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    static class DiligentPlayer
    {
        public static string Name = "DiligentPlayer";
        public static bool Win = false;

        public static void DoMove()
        {
            int Rand = Game.MinValue - 1;

            while (!Win)
            {
                Thread.Sleep(100);
                Rand++;

                for (var i = 0; i < Game.EnteredNumber.Length; i++)
                {
                    if (Game.EnteredNumber[i] == Game.WinValue)
                    {
                        Console.WriteLine(Name + " can not win, because there is already a winner!");
                        Win = true;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DPl: " + Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Game.AddEnterdNumberInArray(Rand);
                if (Rand == Game.WinValue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Name + " WIN({0}) ", Rand);
                    Console.ForegroundColor = ConsoleColor.White;
                    Win = true;
                }
                if (Rand > Game.MaxValue)
                    break;
            }
        }
    }
}
