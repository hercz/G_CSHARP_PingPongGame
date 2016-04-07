#region File Header

/*[ Compilation unit ----------------------------------------------------------

   Component       : PingPongGame form file

   Name            : Code_Gangstaz

   Last Author     : Herczku Misi

   Language        : C#

   Creation Date   :  2016.04.07.

   Description     : This is the file where we store the program initialiser, and event handlers


               Copyright (C) Codecool Kft 2016 All Rights Reserved

-----------------------------------------------------------------------------*/
/*] END */

#endregion File Header

#region Used Namespaces ---------------------------------------------------------------------------

using System;
using System.Windows.Forms;

#endregion Used Namespaces ------------------------------------------------------------------------

namespace G_CSHARP_PingPongGame
{
    public partial class PingPongGameForm : Form
    {
        public PingPongGameForm()
        {
            InitializeComponent();
            StartGame();
        }
        #region BallPositionProperties ------------------------------------------------------------------------
        private bool BallFallDown => ball.Bottom >= playground.Bottom;

        private bool BallInTop => ball.Top <= playground.Top;

        private bool BallInSides => ball.Left <= playground.Left || ball.Right >= playground.Right;

        private bool BallInRacket => ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left &&
                                         ball.Right <= racket.Right;
        #endregion BallPositionProperties ------------------------------------------------------------------------

        #region FormEvents ------------------------------------------------------------------------
        private void PingPongTimer_Tick(object sender, EventArgs e)
        {
            BallStartMoving();
            if (BallInRacket)
            {
                LevelUpProcess();
            }

            if (BallInSides)
            {
                SpeedLeft = -SpeedLeft;
            }
            if (BallInTop)
            {
                SpeedTop = -SpeedTop;
            }
            if (BallFallDown)
            {
                GameOver();
            }
        }

        private void PingPongGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
            }
            if (e.KeyCode == Keys.Space)
            {
                pingPongTimer.Enabled = !pingPongTimer.Enabled;
            }
            if (e.KeyCode == Keys.Enter)
            {                
                StartGame();
            }
        }
        #endregion FormEvents ------------------------------------------------------------------------

        #region ProcessMethods ------------------------------------------------------------------------
        private void BallStartMoving()
        {
            racket.Left = Cursor.Position.X - racket.Width / 2;
            ball.Left += SpeedLeft;
            ball.Top += SpeedTop;
        }

        private void LevelUpProcess()
        {
            
            string[] levelNames = {"0","Easy", "Normal", "You're crazy!", "LEGEND!!!"};
            if (Points % 4 == 0 && Points <=16)
            {
                levelCounter_lbl.Text = levelNames[Level];
                IncreaseSpeed();
                ResetProgressBar();
                Level += 1;
            }
            PointCounter();
        }

        private void PointCounter()
        {
            SpeedTop = -SpeedTop;
            Points += 1;
            point_lbl.Text = Points.ToString();
            progressBar.Increment(25);
            percent_lbl.Text = progressBar.Value + @"%";
        }

        private void ResetProgressBar()
        {
            progressBar.Maximum = 100;
            for (var k = 0; k <= 100; k++)
            {
                progressBar.Value = k;
                if (progressBar.Maximum == k)
                    progressBar.Value = 0;
            }
        }

        public void StartGame()
        {
            pingPongTimer.Enabled = true;
            ball.Top = 50;
            ball.Left = 50;
            SpeedLeft = 4;
            SpeedTop = 4;
            Points = 0;
            Level = 0;
            point_lbl.Text = @"0";
            levelCounter_lbl.Text = @"0";
            progressBar.Value = 0;
            gameOver_lbl.Hide();
            gift_pb.Hide();
            Cursor.Hide();
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - playground.Bottom / 10;
        }

        public void IncreaseSpeed()
        {
            SpeedTop += 1;
            SpeedLeft += 1;
        }

        public void GameOver()
        {
            var gamOverStringStart = "Game Over!\nScore: ";
            var gamoverStringEnd = "\nYour gift is in the picture :)\nNew game: press ENTER\nExit: press ESC";
            pingPongTimer.Enabled = false;
            gameOver_lbl.Show();
            gameOver_lbl.Text = gamOverStringStart + Points + gamoverStringEnd;
            gift_pb.Show();
        }
        #endregion ProcessMethods ------------------------------------------------------------------------

        #region private Types ------------------------------------------------------------------------

        public int SpeedLeft { get; private set; }
        public int SpeedTop { get; private set; }
        public int Points { get; private set; }
        public int Level { get; private set; }
        #endregion private Types ---------------------------------------------------------------------
    }
}