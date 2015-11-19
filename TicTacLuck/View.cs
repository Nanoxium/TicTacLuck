using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacLuck
{
    public partial class View : Form
    {
        private Controler _controler;

        public View()
        {
            InitializeComponent();
            _controler = new Controler(this);
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
