namespace InbentarioaUnmi
{
    public partial class FLogina : Form
    {
        public FLogina()
        {
            InitializeComponent();
        }

        private void FLogina_Load(object sender, EventArgs e)
        {
            txtErabiltzailea.Focus();
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSartu_Click(object sender, EventArgs e)
        {

        }

        private void txtPasahitza_Leave(object sender, EventArgs e)
        {
            if(txtPasahitza.Text == null)
            {
                MessageBox.Show("Sartu pasahitza");
                txtPasahitza.Focus();
            }
            else
            {
                cbSartu.Enabled = true;
                cbSartu.Focus();
            }
        }

        private void txtErabiltzailea_Leave(object sender, EventArgs e)
        {
            if(txtErabiltzailea.Text == null)
            {
                MessageBox.Show("Sartu erabiltzaile izena");
                txtErabiltzailea.Focus();
            }
            else
            {
                txtPasahitza.Focus();
            }
        }
    }
}
