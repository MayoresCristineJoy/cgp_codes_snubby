namespace try_2_cgp {
    public partial class level_one_frm : Form {


        private obstacle_movement obstacle_movement_cls;
        //private List<obstacle_movement> obstacle_move_down;
        private PictureBox y_up, y_down;
        private int vertical_speed = 15;

        private Point previousPlayerLocation;
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 10;
        int obs_speed = 3;


        public level_one_frm() {
            InitializeComponent();
            //obstacle_move_down = new List<obstacle_movement>();

            obstacle_movement_cls = new obstacle_movement();
        }




        private void wall_pic_6_Click(object sender, EventArgs e) {

        }

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


            // wall collision
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

        private void level_one_frm_Load(object sender, EventArgs e) {
            mainTimer.Start();
        }

        private void startzonelvlone_Click(object sender, EventArgs e) {

        }

        private void endzonelvlone_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void obs1_Click(object sender, EventArgs e) {

        }
    }
}
