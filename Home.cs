using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tusha\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button7_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static String AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number: " + login.AccNumber;
            AccNumber = login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FASTCASH fcash = new FASTCASH();
            fcash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ministatement ms = new ministatement();
            ms.Show();
            this.Hide();
        }
    }
}
