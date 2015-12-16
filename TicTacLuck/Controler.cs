// TODO: Add file header
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    public class Controler
    {
        private View _view;
        private Game _game;

        public Controler(View v)
        {
            this._view = v;
        }

        public Game GameMatch
        {
            get { return this._game; }
            set { this._game = value; }
        }

        public void AddPiece(int x, int y)
        {
        }
    }
}
