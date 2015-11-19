using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public class Board
    {
        /// <summary>
        /// Cells of the board
        /// </summary>
        public int[,] cells;

        /// <summary>
        /// Taille du plateau de jeu
        /// </summary>
        public int Size { get;}
        
        /// <summary>
        /// List of moves that were played
        /// </summary>
        public List<string> MoveList
        {
            get { return _moveList; }
            set { _moveList = value; }
        }
        private List<string> _moveList;
        
        /// <summary>
        /// Create a new board with a board size
        /// </summary>
        /// <param name="size">board size</param>
        public Board(int size)
        {
            Size = size;
            cells = new int[Size, Size];
        }
    }
}
