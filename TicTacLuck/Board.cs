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

        public PieceForm Winner { get; set; }

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
                    this.Cells[x, y] = new Piece(x,y,PieceForm.Blank);
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
            CheckBoard(x, y, p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="p"></param>
        public void CheckBoard(int x, int y, Piece p)
        {
            this.MoveCount++;

            //check end conditions

            //check col
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Cells[x, i].Form != p.Form)
                    break;
                if (i == this.Size - 1)
                {
                    this.Winner = p.Form;
                }
            }

            //check row
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Cells[i, y].Form != p.Form)
                    break;
                if (i == this.Size - 1)
                {
                    this.Winner = p.Form;
                }
            }

            //check diagonal
            if (x == y)
            {
                //we're on a diagonal
                for (int i = 0; i < this.Size; i++)
                {
                    if (this.Cells[i, i].Form != p.Form)
                        break;
                    if (i == this.Size - 1)
                    {
                        this.Winner = p.Form;
                    }
                }
            }

            //check anti diagonal
            for (int i = 0; i < this.Size; i++)
            {
                if (Cells[i, (this.Size - 1) - i].Form != p.Form)
                    break;
                if (i == this.Size - 1)
                {
                    this.Winner = p.Form;
                }
            }

            //check draw
            if (MoveCount == (this.Size * this.Size - 1))
            {
                this.Winner = PieceForm.Blank;
            }
        }
        
        public void ResetBoard()
        {
            this.Cells = new Piece[this.Size, this.Size];
        }
    }
}
