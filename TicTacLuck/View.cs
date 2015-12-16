// TODO: Add file header
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
        #region Fields
        private Controler _controler;
        Color PenColor = Color.Black;
        //Board offset for positionning
        private const int BOARD_OFFSET_X = 0;
        private const int BOARD_OFFSET_Y = 0;
        #endregion

        #region Properties
        public Controler Ctrl
        {
            get { return this._controler; }
            set { this._controler = value; }
        }
        #endregion

        #region Constructor
        public View()
        {
            InitializeComponent();
            _controler = new Controler(this);
        }
        #endregion

        #region Methods
        #region Drawing
        /// <summary>
        /// Draw the board for the game with the pieces
        /// </summary>
        /// <param name="sender">the caller</param>
        /// <param name="e">Paint arguments</param>
        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid( this.Ctrl.GameMatch.GameBoard.Size, this.Ctrl.GameMatch.GameBoard.Size, this.pnlBoard.Width, this.pnlBoard.Height, e.Graphics);
        }

        /// <summary>
        /// Draw the grid for the board
        /// </summary>
        /// <param name="columns">Number of columns</param>
        /// <param name="rows">Number of rows</param>
        /// <param name="width">the width of the board</param>
        /// <param name="height">the height of the board</param>
        /// <param name="g">the graphic context</param>
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
        #endregion

        private void pnlBoard_MouseClick(object sender, MouseEventArgs e)
        {

        }

        #endregion
    }
}
