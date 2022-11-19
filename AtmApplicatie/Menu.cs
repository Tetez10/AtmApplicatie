using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApplicatie
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inleg obj = new Inleg();
            obj.Show();
            this.Hide();

        }

        private void IntrekBtn_Click(object sender, EventArgs e)
        {
            Intrek obj = new Intrek();
            obj.Show();
            this.Hide();
        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaldoBtn_Click(object sender, EventArgs e)
        {
            Saldo sd = new Saldo();
            sd.Show();
            this.Hide();   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TransactieBtn_Click(object sender, EventArgs e)
        {
            Transactions tr = new Transactions();
            tr.Show();
            this.Hide();
        }
    }
}
