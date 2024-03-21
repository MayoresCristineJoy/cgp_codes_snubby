using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_2_cgp {

    public partial class lvlone : Form {

        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 12;

        public lvlone() {
            InitializeComponent();

        }
        private void RoundPictureBox(PictureBox pb) {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            Region region = new Region(gp);
            pb.Region = region;
        }

        private void lvlone_Load(object sender, EventArgs e) {

        }

        private void pictureBox3_Click(object sender, EventArgs e) {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            coverpage coverpage = new coverpage();
            coverpage.Show();
            Hide();
        }

        private void moveTimerEvent(object sender, EventArgs e) {
            if (moveLeft == true && player_character.Left > 0) {
                player_character.Left -= speed;
            }
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

        private void player_character_Click(object sender, EventArgs e) {

        }
    }
}
