using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApplicatie
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "AtmDb.mdf"));
        SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={info};Integrated Security=True;Connect Timeout=30");

        private void Connexion_Load(object sender, EventArgs e)

        {

        }

        private void AdminLbl_Click(object sender, EventArgs e)
        {

        }

        private void ConnecterenBtn_Click(object sender, EventArgs e)
        {
            ConnectUser();


        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            MakeAccount mk = new MakeAccount();
            mk.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            accounts ac = new accounts();
            ac.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectAdmin ca = new ConnectAdmin();
            ca.Show();
            this.Hide ();



        }

       
        private void ConnectUser()
        {
            string req = "select * from AccountTable where Acname= '" + NaamTb.Text + "' and Password='" + PasswordTb.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(req, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Menu mn = new Menu();
                mn.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Name or Password is not correct");
            }
            conn.Close();

        }
    }
    

}
    
    



    

    


