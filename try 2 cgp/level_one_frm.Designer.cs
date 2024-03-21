namespace try_2_cgp {
    partial class level_one_frm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            wall_pic_6 = new PictureBox();
            wall_pic_5 = new PictureBox();
            wall_pic_4 = new PictureBox();
            wall_pic_1 = new PictureBox();
            wall_pic_2 = new PictureBox();
            wall_pic_3 = new PictureBox();
            startzonelvlone = new PictureBox();
            endzonelvlone = new PictureBox();
            player = new PictureBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            obstacletimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)wall_pic_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startzonelvlone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endzonelvlone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // wall_pic_6
            // 
            wall_pic_6.BackColor = Color.Blue;
            wall_pic_6.Location = new Point(1, 158);
            wall_pic_6.Name = "wall_pic_6";
            wall_pic_6.Size = new Size(583, 50);
            wall_pic_6.TabIndex = 0;
            wall_pic_6.TabStop = false;
            wall_pic_6.Tag = "wall";
            wall_pic_6.Click += wall_pic_6_Click;
            // 
            // wall_pic_5
            // 
            wall_pic_5.BackColor = Color.Blue;
            wall_pic_5.Location = new Point(456, 172);
            wall_pic_5.Name = "wall_pic_5";
            wall_pic_5.Size = new Size(64, 144);
            wall_pic_5.TabIndex = 1;
            wall_pic_5.TabStop = false;
            // 
            // wall_pic_4
            // 
            wall_pic_4.BackColor = Color.Blue;
            wall_pic_4.Location = new Point(1, 266);
            wall_pic_4.Name = "wall_pic_4";
            wall_pic_4.Size = new Size(519, 50);
            wall_pic_4.TabIndex = 2;
            wall_pic_4.TabStop = false;
            wall_pic_4.Tag = "wall";
            // 
            // wall_pic_1
            // 
            wall_pic_1.BackColor = Color.Blue;
            wall_pic_1.Location = new Point(105, 0);
            wall_pic_1.Name = "wall_pic_1";
            wall_pic_1.Size = new Size(622, 50);
            wall_pic_1.TabIndex = 3;
            wall_pic_1.TabStop = false;
            wall_pic_1.Tag = "wall";
            // 
            // wall_pic_2
            // 
            wall_pic_2.BackColor = Color.Blue;
            wall_pic_2.Location = new Point(663, 46);
            wall_pic_2.Name = "wall_pic_2";
            wall_pic_2.Size = new Size(64, 404);
            wall_pic_2.TabIndex = 4;
            wall_pic_2.TabStop = false;
            wall_pic_2.Tag = "wall";
            // 
            // wall_pic_3
            // 
            wall_pic_3.BackColor = Color.Blue;
            wall_pic_3.Location = new Point(1, 400);
            wall_pic_3.Name = "wall_pic_3";
            wall_pic_3.Size = new Size(726, 50);
            wall_pic_3.TabIndex = 5;
            wall_pic_3.TabStop = false;
            wall_pic_3.Tag = "wall";
            // 
            // startzonelvlone
            // 
            startzonelvlone.BackColor = Color.Lime;
            startzonelvlone.Location = new Point(1, 0);
            startzonelvlone.Name = "startzonelvlone";
            startzonelvlone.Size = new Size(107, 161);
            startzonelvlone.TabIndex = 6;
            startzonelvlone.TabStop = false;
            // 
            // endzonelvlone
            // 
            endzonelvlone.BackColor = Color.Yellow;
            endzonelvlone.Location = new Point(1, 311);
            endzonelvlone.Name = "endzonelvlone";
            endzonelvlone.Size = new Size(107, 139);
            endzonelvlone.TabIndex = 7;
            endzonelvlone.TabStop = false;
            endzonelvlone.Tag = "endzone";
            // 
            // player
            // 
            player.BackColor = Color.Red;
            player.Location = new Point(28, 66);
            player.Name = "player";
            player.Size = new Size(41, 38);
            player.TabIndex = 8;
            player.TabStop = false;
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 20;
            mainTimer.Tick += maintimerevent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(157, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 22);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "obstacle";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(262, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(398, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 22);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.Location = new Point(499, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 22);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // obstacletimer
            // 
            obstacletimer.Enabled = true;
            obstacletimer.Interval = 20;
            // 
            // level_one_frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 449);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(player);
            Controls.Add(endzonelvlone);
            Controls.Add(startzonelvlone);
            Controls.Add(wall_pic_3);
            Controls.Add(wall_pic_2);
            Controls.Add(wall_pic_1);
            Controls.Add(wall_pic_4);
            Controls.Add(wall_pic_5);
            Controls.Add(wall_pic_6);
            Name = "level_one_frm";
            Tag = "wall";
            Text = "level_one_frm";
            Load += level_one_frm_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)wall_pic_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_pic_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)startzonelvlone).EndInit();
            ((System.ComponentModel.ISupportInitialize)endzonelvlone).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox wall_pic_6;
        private PictureBox wall_pic_5;
        private PictureBox wall_pic_4;
        private PictureBox wall_pic_1;
        private PictureBox wall_pic_2;
        private PictureBox wall_pic_3;
        private PictureBox startzonelvlone;
        private PictureBox endzonelvlone;
        private PictureBox player;
        private System.Windows.Forms.Timer mainTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer obstacletimer;
    }
}