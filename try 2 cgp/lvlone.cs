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

namespace try_2_cgp
{

    public partial class lvlone : Form
    {



        public lvlone()
        {
            InitializeComponent();
            RoundPictureBox(pictureBox3);
            RoundPictureBox(pictureBox4);
            RoundPictureBox(pictureBox5);
            RoundPictureBox(pictureBox6);
            RoundPictureBox(pictureBox7);
            RoundPictureBox(pictureBox8);
            RoundPictureBox(pictureBox9);
            RoundPictureBox(pictureBox10);
            RoundPictureBox(pictureBox11);
            RoundPictureBox(pictureBox12);
        }
        private void RoundPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            Region region = new Region(gp);
            pb.Region = region;
        }

        private void lvlone_Load(object sender, EventArgs e)
        {

        }
        private void MakeCircularPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coverpage coverpage = new coverpage();
            coverpage.Show();
            Hide();
        }
    }
}
