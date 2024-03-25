using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_2_cgp
{
    public partial class Form1 : Form
    {

        /// //////////
        private int obstacleSpeed = 10; // Adjust speed as needed


        private bool movingDown = true;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 15;
        public Form1()
        {
            InitializeComponent();


        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {

            if (moveLeft == true && player.Left > 1)
            {
                player.Left -= speed;
            }

            if (moveRight == true && player.Left < 686)
            {
                player.Left += speed;
            }

            if (moveUp == true && player.Top > 1)
            {
                player.Top -= speed;
            }

            if (moveDown == true && player.Top < 362)
            {
                player.Top += speed;
            }



            ///////////////////////////////////
            int upperBoundary = upperBoundaryPictureBox.Location.X;
            int lowerBoundary = lowerBoundaryPictureBox.Location.X;


            if (movingDown && obstaclePictureBox.Left <= lowerBoundary)
            {
                obstaclePictureBox.Left += obstacleSpeed;

            }
            else if (!movingDown && obstaclePictureBox.Left >= upperBoundary)
            {

                obstaclePictureBox.Left -= obstacleSpeed;
            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown = !movingDown;
            }
            //////////////////////////////////////



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            movementTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            movementTimer.Stop();
        }

        private void obstaclePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }
    }
}
