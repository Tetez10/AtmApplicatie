using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApplicatie
{
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
          
        }
       
        private void CheckBalance()
        
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\AtmDb.mdf;Integrated Security=True;Connect Timeout=30");
           conn.Open();
            SqlCommand cmd = new SqlCommand("select Amount from TransanctieTable where AccountNummer=@nummer");
            cmd.Parameters.AddWithValue("@nummer", AccountNrTb.Text);
            cmd.Connection= conn;

           using(SqlDataReader rd = cmd.ExecuteReader()) { 
            while(rd.Read())
                {

                    huidigesaldotb.Text = rd.GetInt32(0).ToString();

                }
            
            
            }

            conn.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {

        }

        
        private void huidigesaldotb_TextChanged(object sender, EventArgs e)
        {

        }

        private void toonsaldo_Click(object sender, EventArgs e)
        {

            if(AccountNrTb.Text == "")
            {
                MessageBox.Show("we need your AccountNumber to show your saldo" +
                    " ");

            }
           CheckBalance();
            
        }
    }
}
