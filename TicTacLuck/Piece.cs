using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public enum PieceEffect
    {
        None,
        ChangeForm,
        AddPiece,
        RemovePiece
    }

    public abstract class Piece
    {
        /// <summary>
        /// X position on the grid
        /// </summary>
        protected int PosX { get; set; }

        /// <summary>
        /// Y position on the grid
        /// </summary>
        protected int PosY { get; set; }

        /// <summary>
        /// If it has an effect or not
        /// </summary>
        protected PieceEffect Effect = PieceEffect.None;

        public Piece(int x, int y) : this(x, y, PieceEffect.None)
        {
        }

        /// <summary>
        /// Create a piece at a specific position
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="effect"></param>
        protected Piece(int x, int y, PieceEffect effect)
        {
            PosX = x;
            PosY = y;
            Effect = effect;
        }
    }
}
