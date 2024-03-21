namespace try_2_cgp {
    partial class lvlone {
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
            textBox2 = new TextBox();
            player_character = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            moveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player_character).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(346, 7);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 19);
            textBox2.TabIndex = 2;
            textBox2.Text = "DEATH =";
            // 
            // player_character
            // 
            player_character.Image = Properties.Resources._429997820_1312833556050816_856385814480720038_n;
            player_character.Location = new Point(113, 349);
            player_character.Margin = new Padding(2);
            player_character.Name = "player_character";
            player_character.Size = new Size(24, 21);
            player_character.SizeMode = PictureBoxSizeMode.StretchImage;
            player_character.TabIndex = 3;
            player_character.TabStop = false;
            player_character.Click += player_character_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(372, 349);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 28);
            button1.TabIndex = 4;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "LEVEL 1:";
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimerEvent;
            // 
            // lvlone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 397);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(player_character);
            Controls.Add(textBox2);
            Margin = new Padding(2);
            Name = "lvlone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level 1";
            Load += lvlone_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player_character).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private PictureBox player_character;
        private Button button1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer moveTimer;
    }
}