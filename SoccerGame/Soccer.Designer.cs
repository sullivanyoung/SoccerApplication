
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
            this.lblmatchMoments = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.player.Location = new System.Drawing.Point(109, 269);
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
            this.cpu.Location = new System.Drawing.Point(787, 269);
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
            this.ball.Location = new System.Drawing.Point(451, 269);
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
            this.userPoints.Location = new System.Drawing.Point(104, 13);
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
            this.cpuPoints.Location = new System.Drawing.Point(782, 13);
            this.cpuPoints.Name = "cpuPoints";
            this.cpuPoints.Size = new System.Drawing.Size(38, 25);
            this.cpuPoints.TabIndex = 4;
            this.cpuPoints.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // lblmatchMoments
            // 
            this.lblmatchMoments.BackColor = System.Drawing.Color.Transparent;
            this.lblmatchMoments.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblmatchMoments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatchMoments.ForeColor = System.Drawing.Color.Blue;
            this.lblmatchMoments.Location = new System.Drawing.Point(0, 0);
            this.lblmatchMoments.Name = "lblmatchMoments";
            this.lblmatchMoments.Size = new System.Drawing.Size(928, 24);
            this.lblmatchMoments.TabIndex = 5;
            this.lblmatchMoments.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(425, 534);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 28);
            this.btnBegin.TabIndex = 6;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(425, 534);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Soccer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpuPoints);
            this.Controls.Add(this.userPoints);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblmatchMoments);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnNext);
            this.Name = "Soccer";
            this.Text = "Soccer Game";
            this.Load += new System.EventHandler(this.Soccer_Load);
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
        private System.Windows.Forms.Label lblmatchMoments;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnNext;
    }
}

