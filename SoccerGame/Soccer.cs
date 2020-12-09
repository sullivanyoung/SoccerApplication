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

            //cpu functionality -- fix



            //ball functionality -- fix
   


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
