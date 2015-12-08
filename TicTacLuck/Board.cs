using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacLuck
{
    public class Board
    {
        public int Size { get; private set; }

        public Piece[] Cells { get; set; }

        public Board(int size)
        {
            this.Size = size;
            this.Cells = new Piece[this.Size * this.Size];
        }


        /// <summary>
        /// Add the piece to the board at the X and Y position from the piece 
        /// </summary>
        /// <param name="p">Piece</param>
        public void AddPiece(Piece p)
        {
            if (this.Cells[p.X*p.Y] == null)
                this.Cells[p.X*p.Y] = p;
        }

        public void ResetBoard()
        {
            this.Cells = new Piece[this.Size * this.Size];
        }
    }
}
