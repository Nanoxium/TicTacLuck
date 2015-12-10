using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public enum PieceEffect
    {
        None = 0,
    }

    public enum PieceForm
    {
        Blank,
        X,
        O
    }

    public class Piece
    {
        #region Properties
        public PieceForm Form { get; set; }
        public PieceEffect Effect { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Piece(int x, int y, PieceForm p) : this(x, y, p, PieceEffect.None) { }

        public Piece(int x, int y, PieceForm p, PieceEffect e)
        {
            this.Form = p;
            this.Effect = e;
            this.X = x;
            this.Y = y;
        }
        #endregion
    }
}
