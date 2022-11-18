namespace AtmApplicatie
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void OpenAtmButton_Click(object sender, EventArgs e)
        {
            Connexion Childform = new Connexion();
           


            Childform.MdiParent = this;
            OpenAtmButton.Enabled = false;
            OpenAtmButton.Visible= false;
            Childform.Show();
            
          


        }





    }
}