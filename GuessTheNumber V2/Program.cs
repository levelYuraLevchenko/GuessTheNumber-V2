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
            Game.SetValue();

            Thread dp = new Thread(new ThreadStart(DiligentPlayer.DoMove));
            dp.Start();

            Thread rp = new Thread(new ThreadStart(RandomPlayer.DoMove));
            rp.Start();

            Thread rsp = new Thread(new ThreadStart(RandomSmartPlayer.DoMove));
            rsp.Start();

            Thread rch = new Thread(new ThreadStart(RandomCheater.DoMove));
            rch.Start();

            Thread dch = new Thread(new ThreadStart(DiligentCheater.DoMove));
            dch.Start();
        }
    }
}
