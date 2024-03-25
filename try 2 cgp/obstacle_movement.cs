using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_2_cgp {
    internal class obstacle_movement {

        private PictureBox obstacle;
        private PictureBox y_up;
        private PictureBox y_down;
        private int obstacleSpeed; 
        private bool movingUp;
        private bool movingDown;
        public string message;


        public string showMessage() {
            message = "this is obstacle class";
            return message;
        }

        public void Movecircular() {

            int upDestination = y_down.Location.Y;
            int downDestination = y_up.Location.Y;

            if (movingDown && obstacle.Top < downDestination) {
                obstacle.Top += obstacleSpeed;

                if (obstacle.Top >= downDestination) {
                    movingDown = false;
                }
            } else if (!movingDown && obstacle.Top > upDestination) {
                obstacle.Top -= obstacleSpeed;
                if (obstacle.Top <= upDestination) {
                    movingDown = true;
                }
            } else {
                string message = "wrong syntax";
                MessageBox.Show(message);
            }
        }


    }


}
