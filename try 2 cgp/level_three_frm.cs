using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_2_cgp {
    public partial class level_three_frm : Form {

        private Point previousPlayerLocation;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 12;
        int obs_speed = 5;


        public level_three_frm() {
            InitializeComponent();

        }

        private void maintimerevent(object sender, EventArgs e) {

            if (moveLeft == true && player.Left > 1) {
                player.Left -= speed;
            }

            if (moveRight == true && player.Left < 885) {
                player.Left += speed;
            }

            if (moveUp == true && player.Top > 1) {
                player.Top -= speed;
            }

            if (moveDown == true && player.Top < 855) {
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

        private void pictureBox13_Click(object sender, EventArgs e) {

        }

        private void pictureBox16_Click(object sender, EventArgs e) {

        }

        private void obstacleTimerEvent(object sender, EventArgs e) {
            // Obstacle 1 movement
            obs1.Top += obs_speed;

            // Check if obstacle is within vertical bounds
            if (obs1.Top < 139 || obs1.Bottom >= 44) {
                // Reverse direction if the obstacle hits the upper or lower bound
                obs_speed = -obs_speed;

                // Adjust position if out of bounds
                if (obs1.Top < 139) {
                    obs1.Top = 139; // Set the top of the obstacle to 139 if it goes above it
                } else if (obs1.Bottom >= 44) {
                    obs1.Top = 44 - obs1.Height; // Set the top of the obstacle to (44 - height) if it goes below it
                }
            }
        } 

        private void level_three_frm_Load(object sender, EventArgs e) {

        }
    }
}