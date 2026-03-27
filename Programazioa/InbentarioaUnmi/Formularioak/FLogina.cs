using InbentarioaUnmi.Formularioak;

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
            menuStrip1.Visible = false;
            txtErabiltzailea.Focus();
        }
        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
            menuStrip1.Visible = true;
            menuStrip1.Enabled = true;
        }
        private void txtErabiltzailea_Leave(object sender, EventArgs e)
        {
            if (txtErabiltzailea.Text == null)
            {
                MessageBox.Show("Sartu erabiltzaile izena");
                txtErabiltzailea.Focus();
            }
            else
            {
                txtPasahitza.Enabled = true;
                txtPasahitza.Focus();
            }
        }
        private void txtPasahitza_Leave(object sender, EventArgs e)
        {
            if (txtPasahitza.Text == null)
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
        private void cbSartu_Click_1(object sender, EventArgs e)
        {
            FSarrera fs = new FSarrera();
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(fs);
            fs.BringToFront();
            fs.Show();
        }
    }
}
