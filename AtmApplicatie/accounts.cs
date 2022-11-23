using System;
using System.CodeDom;
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
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "AtmDb.mdf"));


        private void accounts_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={info};Integrated Security=True;Connect Timeout=30");
          
            SqlDataAdapter sda = new SqlDataAdapter("SElECT * FROM AccountTable",conn);
            DataTable AccountsList = new DataTable();  
            sda.Fill(AccountsList);
            AccountList.DataSource = AccountsList;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.Show();
            this.Hide();

        }

        private void AccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
