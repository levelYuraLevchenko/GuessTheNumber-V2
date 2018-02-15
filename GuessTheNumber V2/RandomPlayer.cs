using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    static class RandomPlayer
    {
        public static string Name = "RandomPlayer";
        public static bool Win { get; set; }

        public static void DoMove()
        {
            while(!Win)
            {
                Thread.Sleep(100);
                int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);

                for (var i = 0; i < Game.EnteredNumber.Length; i++)
                {
                    if (Game.EnteredNumber[i] == Game.WinValue)
                    {
                        Console.WriteLine(Name + " can not win, because there is already a winner!");
                        Win = true;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("RPl: " + Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Game.AddEnterdNumberInArray(Rand);
                if (Rand == Game.WinValue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Name + " WIN({0}) ", Rand);
                    Console.ForegroundColor = ConsoleColor.White;
                    Win = true;
                }
            }
        }
        
    }
}
