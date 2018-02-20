using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class DiligentCheater : Player
    {
        public DiligentCheater(string name) : base(name) { }

        public override void DoMove()
        {
            int Rand = Game.MinValue - 1;

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
