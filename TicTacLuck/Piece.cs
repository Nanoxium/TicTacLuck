using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public enum Effect
    {
        None = 0,
    }

    public class Piece
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Piece(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
