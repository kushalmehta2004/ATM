﻿namespace ATM
{
    partial class Deposit
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
            panel2 = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            button1 = new Button();
            DepoAmtTb = new TextBox();
            label3 = new Label();
            button7 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 14);
            panel2.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 102);
            panel1.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 19.8000011F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(688, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 37);
            label8.TabIndex = 41;
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
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(267, 335);
            button1.Name = "button1";
            button1.Size = new Size(146, 48);
            button1.TabIndex = 38;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepoAmtTb.Location = new Point(371, 215);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(224, 43);
            DepoAmtTb.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(120, 225);
            label3.Name = "label3";
            label3.Size = new Size(107, 29);
            label3.TabIndex = 36;
            label3.Text = "Amount:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(278, 398);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 39;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(248, 105);
            label2.Name = "label2";
            label2.Size = new Size(201, 46);
            label2.TabIndex = 40;
            label2.Text = "DEPOSIT";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 473);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(DepoAmtTb);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox DepoAmtTb;
        private Label label3;
        private Button button7;
        private Label label2;
        private Label label8;
    }
}