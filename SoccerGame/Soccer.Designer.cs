
namespace SoccerGame
{
    partial class Soccer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soccer));
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.userPoints = new System.Windows.Forms.Label();
            this.cpuPoints = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(128, 298);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 36);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Transparent;
            this.cpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpu.BackgroundImage")));
            this.cpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cpu.Location = new System.Drawing.Point(928, 298);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(33, 36);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball.Location = new System.Drawing.Point(529, 298);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 36);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // userPoints
            // 
            this.userPoints.AutoSize = true;
            this.userPoints.BackColor = System.Drawing.Color.Transparent;
            this.userPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPoints.ForeColor = System.Drawing.Color.Red;
            this.userPoints.Location = new System.Drawing.Point(86, 13);
            this.userPoints.Name = "userPoints";
            this.userPoints.Size = new System.Drawing.Size(38, 25);
            this.userPoints.TabIndex = 3;
            this.userPoints.Text = "00";
            // 
            // cpuPoints
            // 
            this.cpuPoints.AutoSize = true;
            this.cpuPoints.BackColor = System.Drawing.Color.Transparent;
            this.cpuPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPoints.ForeColor = System.Drawing.Color.Yellow;
            this.cpuPoints.Location = new System.Drawing.Point(948, 13);
            this.cpuPoints.Name = "cpuPoints";
            this.cpuPoints.Size = new System.Drawing.Size(38, 25);
            this.cpuPoints.TabIndex = 4;
            this.cpuPoints.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Soccer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 633);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpuPoints);
            this.Controls.Add(this.userPoints);
            this.Controls.Add(this.ball);
            this.Name = "Soccer";
            this.Text = "Soccer Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label userPoints;
        private System.Windows.Forms.Label cpuPoints;
        private System.Windows.Forms.Timer gameTimer;
    }
}

