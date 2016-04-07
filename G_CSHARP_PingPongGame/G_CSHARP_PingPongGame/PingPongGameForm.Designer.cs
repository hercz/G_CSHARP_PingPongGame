namespace G_CSHARP_PingPongGame
{
    partial class PingPongGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPongGameForm));
            this.playground = new System.Windows.Forms.Panel();
            this.gameOver_lbl = new System.Windows.Forms.Label();
            this.percent_lbl = new System.Windows.Forms.Label();
            this.levelCounter_lbl = new System.Windows.Forms.Label();
            this.level_lbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.point_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.gift_pb = new System.Windows.Forms.PictureBox();
            this.pingPongTimer = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Transparent;
            this.playground.Controls.Add(this.gameOver_lbl);
            this.playground.Controls.Add(this.percent_lbl);
            this.playground.Controls.Add(this.levelCounter_lbl);
            this.playground.Controls.Add(this.level_lbl);
            this.playground.Controls.Add(this.progressBar);
            this.playground.Controls.Add(this.point_lbl);
            this.playground.Controls.Add(this.score_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.gift_pb);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(671, 402);
            this.playground.TabIndex = 0;
            // 
            // gameOver_lbl
            // 
            this.gameOver_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameOver_lbl.AutoSize = true;
            this.gameOver_lbl.Location = new System.Drawing.Point(311, 56);
            this.gameOver_lbl.Name = "gameOver_lbl";
            this.gameOver_lbl.Size = new System.Drawing.Size(64, 26);
            this.gameOver_lbl.TabIndex = 8;
            this.gameOver_lbl.Text = "Game Over!\r\nScore:";
            this.gameOver_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // percent_lbl
            // 
            this.percent_lbl.AutoSize = true;
            this.percent_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.percent_lbl.Location = new System.Drawing.Point(1150, 9);
            this.percent_lbl.Name = "percent_lbl";
            this.percent_lbl.Size = new System.Drawing.Size(32, 20);
            this.percent_lbl.TabIndex = 7;
            this.percent_lbl.Text = "0%";
            // 
            // levelCounter_lbl
            // 
            this.levelCounter_lbl.AutoSize = true;
            this.levelCounter_lbl.Location = new System.Drawing.Point(198, 9);
            this.levelCounter_lbl.Name = "levelCounter_lbl";
            this.levelCounter_lbl.Size = new System.Drawing.Size(13, 13);
            this.levelCounter_lbl.TabIndex = 6;
            this.levelCounter_lbl.Text = "0";
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.Location = new System.Drawing.Point(155, 9);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(36, 13);
            this.level_lbl.TabIndex = 5;
            this.level_lbl.Text = "Level:";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.Location = new System.Drawing.Point(1200, 9);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 30);
            this.progressBar.TabIndex = 4;
            this.progressBar.Click += new System.EventHandler(this.PingPongTimer_Tick);
            // 
            // point_lbl
            // 
            this.point_lbl.AutoSize = true;
            this.point_lbl.Location = new System.Drawing.Point(56, 9);
            this.point_lbl.Name = "point_lbl";
            this.point_lbl.Size = new System.Drawing.Size(13, 13);
            this.point_lbl.TabIndex = 3;
            this.point_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(38, 13);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(78, 99);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.racket.Location = new System.Drawing.Point(31, 226);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(222, 23);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // gift_pb
            // 
            this.gift_pb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gift_pb.Image = ((System.Drawing.Image)(resources.GetObject("gift_pb.Image")));
            this.gift_pb.Location = new System.Drawing.Point(292, 99);
            this.gift_pb.Name = "gift_pb";
            this.gift_pb.Size = new System.Drawing.Size(98, 93);
            this.gift_pb.TabIndex = 9;
            this.gift_pb.TabStop = false;
            // 
            // pingPongTimer
            // 
            this.pingPongTimer.Interval = 1;
            this.pingPongTimer.Tick += new System.EventHandler(this.PingPongTimer_Tick);
            // 
            // PingPongGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 402);
            this.Controls.Add(this.playground);
            this.Name = "PingPongGameForm";
            this.Text = "PingPongGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer pingPongTimer;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label point_lbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label levelCounter_lbl;
        private System.Windows.Forms.Label level_lbl;
        private System.Windows.Forms.Label percent_lbl;
        private System.Windows.Forms.Label gameOver_lbl;
        private System.Windows.Forms.PictureBox gift_pb;
    }
}

