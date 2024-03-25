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

    public partial class level_one : Form
    {
        private bool movingDown1 = true;
        private bool movingDown2 = true;
        private int obstacleSpeed = 3;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 15;
        private Point previousPlayerLocation;
        public level_one()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void timermovement_Tick(object sender, EventArgs e)
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

            // wall collision
            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && (string)x.Tag == "wall")
            //    {
            //        PictureBox wall = (PictureBox)x;

            //        if (player.Bounds.IntersectsWith(wall.Bounds))
            //        {
            //            // Check both x and y coordinates
            //            if (player.Left < wall.Right && player.Right > wall.Left &&
            //                player.Top < wall.Bottom && player.Bottom > wall.Top)
            //            {
            //                // If the player intersects with the wall, revert to previous location
            //                player.Location = previousPlayerLocation;
            //            }
            //        }
            //    }
            //}
            previousPlayerLocation = player.Location;

            int Upperbound_1 = upperboundary_1.Location.Y;
            int Lowerbound_1 = lowerboundary_1.Location.Y;
            int Upperbound_2 = upperboundary_2.Location.Y;
            int Lowerbound_2 = lowerboundary_2.Location.Y;

            //obstacle number 1 up and down
            if (movingDown1 && obstacle_1.Top <= Lowerbound_1)
            {
                // increment 
                obstacle_1.Top += obstacleSpeed;
                obstacle_3.Top += obstacleSpeed;
            }
            else if (!movingDown1 && obstacle_1.Top >= Upperbound_1)
            {
                //ito  -= decrement 
                obstacle_1.Top -= obstacleSpeed;
                obstacle_3.Top -= obstacleSpeed;

            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown1 = !movingDown1;
            }

            ///// obstacle 2 
            if (movingDown2 && obstacle_2.Top <= Lowerbound_2)
            {
                // increment 
                obstacle_2.Top += obstacleSpeed;
                obstacle_4.Top += obstacleSpeed;
            }
            else if (!movingDown2 && obstacle_2.Top >= Upperbound_2)
            {
                //ito  -= decrement 
                obstacle_2.Top -= obstacleSpeed;
                obstacle_4.Top -= obstacleSpeed;
            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown2 = !movingDown2;
            }

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
