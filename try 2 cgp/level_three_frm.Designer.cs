namespace try_2_cgp {
    partial class level_three_frm {
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
            player = new PictureBox();
            obs1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox30 = new PictureBox();
            pictureBox31 = new PictureBox();
            pictureBox32 = new PictureBox();
            pictureBox33 = new PictureBox();
            pictureBox34 = new PictureBox();
            pictureBox35 = new PictureBox();
            pictureBox36 = new PictureBox();
            pictureBox37 = new PictureBox();
            pictureBox38 = new PictureBox();
            pictureBox39 = new PictureBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            obstacleTimer = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Fuchsia;
            player.Location = new Point(45, 68);
            player.Margin = new Padding(2);
            player.Name = "player";
            player.Size = new Size(50, 40);
            player.TabIndex = 0;
            player.TabStop = false;
            player.Tag = "player";
            // 
            // obs1
            // 
            obs1.BackColor = Color.Black;
            obs1.Location = new Point(451, 38);
            obs1.Margin = new Padding(2);
            obs1.Name = "obs1";
            obs1.Size = new Size(28, 26);
            obs1.TabIndex = 1;
            obs1.TabStop = false;
            obs1.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Yellow;
            pictureBox3.Location = new Point(0, 536);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 92);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "endzone";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Lime;
            pictureBox4.Location = new Point(0, -27);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(156, 193);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "startzone";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Blue;
            pictureBox5.Location = new Point(149, -1);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(976, 45);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wall";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Blue;
            pictureBox6.Location = new Point(0, 165);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(634, 45);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wall";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Blue;
            pictureBox7.Location = new Point(1129, -1);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 275);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "wall";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Blue;
            pictureBox9.Location = new Point(325, 283);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(638, 45);
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "wall";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Blue;
            pictureBox8.Location = new Point(0, 210);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(58, 326);
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "wall";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Blue;
            pictureBox10.Location = new Point(204, 373);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(638, 45);
            pictureBox10.TabIndex = 10;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "wall";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Blue;
            pictureBox11.Location = new Point(935, 258);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(59, 275);
            pictureBox11.TabIndex = 11;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "wall";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Blue;
            pictureBox12.Location = new Point(356, 488);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(638, 45);
            pictureBox12.TabIndex = 12;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "wall";
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Black;
            pictureBox17.Location = new Point(909, 233);
            pictureBox17.Margin = new Padding(2);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(28, 26);
            pictureBox17.TabIndex = 17;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "obstacle";
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.Black;
            pictureBox20.Location = new Point(810, 184);
            pictureBox20.Margin = new Padding(2);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(28, 26);
            pictureBox20.TabIndex = 20;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "obstacle";
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.Black;
            pictureBox21.Location = new Point(479, 233);
            pictureBox21.Margin = new Padding(2);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(28, 26);
            pictureBox21.TabIndex = 21;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "obstacle";
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.Black;
            pictureBox23.Location = new Point(691, 233);
            pictureBox23.Margin = new Padding(2);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(28, 26);
            pictureBox23.TabIndex = 23;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "obstacle";
            // 
            // pictureBox24
            // 
            pictureBox24.BackColor = Color.Black;
            pictureBox24.Location = new Point(261, 210);
            pictureBox24.Margin = new Padding(2);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(28, 26);
            pictureBox24.TabIndex = 24;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "obstacle";
            // 
            // pictureBox26
            // 
            pictureBox26.BackColor = Color.Black;
            pictureBox26.Location = new Point(261, 349);
            pictureBox26.Margin = new Padding(2);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(28, 26);
            pictureBox26.TabIndex = 26;
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "obstacle";
            // 
            // pictureBox27
            // 
            pictureBox27.BackColor = Color.Black;
            pictureBox27.Location = new Point(382, 302);
            pictureBox27.Margin = new Padding(2);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(28, 26);
            pictureBox27.TabIndex = 27;
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "obstacle";
            // 
            // pictureBox28
            // 
            pictureBox28.BackColor = Color.Black;
            pictureBox28.Location = new Point(589, 302);
            pictureBox28.Margin = new Padding(2);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(28, 26);
            pictureBox28.TabIndex = 28;
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "obstacle";
            // 
            // pictureBox29
            // 
            pictureBox29.BackColor = Color.Black;
            pictureBox29.Location = new Point(810, 302);
            pictureBox29.Margin = new Padding(2);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(28, 26);
            pictureBox29.TabIndex = 29;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "obstacle";
            // 
            // pictureBox30
            // 
            pictureBox30.BackColor = Color.Black;
            pictureBox30.Location = new Point(834, 383);
            pictureBox30.Margin = new Padding(2);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(28, 26);
            pictureBox30.TabIndex = 30;
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "obstacle";
            // 
            // pictureBox31
            // 
            pictureBox31.BackColor = Color.Black;
            pictureBox31.Location = new Point(909, 302);
            pictureBox31.Margin = new Padding(2);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(28, 26);
            pictureBox31.TabIndex = 31;
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "obstacle";
            // 
            // pictureBox32
            // 
            pictureBox32.BackColor = Color.Black;
            pictureBox32.Location = new Point(691, 349);
            pictureBox32.Margin = new Padding(2);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(28, 26);
            pictureBox32.TabIndex = 32;
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "obstacle";
            // 
            // pictureBox33
            // 
            pictureBox33.BackColor = Color.Black;
            pictureBox33.Location = new Point(479, 349);
            pictureBox33.Margin = new Padding(2);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(28, 26);
            pictureBox33.TabIndex = 33;
            pictureBox33.TabStop = false;
            pictureBox33.Tag = "obstacle";
            // 
            // pictureBox34
            // 
            pictureBox34.BackColor = Color.Black;
            pictureBox34.Location = new Point(810, 417);
            pictureBox34.Margin = new Padding(2);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(28, 26);
            pictureBox34.TabIndex = 34;
            pictureBox34.TabStop = false;
            pictureBox34.Tag = "obstacle";
            // 
            // pictureBox35
            // 
            pictureBox35.BackColor = Color.Black;
            pictureBox35.Location = new Point(909, 464);
            pictureBox35.Margin = new Padding(2);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(28, 26);
            pictureBox35.TabIndex = 35;
            pictureBox35.TabStop = false;
            pictureBox35.Tag = "obstacle";
            // 
            // pictureBox36
            // 
            pictureBox36.BackColor = Color.Black;
            pictureBox36.Location = new Point(397, 417);
            pictureBox36.Margin = new Padding(2);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(28, 26);
            pictureBox36.TabIndex = 36;
            pictureBox36.TabStop = false;
            pictureBox36.Tag = "obstacle";
            // 
            // pictureBox37
            // 
            pictureBox37.BackColor = Color.Black;
            pictureBox37.Location = new Point(479, 464);
            pictureBox37.Margin = new Padding(2);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(28, 26);
            pictureBox37.TabIndex = 37;
            pictureBox37.TabStop = false;
            pictureBox37.Tag = "obstacle";
            // 
            // pictureBox38
            // 
            pictureBox38.BackColor = Color.Black;
            pictureBox38.Location = new Point(584, 417);
            pictureBox38.Margin = new Padding(2);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(28, 26);
            pictureBox38.TabIndex = 38;
            pictureBox38.TabStop = false;
            pictureBox38.Tag = "obstacle";
            // 
            // pictureBox39
            // 
            pictureBox39.BackColor = Color.Black;
            pictureBox39.Location = new Point(691, 464);
            pictureBox39.Margin = new Padding(2);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(28, 26);
            pictureBox39.TabIndex = 39;
            pictureBox39.TabStop = false;
            pictureBox39.Tag = "obstacle";
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 20;
            mainTimer.Tick += maintimerevent;
            // 
            // obstacleTimer
            // 
            obstacleTimer.Enabled = true;
            obstacleTimer.Tick += obstacleTimerEvent;
            // 
            // level_three_frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 630);
            Controls.Add(pictureBox39);
            Controls.Add(pictureBox38);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox35);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(obs1);
            Controls.Add(player);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Margin = new Padding(2);
            Name = "level_three_frm";
            Text = "Level 3";
            Load += level_three_frm_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)obs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox obs1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox17;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer obstacleTimer;
        private ColorDialog colorDialog1;
    }
}