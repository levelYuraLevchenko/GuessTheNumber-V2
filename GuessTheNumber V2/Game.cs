using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class Game
    {
        static object locker = new object();

        public static int[] EnteredNumber = new int[0];
        public static int MinValue { get; set; }
        public static int MaxValue { get; set; }
        public static int WinValue { get; set; }
        public static bool Win { get; set; }

        public static Random rand = new Random();

        public static void SetValue()
        {
            MinValue = int.Parse(Console.ReadLine());
            MaxValue = int.Parse(Console.ReadLine());
            WinValue = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Range: from {0} to {1}, winValue = {2}", MinValue, MaxValue, WinValue);
            Console.WriteLine();
        }

        public static void AddEnterdNumberInArray(int number)
        {
            lock (locker)
            {
                int[] tmpArray = new int[EnteredNumber.Length + 1];
                for (var i = 0; i < EnteredNumber.Length; i++)
                {
                    tmpArray[i] = EnteredNumber[i];
                }
                tmpArray[EnteredNumber.Length] = number;
                EnteredNumber = tmpArray;
            }
        }

             Player[] players = new Player[]
             {
                new DiligentPlayer("DiligentPlayer"),
                new RandomPlayer("RandomPlayer"),
                new RandomSmartPlayer("RandomSmartPlayer"),
                new RandomCheater("RandomCheater"),
                new DiligentCheater("DiligentCheater")
             };


        public void Step()
        {
            while (!Win)
            {
                for (var i = 0; i < players.Length; i++)
                {
                    new Thread(players[i].DoMove).Start();
                }
            }
        }
    }
}
