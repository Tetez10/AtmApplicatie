using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtmApplicatie
{
    public partial class Inleg : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\AtmDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Inleg()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AccountNummerTb.Text== "") {
                MessageBox.Show("We need your AccountNumber");
            }
            Deposit();
        }

        private void Deposit()
        {

            string accno;
            int depos;

            accno = AccountNummerTb.Text;
            depos = int.Parse(DepositAmount.Text);

            try
            {
               conn.Open();
               SqlCommand cmd1 = new SqlCommand("update TransanctieTable set Amount = Amount +  '" + depos +"' where AccountNummer = '" + accno+ "'",conn) ;
               cmd1.ExecuteNonQuery();
                MessageBox.Show("Deposit Succeed ! ");
               conn.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}