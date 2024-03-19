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
    public partial class lvlthree : Form
    {
        public lvlthree()
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
            RoundPictureBox(pictureBox13);
            RoundPictureBox(pictureBox14);
            RoundPictureBox(pictureBox15);
            RoundPictureBox(pictureBox16);
            RoundPictureBox(pictureBox17);
            RoundPictureBox(pictureBox18);
            RoundPictureBox(pictureBox19);
            RoundPictureBox(pictureBox20);
            RoundPictureBox(pictureBox21);
            RoundPictureBox(pictureBox22);
            RoundPictureBox(pictureBox23);
            RoundPictureBox(pictureBox24);
            RoundPictureBox(pictureBox25);
            RoundPictureBox(pictureBox26);
            RoundPictureBox(pictureBox27);
            RoundPictureBox(pictureBox28);
            RoundPictureBox(pictureBox29);
            RoundPictureBox(pictureBox30);

        }
        private void RoundPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            Region region = new Region(gp);
            pb.Region = region;
        }
        private void MakeCircularPictureBox(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
