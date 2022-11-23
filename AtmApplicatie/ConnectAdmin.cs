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
    public partial class ConnectAdmin : Form
    {
        public ConnectAdmin()
        {
            InitializeComponent();
        }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "AtmDb.mdf"));
        SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={info};Integrated Security=True;Connect Timeout=30");

        private void Connectadmin()
        {

            string req = "select * from AdminTable where AdminName= '" + NaamTb.Text + "' and AdminPassword='" + PasswordTb.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(req, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                accounts ac = new accounts();
                ac.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("AdminName = admin , Adminpassword = admin");
            }
            conn.Close();


        }

        private void ConnectAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connectadmin();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connexion c = new Connexion();  
            c.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
