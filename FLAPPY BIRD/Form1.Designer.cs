namespace FLAPPY_BIRD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bird = new PictureBox();
            patwma = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            top = new PictureBox();
            bottom = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patwma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottom).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.BackgroundImage = (Image)resources.GetObject("bird.BackgroundImage");
            bird.BackgroundImageLayout = ImageLayout.Stretch;
            bird.Location = new Point(66, 175);
            bird.Name = "bird";
            bird.Size = new Size(60, 50);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // patwma
            // 
            patwma.BackColor = Color.Fuchsia;
            patwma.BackgroundImage = (Image)resources.GetObject("patwma.BackgroundImage");
            patwma.Location = new Point(0, 435);
            patwma.Name = "patwma";
            patwma.Size = new Size(801, 698);
            patwma.SizeMode = PictureBoxSizeMode.StretchImage;
            patwma.TabIndex = 1;
            patwma.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // top
            // 
            top.BackColor = Color.Lime;
            top.BackgroundImage = (Image)resources.GetObject("top.BackgroundImage");
            top.BackgroundImageLayout = ImageLayout.Zoom;
            top.Location = new Point(393, -35);
            top.Name = "top";
            top.Size = new Size(80, 193);
            top.SizeMode = PictureBoxSizeMode.StretchImage;
            top.TabIndex = 2;
            top.TabStop = false;
            // 
            // bottom
            // 
            bottom.BackColor = Color.Lime;
            bottom.BackgroundImage = (Image)resources.GetObject("bottom.BackgroundImage");
            bottom.BackgroundImageLayout = ImageLayout.Zoom;
            bottom.Location = new Point(393, 268);
            bottom.Name = "bottom";
            bottom.Size = new Size(80, 172);
            bottom.SizeMode = PictureBoxSizeMode.StretchImage;
            bottom.TabIndex = 3;
            bottom.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 43);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 132);
            label2.Name = "label2";
            label2.Size = new Size(464, 172);
            label2.TabIndex = 300;
            label2.Text = "                FLAPPY BIRD\r\n\r\n                        \r\n          PRESS SPACE TO START";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(639, 9);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 303;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.flappy_bird_background_png_8;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 553);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bottom);
            Controls.Add(top);
            Controls.Add(patwma);
            Controls.Add(bird);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)patwma).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bird;
        private PictureBox patwma;
        private System.Windows.Forms.Timer timer1;
        private PictureBox top;
        private PictureBox bottom;
        private Label label1;
        private Label label2;
        private Label label5;
    }
}
