﻿using System;
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
            gameOver_lbl.Hide();
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - (playground.Bottom/10);
        }

        public void IncreaseSpeed()
        {
            speed_top += 1;
            speed_left += 1; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width/2);
            ball.Left += speed_left;
            ball.Top += speed_top;
            
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left &&
                ball.Right <= racket.Right)
            {
                if (points == 2)
                {
                    levelCounter_lbl.Text = "Easy!";
                    IncreaseSpeed();
                    ResetProgressBar();

                }
                if (points == 4)
                {
                    levelCounter_lbl.Text = "Normal!";
                    IncreaseSpeed();
                    ResetProgressBar();
                }
                if (points == 6)
                {
                    levelCounter_lbl.Text = "You're crazy!";
                    IncreaseSpeed();
                    ResetProgressBar();
                }
                if (points == 8)
                {
                    levelCounter_lbl.Text = "LEGEND!!!";
                    IncreaseSpeed();
                    ResetProgressBar();
                }
                speed_top = -speed_top;
                points += 1;
                point_lbl.Text = points.ToString();
                progressBar.Increment(50);
                percent_lbl.Text = progressBar.Value.ToString() + "%";
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
                gameOver_lbl.Show();
                gameOver_lbl.Text = "Game Over!\r\nScore: " + points + "\r\nFor a new game press ENTER" +
                                    "\r\nOr if you want to EXIT, press ESC.";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
            }
            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                }
                else
                {
                    timer1.Enabled = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                gameOver_lbl.Hide();
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                point_lbl.Text = "0";
                levelCounter = 0;
                levelCounter_lbl.Text = "0";
                Cursor.Hide();
                timer1.Enabled = true;
                progressBar.Value = 0;
            }
        }

        private void ResetProgressBar()
        {
            progressBar.Maximum = 100;
            for (int k = 0; k <= 100; k++)
            {
                progressBar.Value = k;
                if (progressBar.Maximum == k)
                    progressBar.Value = 0;
            }
        }
    }
}
