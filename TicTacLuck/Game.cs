// TODO: Add file header
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacLuck.Interfaces;

namespace TicTacLuck
{
    public enum GameMode
    {
        Standard = 0,
        Special = 1
    }

    public class Game : ISubject
    {
        #region Fields

        List<Player> _players;
        private GameMode _mode;
        private Board _gameboard;
        #endregion

        #region PropertiesW

        public Board GameBoard
        {
            get { return this._gameboard; }
            set { this._gameboard = value; }
        }

        /// <summary>
        /// Liste of players present
        /// </summary>
        public List<Player> Players
        {
            get { return this._players ?? (this._players = new List<Player>()); }
            set { this._players = value; }
        }

        #endregion

        #region contructors
        public Game(GameMode m) : this(m, "Joueur 1", "Joueur 2", PieceForm.X, PieceForm.O) { }

        public Game(GameMode m, string p1name, string p2name, PieceForm p1Form, PieceForm p2Form)
        {
            this._mode = m;
            this.Players.Add(new Player(p1name, p1Form));
            this.Players.Add(new Player(p2name, p2Form));
        }
        #endregion

        #region Methods

        public void InitGame()
        {
            Random rand = new Random();
            int boardSize = (this._mode == GameMode.Standard) ? 3 : 5;
            this.GameBoard = new Board(boardSize);
            this.Players[rand.Next(this.Players.Count)].Turn = true;
        }

        public string GetWinner()
        {
            if (this.GameBoard.Winner != null)
            {
                foreach (Player player in this.Players)
                {
                    if (player.ChoosenForm == this.GameBoard.Winner.Value)
                    {
                        return player.Name + " à gagné";
                    }
                }
                return "Match null";
            }
            return "";
        }

        /// <summary>
        /// Changes the player turn
        /// </summary>
        public void ChangeTurn()
        {
            this.Players.ForEach(player => player.Turn = !player.Turn);
        }

        // TODO : Add observer/observable pattern
        public void Subscribe(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
