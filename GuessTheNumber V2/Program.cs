using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Game.SetValue();
            game.Step();
           
            //Player[] players = new Player[]
            //{
            //    new DiligentPlayer("DiligentPlayer"),
            //    new RandomPlayer("RandomPlayer"),
            //    new RandomSmartPlayer("RandomSmartPlayer"),
            //    new RandomCheater("RandomCheater"),
            //    new DiligentCheater("DiligentCheater")
            //};

            //while (!Game.Win)
            //{
            //    for (var i = 0; i < players.Length; i++)
            //    {
            //        new Thread(players[i].DoMove).Start();
            //    }
            //}
        }
    }
}
