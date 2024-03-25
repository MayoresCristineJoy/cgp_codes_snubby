namespace try_2_cgp
{
    partial class level_one
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            player = new PictureBox();
            timermovement = new System.Windows.Forms.Timer(components);
            lowerboundary_1 = new PictureBox();
            upperboundary_1 = new PictureBox();
            upperboundary_2 = new PictureBox();
            lowerboundary_2 = new PictureBox();
            obstacle_1 = new PictureBox();
            obstacle_2 = new PictureBox();
            upperboundary_3 = new PictureBox();
            lowerboundary_3 = new PictureBox();
            obstacle_3 = new PictureBox();
            upperboundary_4 = new PictureBox();
            lowerboundary_4 = new PictureBox();
            obstacle_4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Location = new Point(130, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "wall";
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 188);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Blue;
            pictureBox3.Location = new Point(-1, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(644, 75);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Blue;
            pictureBox4.Location = new Point(-1, 380);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(544, 75);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Blue;
            pictureBox5.Location = new Point(-1, 562);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(853, 75);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wall";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Blue;
            pictureBox7.Location = new Point(549, 185);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(93, 270);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "wall";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Lime;
            pictureBox8.Location = new Point(-1, 448);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(134, 187);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "zone";
            // 
            // player
            // 
            player.BackColor = Color.Fuchsia;
            player.Location = new Point(35, 97);
            player.Name = "player";
            player.Size = new Size(59, 58);
            player.TabIndex = 8;
            player.TabStop = false;
            // 
            // timermovement
            // 
            timermovement.Enabled = true;
            timermovement.Interval = 16;
            timermovement.Tick += timermovement_Tick;
            // 
            // lowerboundary_1
            // 
            lowerboundary_1.BackColor = Color.Red;
            lowerboundary_1.Location = new Point(186, 288);
            lowerboundary_1.Name = "lowerboundary_1";
            lowerboundary_1.Size = new Size(54, 48);
            lowerboundary_1.TabIndex = 10;
            lowerboundary_1.TabStop = false;
            lowerboundary_1.Tag = "boundaries";
            // 
            // upperboundary_1
            // 
            upperboundary_1.BackColor = Color.Red;
            upperboundary_1.Location = new Point(186, 72);
            upperboundary_1.Name = "upperboundary_1";
            upperboundary_1.Size = new Size(54, 48);
            upperboundary_1.TabIndex = 11;
            upperboundary_1.TabStop = false;
            upperboundary_1.Tag = "boundaries";
            // 
            // upperboundary_2
            // 
            upperboundary_2.BackColor = Color.Red;
            upperboundary_2.Location = new Point(317, 72);
            upperboundary_2.Name = "upperboundary_2";
            upperboundary_2.Size = new Size(54, 48);
            upperboundary_2.TabIndex = 12;
            upperboundary_2.TabStop = false;
            upperboundary_2.Tag = "boundaries";
            // 
            // lowerboundary_2
            // 
            lowerboundary_2.BackColor = Color.Red;
            lowerboundary_2.Location = new Point(317, 288);
            lowerboundary_2.Name = "lowerboundary_2";
            lowerboundary_2.Size = new Size(54, 48);
            lowerboundary_2.TabIndex = 13;
            lowerboundary_2.TabStop = false;
            lowerboundary_2.Tag = "boundaries";
            // 
            // obstacle_1
            // 
            obstacle_1.BackColor = Color.Black;
            obstacle_1.Location = new Point(186, 72);
            obstacle_1.Name = "obstacle_1";
            obstacle_1.Size = new Size(54, 48);
            obstacle_1.TabIndex = 14;
            obstacle_1.TabStop = false;
            obstacle_1.Tag = "boundaries";
            // 
            // obstacle_2
            // 
            obstacle_2.BackColor = Color.Black;
            obstacle_2.Location = new Point(317, 288);
            obstacle_2.Name = "obstacle_2";
            obstacle_2.Size = new Size(54, 48);
            obstacle_2.TabIndex = 15;
            obstacle_2.TabStop = false;
            obstacle_2.Tag = "boundaries";
            // 
            // upperboundary_3
            // 
            upperboundary_3.BackColor = Color.Red;
            upperboundary_3.Location = new Point(437, 72);
            upperboundary_3.Name = "upperboundary_3";
            upperboundary_3.Size = new Size(54, 48);
            upperboundary_3.TabIndex = 16;
            upperboundary_3.TabStop = false;
            upperboundary_3.Tag = "boundaries";
            // 
            // lowerboundary_3
            // 
            lowerboundary_3.BackColor = Color.Red;
            lowerboundary_3.Location = new Point(437, 288);
            lowerboundary_3.Name = "lowerboundary_3";
            lowerboundary_3.Size = new Size(54, 48);
            lowerboundary_3.TabIndex = 17;
            lowerboundary_3.TabStop = false;
            lowerboundary_3.Tag = "boundaries";
            // 
            // obstacle_3
            // 
            obstacle_3.BackColor = Color.Black;
            obstacle_3.Location = new Point(437, 72);
            obstacle_3.Name = "obstacle_3";
            obstacle_3.Size = new Size(54, 48);
            obstacle_3.TabIndex = 18;
            obstacle_3.TabStop = false;
            obstacle_3.Tag = "boundaries";
            // 
            // upperboundary_4
            // 
            upperboundary_4.BackColor = Color.Red;
            upperboundary_4.Location = new Point(570, 72);
            upperboundary_4.Name = "upperboundary_4";
            upperboundary_4.Size = new Size(54, 48);
            upperboundary_4.TabIndex = 19;
            upperboundary_4.TabStop = false;
            upperboundary_4.Tag = "boundaries";
            // 
            // lowerboundary_4
            // 
            lowerboundary_4.BackColor = Color.Red;
            lowerboundary_4.Location = new Point(570, 288);
            lowerboundary_4.Name = "lowerboundary_4";
            lowerboundary_4.Size = new Size(54, 48);
            lowerboundary_4.TabIndex = 20;
            lowerboundary_4.TabStop = false;
            lowerboundary_4.Tag = "boundaries";
            // 
            // obstacle_4
            // 
            obstacle_4.BackColor = Color.Black;
            obstacle_4.Location = new Point(570, 288);
            obstacle_4.Name = "obstacle_4";
            obstacle_4.Size = new Size(54, 48);
            obstacle_4.TabIndex = 21;
            obstacle_4.TabStop = false;
            obstacle_4.Tag = "boundaries";
            // 
            // level_one
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 637);
            Controls.Add(obstacle_4);
            Controls.Add(lowerboundary_4);
            Controls.Add(upperboundary_4);
            Controls.Add(obstacle_3);
            Controls.Add(lowerboundary_3);
            Controls.Add(upperboundary_3);
            Controls.Add(obstacle_2);
            Controls.Add(obstacle_1);
            Controls.Add(lowerboundary_2);
            Controls.Add(upperboundary_2);
            Controls.Add(upperboundary_1);
            Controls.Add(lowerboundary_1);
            Controls.Add(player);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "level_one";
            Text = "level_one";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperboundary_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerboundary_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle_4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox player;
        private System.Windows.Forms.Timer timermovement;
        private PictureBox lowerboundary_1;
        private PictureBox upperboundary_1;
        private PictureBox upperboundary_2;
        private PictureBox lowerboundary_2;
        private PictureBox obstacle_1;
        private PictureBox obstacle_2;
        private PictureBox upperboundary_3;
        private PictureBox lowerboundary_3;
        private PictureBox obstacle_3;
        private PictureBox upperboundary_4;
        private PictureBox lowerboundary_4;
        private PictureBox obstacle_4;
    }
}