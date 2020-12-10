using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerGame
{
    public partial class Soccer : Form
    {
        bool moveUp;
        bool moveDown;
        bool moveLeft;
        bool moveRight;
        int speed = 7;
        int ballx = 7;
        int bally = 7;
        int userScore = 0;
        int cpuScore = 0;

        public Soccer()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            userPoints.Text = "" + userScore;
            cpuPoints.Text = "" + cpuScore;

            ball.Top -= bally; 
            ball.Left -= ballx;

            cpu.Top += speed;

            //cpu functionality

            if(userScore < 2)
            {
                if(cpu.Top < 192|| cpu.Top > 340)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 30;
            }

            //ball functionality -- fix
   
            if(ball.Left < 68 && ball.Top > 250 && ball.Top < 290)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                cpuScore++;
                lblmatchMoments.Text = "Yellow Scores!";
                lblMessage1.Text = "";
                lblMessage2.Text = "";
            }

            if(ball.Left > 830 && ball.Top > 250 && ball.Top < 290)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                userScore++;
                lblmatchMoments.Text = "Red Scores!";
                lblMessage1.Text = "";
                lblMessage2.Text = "";
            }

            if (ball.Left > 830 && ball.Top > 230 && ball.Top < 250 || ball.Left > 830 && ball.Top > 290 && ball.Top < 310 || 
                ball.Left < 68 && ball.Top > 230 && ball.Top < 250 || ball.Left < 68 && ball.Top > 290 && ball.Top < 310)
            {
                lblmatchMoments.Text = "Hit off the post!";
            }

            if (ball.Top < 50 || ball.Top > 485)
            {
                bally = -bally;
            }

            if(ball.Left < 67 || ball.Left > 831)
            {
                ballx = -ballx;
            }

            if(ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
                lblmatchMoments.Text = "";
            }

            //player functionality
            if (moveUp == true && player.Top > 54)
            {
                player.Top -= 8;
            }
            if (moveDown == true && player.Top < 485)
            {
                player.Top += 8;
            }
            if (moveRight == true && player.Left < 676)
            {
                player.Left += 8;
            }
            if (moveLeft == true && player.Left > 109)
            {
                player.Left -= 8;
            }

            //final score ending
            if(userScore == 5)
            {
                gameTimer.Stop();
                MessageBox.Show("You won!");
            }
            if(cpuScore == 5)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins!");
            }
        }

        private void Soccer_Load(object sender, EventArgs e)
        {
            lblmatchMoments.Text = "Welcome to my Soccer Application!";
            //btnBegin.Visible = false;
        }

        //tried to create an inital start up command but it kept messing with the user's movement
        private void btnNext_Click(object sender, EventArgs e)
        {
            //instructions++;

            //switch (instructions)
            //{
            //    case 1:
            //        lblmatchMoments.Text = "Use the Arrow Keys to move your player.";
            //        break;
            //    case 2:
            //        lblmatchMoments.Text = "First to 5 goals wins!";
            //        break;
            //    case 3:
            //        lblmatchMoments.Text = "Click the Begin button to start match!";
            //        btnBegin.Visible = true;
            //        btnNext.Visible = false;
            //        break;
            //}
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //gameTimer.Enabled = true;
            //btnBegin.Visible = false;
            //lblmatchMoments.Text = "";
        }
    }
}
