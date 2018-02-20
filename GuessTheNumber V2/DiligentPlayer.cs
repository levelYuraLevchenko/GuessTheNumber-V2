using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class DiligentPlayer : Player
    {
        public static int Rand { get; set; }

        public DiligentPlayer(string name) : base(name) 
        {
            Rand = Game.MinValue - 1;
        }

        public override void DoMove()
        {
            Rand++;

                for (var i = 0; i < Game.EnteredNumber.Length; i++)
                {
                    if (Game.EnteredNumber[i] == Game.WinValue)
                    {
                        Game.Win = true;
                    }
                }

                Console.WriteLine(Name + " " + Rand);
                Game.AddEnterdNumberInArray(Rand);
                if (Rand == Game.WinValue)
                {
                    Console.WriteLine(Name + " WIN({0}) ", Rand);
                    Game.Win = true;
                }
        }
    }
}
