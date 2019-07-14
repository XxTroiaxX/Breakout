using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
            Time.Enabled = true;
            setBlocks();
        }

        int Vspeed = 2;
        int Lspeed = 2;
        public const int row = 5;
        public const int col = 6;
        public PictureBox[,] blocks; 

        private void setBlocks()
        {
            int blockheight = 25;
            int blockwidth = 100;

            blocks = new PictureBox[row, col];

            for(int x = 0; x < row; x++)
            {
                for(int y = 0; y < col; y++)
                {
                    blocks[x, y] = new PictureBox();
                    blocks[x, y].Width = blockwidth;
                    blocks[x, y].Height = blockheight;
                    blocks[x, y].Top = blockheight * x;
                    blocks[x, y].Left = blockwidth * y;
                    blocks[x, y].BackColor = Color.Green;
                    blocks[x, y].BorderStyle = BorderStyle.Fixed3D;

                    this.Controls.Add(blocks[x, y]);
                }
            }
        }


        private void Time_Tick(object sender, EventArgs e)
        {
            Ball.Top += Vspeed;
            Ball.Left += Lspeed;

            if(Ball.Bottom == this.ClientRectangle.Bottom)
            {
                Time.Stop();
                MessageBox.Show("Test");
            }
            else if(Ball.Top == this.ClientRectangle.Top)
            {
                Vspeed = 2;
            }
            else if(Ball.Left == this.ClientRectangle.Left)
            {
                Lspeed = 2;
            }
            else if(Ball.Right == this.ClientRectangle.Right)
            {
                Lspeed = -1;
            }
            else if(Ball.Bounds.IntersectsWith(Plat.Bounds) == true)
            {
                Vspeed = -2;
            }

            for(int x = 0; x < row; x++)
            {
                for(int y = 0; y < col; y++)
                {
                    if(Ball.Bounds.IntersectsWith(blocks[x,y].Bounds) == true && blocks[x,y].Visible == true)
                    {
                        blocks[x, y].Visible = false;
                        Vspeed = -Vspeed;
                    }
                }
            }
        }

        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            Plat.Left = e.X - (Plat.Width / 2);
        }
    }
}
