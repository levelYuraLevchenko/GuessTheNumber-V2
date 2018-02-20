using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class RandomSmartPlayer : Player
    {
        public static int[] LocalArray = new int[0];

        public RandomSmartPlayer(string name) : base(name) { }

        public override void DoMove()
        {
                int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);

                for (var i = 0; i < LocalArray.Length; i++)
                {
                        if (Rand == LocalArray[i])
                        {
                            Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);
                            i = -1;
                        }
                }

                for (var i = 0; i < Game.EnteredNumber.Length; i++)
                {
                    if (Game.EnteredNumber[i] == Game.WinValue)
                    {
                        Game.Win = true;
                    }
                }

                Console.WriteLine(Name + " " + Rand);
                AddEnterdNumberInLocalArray(Rand);
                Game.AddEnterdNumberInArray(Rand);
                if (Rand == Game.WinValue)
                {
                    Console.WriteLine(Name + " WIN({0}) ", Rand);
                    Game.Win = true;
                }
        }

        public static void AddEnterdNumberInLocalArray(int number)
        {
            int[] tmpArray = new int[LocalArray.Length + 1];
            for (var i = 0; i < LocalArray.Length; i++)
            {
                tmpArray[i] = LocalArray[i];
            }
            tmpArray[LocalArray.Length] = number;
            LocalArray = tmpArray;
        }
    }
}
