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

            if (userScore < 2)
            {
                if (cpu.Top < 203 || cpu.Top > 325)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 100;
            }


            //ball functionality
            if(ball.Left < 75 && ball.Top > 275 && ball.Top < 320)
            {
                ball.Left = 529;
                player.Left = 127;
                cpu.Left = 928;
                cpu.Top = 298;
                ballx = -ballx;
                ballx = 10;
                cpuScore++;
            }

            if (ball.Left > 980 && ball.Top > 275 && ball.Top < 320)
            {
                ball.Left = 529;
                player.Left = 127;
                cpu.Left = 928;
                ballx = +ballx;
                ballx = 10;
                userScore++;
            }

            if (ball.Top < 55 || ball.Top + ball.Height > 75)
            {
                bally = -bally;
            }

            if (ball.Left < 74 || ball.Left > 981)
            {
                ballx = -ballx;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ballx = -ballx;
                ballx -= 2;
            }

            if(ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
                ballx += 2;
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
    }
}
