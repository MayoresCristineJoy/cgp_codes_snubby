﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_2_cgp {
    public partial class level_two_frm : Form {

        private Point previousPlayerLocation;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 10;
        int obs_speed = 3;

        public level_two_frm() {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e) {

        }

        private void pictureBox11_Click(object sender, EventArgs e) {

        }

        private void pictureBox13_Click(object sender, EventArgs e) {

        }

<<<<<<< HEAD
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
=======
        private void maintimerevent(object sender, EventArgs e) {
            if (moveLeft == true && player.Left > 1) {
                player.Left -= speed;
            }

            if (moveRight == true && player.Left < 686) {
                player.Left += speed;
            }

            if (moveUp == true && player.Top > 1) {
                player.Top -= speed;
            }

            if (moveDown == true && player.Top < 362) {
                player.Top += speed;
            }
            foreach (Control x in this.Controls) {
                if (x is PictureBox && (string)x.Tag == "wall") {

                    if (player.Bounds.IntersectsWith(x.Bounds)) {
                        player.Location = previousPlayerLocation;
                    }
                }
            }
            previousPlayerLocation = player.Location;
        }

        private void keyisdown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Left) {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right) {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up) {
                moveUp = true;
            }

            if (e.KeyCode == Keys.Down) {
                moveDown = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right) {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up) {
                moveUp = false;
            }

            if (e.KeyCode == Keys.Down) {
                moveDown = false;
            }
        }
>>>>>>> 6fdf78f7c35c9548be3f6c27969e5176570d91fa
    }
}
