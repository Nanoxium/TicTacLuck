using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Color PenColor = Color.Purple;
        private const int BOARD_WIDTH = 300;
        private const int BOARD_HEIGHT = 300;
        int n = 5;
        //Board offset for positionning
        private const int BOARD_OFFSET_X = 50;
        private const int BOARD_OFFSET_Y = 50;

        public View()
        {
            InitializeComponent();
            _controler = new Controler(this);
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            
            DrawGrid( n ,n, BOARD_WIDTH, BOARD_HEIGHT, e.Graphics);
        }

        private void DrawGrid(int columns, int rows, int width, int height, Graphics g)
        {
            Pen p = new Pen(this.PenColor);

            int beginningPosition = BOARD_OFFSET_Y;

            //Draw the column's line
            for (int col = 0; col < columns+2; col++)
            {
                g.DrawLine(p, beginningPosition, BOARD_OFFSET_Y, beginningPosition, height+BOARD_OFFSET_Y);
                beginningPosition = ((width/columns) * col) + BOARD_OFFSET_Y;
            }

            
            beginningPosition = BOARD_OFFSET_X;

            //Draw the column's line
            for (int row = 0; row < rows + 2; row++)
            {
                //Draw the line between 
                g.DrawLine(p, BOARD_OFFSET_X, beginningPosition, width+BOARD_OFFSET_X, beginningPosition);
                beginningPosition = ((height / rows) * row) + BOARD_OFFSET_X;
            }
        }

        private void DrawPieces()
        {
            
        }

        private void DrawCross()
        {
            
        }

        private void DrawCircle()
        {
            
        }

        private void View_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
