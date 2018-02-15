using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    static class DiligentCheater
    {
        public static string Name = "DiligentCheater";
        public static bool Win { get; set; }

        public static void DoMove()
        {
            int Rand = Game.MinValue - 1;

            while (!Win)
            {
                Thread.Sleep(100);
                Rand++;

                for (var i = 0; i < Game.EnteredNumber.Length; i++)
                {
                    if(Game.EnteredNumber[i] != Game.WinValue)
                    {
                        if (Rand == Game.EnteredNumber[i])
                        {
                            Rand++;
                            i = -1;
                        }
                    }
                    else
                    {
                        Console.WriteLine(Name + " can not win, because there is already a winner!");
                        Win = true;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DCh: " + Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Game.AddEnterdNumberInArray(Rand);
                if (Rand == Game.WinValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Name + " WIN({0}) ", Rand);
                    Console.ForegroundColor = ConsoleColor.White;
                    Win = true;
                }
                if(Rand > Game.MaxValue)
                    break;
            }
        }
    }
}
