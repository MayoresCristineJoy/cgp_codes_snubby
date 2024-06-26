﻿using System;
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
    public partial class level_three : Form
    {
        private bool movingDown1 = true;
        private bool movingDown2 = true;
        private bool movingDown3 = true;
        private bool movingDown4 = true;
        private int obstacleSpeed = 3;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 15;
        private Point previousPlayerLocation;
        public level_three()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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

            previousPlayerLocation = player.Location;

            int Upperbound_1 = upperboundary_1.Location.Y;
            int Lowerbound_1 = lowerboundary_1.Location.Y;
            int Upperbound_2 = upperboundary_2.Location.Y;
            int Lowerbound_2 = lowerboundary_2.Location.Y;
            int Leftbound_3 = leftboundary_1.Location.X;
            int Rightbound_3 = rightboundary_1.Location.X;
            int Leftbound_4 = leftboundary_2.Location.X;
            int Rightbound_4 = rightboundary_2.Location.X;

            //obstacle number 1 up and down
            if (movingDown1 && obstacle_1.Top <= Lowerbound_1)
            {
                // increment 
                obstacle_1.Top += obstacleSpeed;
                obstacle_3.Top += obstacleSpeed;
                obstacle_5.Top += obstacleSpeed;
                obstacle_7.Top += obstacleSpeed;
                obstacle_12.Top += obstacleSpeed;
                obstacle_14.Top += obstacleSpeed;
                obstacle_16.Top += obstacleSpeed;
                obstacle_18.Top += obstacleSpeed;
                obstacle_26.Top += obstacleSpeed;
                obstacle_28.Top += obstacleSpeed;
                obstacle_30.Top += obstacleSpeed;
                obstacle_32.Top += obstacleSpeed;
                obstacle_38.Top += obstacleSpeed;
                obstacle_40.Top += obstacleSpeed;
                obstacle_42.Top += obstacleSpeed;
                obstacle_44.Top += obstacleSpeed;
                obstacle_49.Top += obstacleSpeed;
                obstacle_51.Top += obstacleSpeed;
            }
            else if (!movingDown1 && obstacle_1.Top >= Upperbound_1)
            {
                //ito  -= decrement 
                obstacle_1.Top -= obstacleSpeed;
                obstacle_3.Top -= obstacleSpeed;
                obstacle_5.Top -= obstacleSpeed;
                obstacle_7.Top -= obstacleSpeed;
                obstacle_12.Top -= obstacleSpeed;
                obstacle_14.Top -= obstacleSpeed;
                obstacle_16.Top -= obstacleSpeed;
                obstacle_18.Top -= obstacleSpeed;
                obstacle_26.Top -= obstacleSpeed;
                obstacle_28.Top -= obstacleSpeed;
                obstacle_30.Top -= obstacleSpeed;
                obstacle_32.Top -= obstacleSpeed;
                obstacle_38.Top -= obstacleSpeed;
                obstacle_40.Top -= obstacleSpeed;
                obstacle_42.Top -= obstacleSpeed;
                obstacle_44.Top -= obstacleSpeed;
                obstacle_49.Top -= obstacleSpeed;
                obstacle_51.Top -= obstacleSpeed;
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
                obstacle_6.Top += obstacleSpeed;
                obstacle_8.Top += obstacleSpeed;
                obstacle_13.Top += obstacleSpeed;
                obstacle_15.Top += obstacleSpeed;
                obstacle_17.Top += obstacleSpeed;
                obstacle_19.Top += obstacleSpeed;
                obstacle_27.Top += obstacleSpeed;
                obstacle_29.Top += obstacleSpeed;
                obstacle_31.Top += obstacleSpeed;
                obstacle_33.Top += obstacleSpeed;
                obstacle_39.Top += obstacleSpeed;
                obstacle_41.Top += obstacleSpeed;
                obstacle_43.Top += obstacleSpeed;
                obstacle_48.Top += obstacleSpeed;
                obstacle_50.Top += obstacleSpeed;
                obstacle_52.Top += obstacleSpeed;
            }
            else if (!movingDown2 && obstacle_2.Top >= Upperbound_2)
            {
                //ito  -= decrement 
                obstacle_2.Top -= obstacleSpeed;
                obstacle_4.Top -= obstacleSpeed;
                obstacle_6.Top -= obstacleSpeed;
                obstacle_8.Top -= obstacleSpeed;
                obstacle_13.Top -= obstacleSpeed;
                obstacle_15.Top -= obstacleSpeed;
                obstacle_17.Top -= obstacleSpeed;
                obstacle_19.Top -= obstacleSpeed;
                obstacle_27.Top -= obstacleSpeed;
                obstacle_29.Top -= obstacleSpeed;
                obstacle_31.Top -= obstacleSpeed;
                obstacle_33.Top -= obstacleSpeed;
                obstacle_39.Top -= obstacleSpeed;
                obstacle_41.Top -= obstacleSpeed;
                obstacle_43.Top -= obstacleSpeed;
                obstacle_48.Top -= obstacleSpeed;
                obstacle_50.Top -= obstacleSpeed;
                obstacle_52.Top -= obstacleSpeed;
            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown2 = !movingDown2;
            }

            /// obstacle number 3 right and left
            if (movingDown3 && obstacle_9.Left <= Rightbound_3)
            {
                obstacle_9.Left += obstacleSpeed;
                obstacle_11.Left += obstacleSpeed;
                obstacle_20.Left += obstacleSpeed;
                obstacle_22.Left += obstacleSpeed;
                obstacle_24.Left += obstacleSpeed;
                obstacle_34.Left += obstacleSpeed;
                obstacle_36.Left += obstacleSpeed;
                obstacle_46.Left += obstacleSpeed;

            }
            else if (!movingDown3 && obstacle_9.Left >= Leftbound_3)
            {
                obstacle_9.Left -= obstacleSpeed;
                obstacle_11.Left -= obstacleSpeed;
                obstacle_20.Left -= obstacleSpeed;
                obstacle_22.Left -= obstacleSpeed;
                obstacle_24.Left -= obstacleSpeed;
                obstacle_34.Left -= obstacleSpeed;
                obstacle_36.Left -= obstacleSpeed;
                obstacle_46.Left -= obstacleSpeed;
            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown3 = !movingDown3;
            }

            /// number 4
            if (movingDown4 && obstacle_10.Left <= Rightbound_4)
            {
                obstacle_10.Left += obstacleSpeed;
                obstacle_21.Left += obstacleSpeed;
                obstacle_23.Left += obstacleSpeed;
                obstacle_25.Left += obstacleSpeed;
                obstacle_35.Left += obstacleSpeed;
                obstacle_37.Left += obstacleSpeed;
                obstacle_45.Left += obstacleSpeed;
                obstacle_47.Left += obstacleSpeed;
            }
            else if (!movingDown4 && obstacle_10.Left >= Leftbound_4)
            {
                obstacle_10.Left -= obstacleSpeed;
                obstacle_21.Left -= obstacleSpeed;
                obstacle_23.Left -= obstacleSpeed;
                obstacle_25.Left -= obstacleSpeed;
                obstacle_35.Left -= obstacleSpeed;
                obstacle_37.Left -= obstacleSpeed;
                obstacle_45.Left -= obstacleSpeed;
                obstacle_47.Left -= obstacleSpeed;
            }
            else
            {
                // Reverse direction when reaching boundaries
                movingDown4 = !movingDown4;
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

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void level_three_Load(object sender, EventArgs e)
        {

        }

        private void lowerboundary_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
