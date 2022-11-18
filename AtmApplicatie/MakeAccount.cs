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
    public partial class MakeAccount : Form
    {
       
        public MakeAccount()
        {
            InitializeComponent();
           

        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\AtmDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void CreateBtn_Click(object sender, EventArgs e)
        {


            if (NaamTb.Text == "" || AdressTb.Text == "" || AccountNummerTb.Text == "" || PhoneTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("we need more information to register you");
            }
            else
            {
                try
                {
                    Con.Open();
                    
                    SqlCommand cmd = new SqlCommand("insert into AccountTable values(@AccountNummer,@AcName,@ACphone,@AcAdress,@Password)", Con);
                    SqlCommand cmd1 = new SqlCommand("insert into TransanctieTable values(@AccountNummer,@Amount,@DepositAmount,@WithdrawAmount)",Con);
                    cmd1.Parameters.AddWithValue("@AccountNummer", AccountNummerTb.Text);
                    cmd1.Parameters.AddWithValue("@Amount", 0);
                    cmd1.Parameters.AddWithValue("@DepositAmount", 0);
                    cmd1.Parameters.AddWithValue("@WithdrawAmount", 0);

                    cmd.Parameters.AddWithValue("@Acname", NaamTb.Text);
                    cmd.Parameters.AddWithValue("@AccountNummer", AccountNummerTb.Text);
                    cmd.Parameters.AddWithValue("@AcPhone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AcAdress", AdressTb.Text);
                    cmd.Parameters.AddWithValue("@Password",PasswordTb.Text);
                  
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("account created", " your account Number is = @AccountNumber");
                    Con.Close();

                    Connexion cn = new Connexion();
                    cn.Show();
                    this.Hide();

                                      

                }

                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message);
                    
                }

            }





        }

  
    }
}
    

