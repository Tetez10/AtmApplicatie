using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApplicatie
{
    public partial class Intrek : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\AtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        public Intrek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccountNummerTb.Text == "")
            {
                MessageBox.Show("Schrijf u accountNummer");
            }

            intrek();


        }
        
        // probleem met mijn withdraw maar inleg werkt wel

            public void intrek()
            {

                string accno;
                int withdraw;

                accno = AccountNummerTb.Text;
                withdraw = int.Parse(WithdrawAmounttb.Text);

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update TransanctieTable set Amount = Amount - '" + withdraw + "' where AccountNummer = '" + accno+ "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("WithDraw Succeed! ");
                    conn.Close();


                }
                catch (Exception ex)
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

          
    

    
        

      

