using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacLuck
{
    class Controler
    {
        private View _view;
        private Model _model;

        public Controler(View v)
        {
            _view = v;
            _model = new Model(this);
        }
    }
}
