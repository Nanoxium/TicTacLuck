// TODO: Add file header
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public class Player
    {
        public string Name { get; set; }

        public PieceForm ChoosenForm { get; set; }

        public bool Turn { get; set; }

        public Player(string name, PieceForm f)
        {
            this.Name = name;
            this.ChoosenForm = f;
        }
    }
}
