namespace ATM
{
    partial class account
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
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AccNumTb = new TextBox();
            AccNametb = new TextBox();
            FanameTb = new TextBox();
            Addresstb = new TextBox();
            PhoneTb = new TextBox();
            label7 = new Label();
            pintb = new TextBox();
            label9 = new Label();
            label10 = new Label();
            educationcb = new ComboBox();
            dobdate = new DateTimePicker();
            label11 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            occupationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 105);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(944, 4);
            label8.Name = "label8";
            label8.Size = new Size(36, 37);
            label8.TabIndex = 3;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(201, 25);
            label1.Name = "label1";
            label1.Size = new Size(586, 46);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 185);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "ACC NUM";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 259);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "NAME";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 329);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 5;
            label4.Text = "FNAME";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(69, 398);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 6;
            label5.Text = "ADDRESS";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(520, 398);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 7;
            label6.Text = "PHONE";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            AccNumTb.Location = new Point(202, 182);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(224, 27);
            AccNumTb.TabIndex = 8;
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            AccNametb.Location = new Point(202, 256);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(224, 27);
            AccNametb.TabIndex = 9;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            FanameTb.Location = new Point(202, 326);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(224, 27);
            FanameTb.TabIndex = 10;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            Addresstb.Location = new Point(202, 395);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(224, 93);
            Addresstb.TabIndex = 11;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            PhoneTb.Location = new Point(670, 395);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(224, 27);
            PhoneTb.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(520, 190);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 13;
            label7.Text = "PIN";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // pintb
            // 
            pintb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            pintb.Location = new Point(670, 182);
            pintb.Name = "pintb";
            pintb.Size = new Size(224, 27);
            pintb.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(520, 259);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 17;
            label9.Text = "EDUCATION";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(520, 328);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 19;
            label10.Text = "OCCUPATION";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // educationcb
            // 
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "New Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(670, 251);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(224, 28);
            educationcb.TabIndex = 20;
            // 
            // dobdate
            // 
            dobdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobdate.Location = new Point(670, 458);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(224, 30);
            dobdate.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(520, 469);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 23;
            label11.Text = "DOB";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(427, 529);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 24;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 13);
            panel2.TabIndex = 25;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(427, 590);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 26;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            occupationtb.Location = new Point(670, 320);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(224, 27);
            occupationtb.TabIndex = 27;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 656);
            Controls.Add(occupationtb);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(dobdate);
            Controls.Add(educationcb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pintb);
            Controls.Add(label7);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            Load += account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox AccNumTb;
        private TextBox AccNametb;
        private TextBox FanameTb;
        private TextBox Addresstb;
        private TextBox PhoneTb;
        private Label label7;
        private TextBox pintb;
        private Label label9;
        private Label label10;
        private ComboBox educationcb;
        private DateTimePicker dobdate;
        private Label label11;
        private Button button1;
        private Panel panel2;
        private Button button7;
        private TextBox occupationtb;
        private Label label8;
    }
}