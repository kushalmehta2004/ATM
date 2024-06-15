namespace ATM
{
    partial class Balance
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
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
            button7 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(162, 195);
            label3.Name = "label3";
            label3.Size = new Size(212, 29);
            label3.TabIndex = 4;
            label3.Text = "Account Number:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 102);
            panel1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 19.8000011F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(687, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 37);
            label8.TabIndex = 29;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 27);
            label1.Name = "label1";
            label1.Size = new Size(586, 46);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(162, 271);
            label2.Name = "label2";
            label2.Size = new Size(176, 29);
            label2.TabIndex = 6;
            label2.Text = "Your Balance:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.Black;
            Balancelbl.Location = new Point(380, 271);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(159, 29);
            Balancelbl.TabIndex = 8;
            Balancelbl.Text = "BalanceinRs";
            Balancelbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumberlbl.ForeColor = Color.Black;
            AccNumberlbl.Location = new Point(380, 195);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(109, 29);
            AccNumberlbl.TabIndex = 7;
            AccNumberlbl.Text = "AccNum";
            AccNumberlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(297, 369);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 27;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 14);
            panel2.TabIndex = 28;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 473);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumberlbl);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label Balancelbl;
        private Label AccNumberlbl;
        private Button button7;
        private Panel panel2;
        private Label label8;
    }
}