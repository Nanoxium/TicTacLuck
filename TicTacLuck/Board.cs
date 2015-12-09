using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacLuck
{
    public class Board
    {
        public int Size { get; private set; }

        public Piece[,] Cells { get; set; }

        public PieceForm Winner { get; }

        public int MoveCount { get; set; }

        public Board(int size)
        {
            this.Size = size;
            this.Cells = new Piece[this.Size, this.Size];
            InitBoard();
        }

        public void InitBoard()
        {
            for (int x = 0; x < this.Size; x++)
            {
                for (int y = 0; y < this.Size; y++)
                {
                    this.Cells[x, y] = new Piece(PieceForm.Blank);
                }
            }
        }


        /// <summary>
        /// Add the piece to the board at the X and Y position from the piece 
        /// </summary>
        /// <param name="p">Piece</param>
        public void Move(int x, int y, Piece p)
        {
            if (this.Cells[x, y] == null)
                this.Cells[x, y] = p;
        }

        public void CheckBoard()
        {
            this.MoveCount++;

            //check end conditions

            //check col
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Cells[x, i] != s)
                    break;
                if (i == this.Size - 1)
                {
                    //report win for s
                }
            }

            //check row
            for (int i = 0; i < this.Size; i++)
            {
                if (Cells[i, y] != s)
                    break;
                if (i == n - 1)
                {
                    //report win for s
                }
            }

            //check diag
            if (x == y)
            {
                //we're on a diagonal
                for (int i = 0; i < this.Size; i++)
                {
                    if (Cells[i, i] != s)
                        break;
                    if (i == this.Size - 1)
                    {
                        //report win for s
                    }
                }
            }

            //check anti diag (thanks rampion)
            for (int i = 0; i < this.Size; i++)
            {
                if (Cells[i, (this.Size - 1) - i] != s)
                    break;
                if (i == this.Size - 1)
                {
                    //report win for s
                }
            }

            //check draw
            if (moveCount == (this.Size ^ 2 - 1))
            {
                //report draw
            }
        }

        public

        public void ResetBoard()
        {
            this.Cells = new Piece[this.Size, this.Size];
        }
    }
}
