namespace ATM
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Percentage = new Label();
            Myprogress = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 9);
            label2.Name = "label2";
            label2.Size = new Size(586, 46);
            label2.TabIndex = 2;
            label2.Text = "ATM MANAGEMENT SYSTEM";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(376, 376);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(63, 60);
            Percentage.TabIndex = 3;
            Percentage.Text = "%";
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(0, 439);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(799, 11);
            Myprogress.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Myprogress);
            Controls.Add(Percentage);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
        private ProgressBar Myprogress;
        private PictureBox pictureBox1;
    }
}
