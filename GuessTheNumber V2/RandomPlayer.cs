using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name) { }

        public override void DoMove()
        {
                int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);

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
