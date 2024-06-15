namespace ATM
{
    partial class Home
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
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            AccNumlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 25);
            label1.Name = "label1";
            label1.Size = new Size(631, 46);
            label1.TabIndex = 1;
            label1.Text = "Please Select Your Transaction";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 102);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 19.8000011F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(764, 1);
            label8.Name = "label8";
            label8.Size = new Size(36, 37);
            label8.TabIndex = 15;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(111, 187);
            button1.Name = "button1";
            button1.Size = new Size(180, 48);
            button1.TabIndex = 7;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(519, 187);
            button2.Name = "button2";
            button2.Size = new Size(179, 48);
            button2.TabIndex = 8;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(111, 275);
            button3.Name = "button3";
            button3.Size = new Size(180, 48);
            button3.TabIndex = 9;
            button3.Text = "Fast Cash";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(519, 275);
            button4.Name = "button4";
            button4.Size = new Size(179, 48);
            button4.TabIndex = 10;
            button4.Text = "Mini Statement";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(519, 369);
            button5.Name = "button5";
            button5.Size = new Size(179, 48);
            button5.TabIndex = 12;
            button5.Text = "Balance";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(111, 369);
            button6.Name = "button6";
            button6.Size = new Size(180, 48);
            button6.TabIndex = 11;
            button6.Text = "Change Pin";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 490);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 13);
            panel2.TabIndex = 13;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(348, 440);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 14;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumlbl.ForeColor = Color.Black;
            AccNumlbl.Location = new Point(226, 105);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(264, 34);
            AccNumlbl.TabIndex = 15;
            AccNumlbl.Text = "Account Number";
            AccNumlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(AccNumlbl);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Button button7;
        private Label label8;
        private Label AccNumlbl;
    }
}