using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_CSHARP_PingPongGame
{
    public partial class Form1 : Form
    {
        private int speed_left = 4;
        private int speed_top = 4;
        private int points = 0;
        private int levelCounter = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - (playground.Bottom/10);

        }

        public void IncreaseSpeed()
        {
            speed_top += 5;
            speed_left += 5; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width/2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left &&
                ball.Right <= racket.Right)
            {
                if (points == 3)
                {
                    levelCounter_lbl.Text = "Easy!";
                   IncreaseSpeed();
                }
                if (points == 6)
                {
                    levelCounter_lbl.Text = "Normal!";
                    IncreaseSpeed();
                }
                if (points == 9)
                {
                    levelCounter_lbl.Text = "You're crazy!";
                    IncreaseSpeed();
                }
                if (points == 12)
                {
                    levelCounter_lbl.Text = "LEGEND!!!";
                    IncreaseSpeed();
                }
                speed_top = -speed_top;
                points += 1;
                point_lbl.Text = points.ToString();
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over!", "Game Over",
                    MessageBoxButtons.OK);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                point_lbl.Text = "0";
                levelCounter = 0;
                levelCounter_lbl.Text = "0";
                timer1.Enabled = true;
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
