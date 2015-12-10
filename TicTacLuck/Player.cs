using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    class Player
    {
        public string Name { get; set; }

        public PieceForm ChoosenForm { get; set; }

        public Player(string name, PieceForm f)
        {
            this.Name = name;
            this.ChoosenForm = f;
        }
    }
}
