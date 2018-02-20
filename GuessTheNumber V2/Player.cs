using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber_V2
{
    class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public virtual void DoMove() { }
    }
}
