using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public enum GameMode
    {
        Standard = 0,
        Special = 1
    }

    public class Game
    {
        #region Fields
        private Player _player1;
        private Player _player2;
        private GameMode _mode;
        private Board _gameboard;
        #endregion

        #region Properties
        public Player Player1
        {
            get { return this._player1; }
            set { this._player1 = value; }
        }

        public Player Player2
        {
            get { return this._player2; }
            set { this._player2 = value; }
        }

        public Board GameBoard
        {
            get { return this._gameboard; }
            set { this._gameboard = value; }
        }

        #endregion

        #region contructors
        public Game(GameMode m) : this(m, "Joueur 1", "Joueur 2", PieceForm.X, PieceForm.O) { }

        public Game(GameMode m, string p1, string p2, PieceForm p1Form, PieceForm p2Form)
        {
            this._mode = m;
            this.Player1 = new Player(p2, p1Form);
            this.Player2 = new Player(p2, p2Form);
        }
        #endregion

        #region Methods

        public void InitGame()
        {
            int boardSize = (this._mode == GameMode.Standard) ? 3 : 5;
            this.GameBoard = new Board(boardSize);
        }

        public string GetWinner()
        {
            if (this.GameBoard.Winner != null)
            {
                if (this.Player1.ChoosenForm == this.GameBoard.Winner)
                    return this.Player1.Name;
                else if (this.Player2.ChoosenForm == this.GameBoard.Winner)
                    return this.Player2.Name;
                else
                    return "Match nul";
            }
            else
                return "";
        }
        #endregion
    }
}
