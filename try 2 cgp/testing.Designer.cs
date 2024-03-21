namespace try_2_cgp {
    partial class testing {
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
            movetimer = new System.Windows.Forms.Timer(components);
            player_character = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player_character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // movetimer
            // 
            movetimer.Enabled = true;
            movetimer.Interval = 20;
            movetimer.Tick += moveTimerEvent;
            // 
            // player_character
            // 
            player_character.Enabled = false;
            player_character.Image = Properties.Resources._429997820_1312833556050816_856385814480720038_n;
            player_character.Location = new Point(363, 171);
            player_character.Margin = new Padding(2);
            player_character.Name = "player_character";
            player_character.Size = new Size(24, 21);
            player_character.SizeMode = PictureBoxSizeMode.StretchImage;
            player_character.TabIndex = 4;
            player_character.TabStop = false;
            player_character.Click += player_character_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, -82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 20;
            label1.Text = "LEVEL 1:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(348, -82);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 19);
            textBox2.TabIndex = 17;
            textBox2.Text = "DEATH =";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Image = Properties.Resources._433708616_2990774524438129_6779344523841217643_n;
            pictureBox1.Location = new Point(86, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(623, 252);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 354);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(player_character);
            Controls.Add(pictureBox1);
            Name = "testing";
            Text = "Form1";
            Load += testing_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player_character).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer movetimer;
        private PictureBox player_character;
        private Label label1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}