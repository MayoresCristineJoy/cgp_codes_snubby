namespace try_2_cgp
{
    partial class Form1
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
            upperBoundaryPictureBox = new PictureBox();
            lowerBoundaryPictureBox = new PictureBox();
            obstaclePictureBox = new PictureBox();
            movementTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            player = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)upperBoundaryPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerBoundaryPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstaclePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // upperBoundaryPictureBox
            // 
            upperBoundaryPictureBox.BackColor = Color.Red;
            upperBoundaryPictureBox.Location = new Point(177, 462);
            upperBoundaryPictureBox.Margin = new Padding(4, 5, 4, 5);
            upperBoundaryPictureBox.Name = "upperBoundaryPictureBox";
            upperBoundaryPictureBox.Size = new Size(143, 83);
            upperBoundaryPictureBox.TabIndex = 0;
            upperBoundaryPictureBox.TabStop = false;
            upperBoundaryPictureBox.Tag = "boundary";
            upperBoundaryPictureBox.Visible = false;
            // 
            // lowerBoundaryPictureBox
            // 
            lowerBoundaryPictureBox.BackColor = Color.Red;
            lowerBoundaryPictureBox.Location = new Point(548, 462);
            lowerBoundaryPictureBox.Margin = new Padding(4, 5, 4, 5);
            lowerBoundaryPictureBox.Name = "lowerBoundaryPictureBox";
            lowerBoundaryPictureBox.Size = new Size(143, 83);
            lowerBoundaryPictureBox.TabIndex = 1;
            lowerBoundaryPictureBox.TabStop = false;
            lowerBoundaryPictureBox.Tag = "boundary";
            lowerBoundaryPictureBox.Visible = false;
            // 
            // obstaclePictureBox
            // 
            obstaclePictureBox.BackColor = Color.Blue;
            obstaclePictureBox.Location = new Point(357, 462);
            obstaclePictureBox.Margin = new Padding(4, 5, 4, 5);
            obstaclePictureBox.Name = "obstaclePictureBox";
            obstaclePictureBox.Size = new Size(143, 83);
            obstaclePictureBox.TabIndex = 2;
            obstaclePictureBox.TabStop = false;
            // 
            // movementTimer
            // 
            movementTimer.Interval = 25;
            movementTimer.Tick += movementTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(71, 245);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 405);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "boundary";
            // 
            // player
            // 
            player.BackColor = Color.Yellow;
            player.Location = new Point(59, 50);
            player.Margin = new Padding(4, 5, 4, 5);
            player.Name = "player";
            player.Size = new Size(143, 83);
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Location = new Point(693, 239);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 405);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "boundary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox2);
            Controls.Add(player);
            Controls.Add(pictureBox1);
            Controls.Add(obstaclePictureBox);
            Controls.Add(lowerBoundaryPictureBox);
            Controls.Add(upperBoundaryPictureBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)upperBoundaryPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerBoundaryPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstaclePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox upperBoundaryPictureBox;
        private PictureBox lowerBoundaryPictureBox;
        private PictureBox obstaclePictureBox;
        private System.Windows.Forms.Timer movementTimer;
        private PictureBox pictureBox1;
        private PictureBox player;
        private PictureBox pictureBox2;
    }
}