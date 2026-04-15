using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using InbentarioaUnmi.Formularioak;


namespace InbentarioaUnmi
{
    public partial class FLogina : Form
    {
        private Erabiltzaileak era;
        private bool txi = false;
        public FLogina()
        {
            InitializeComponent();
        }
        private void FLogina_Load(object sender, EventArgs e)
        {
            txtPasahitza.Enabled = false;
            cbSartu.Enabled = false;
            txtErabiltzailea.Focus();
        }
        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtErabiltzailea_Leave(object sender, EventArgs e)
        {
            if (txi)
            {
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtErabiltzailea.Text))
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
        }
        private void txtPasahitza_Leave(object sender, EventArgs e)
        {
            if (txi)
            {
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPasahitza.Text))
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
           
        }
        private void cbSartu_Click_1(object sender, EventArgs e)
        {
            Erabiltzaileak era;
            era = ErabiltzaileaDB.ErabiltzaileaBilatu(txtErabiltzailea.Text, txtPasahitza.Text);
            this.era = era;
            if (era != null)
            {
                FSarrera fs = new FSarrera(era, panelak);
                fs.TopLevel = false;
                fs.Dock = DockStyle.Fill;
                panelak.Controls.Add(fs);
                fs.BringToFront();
                fs.Show();

                lblErabiltzailea.Visible = false;
                lblPasahitza.Visible = false;
                txtErabiltzailea.Visible = false;
                txtPasahitza.Visible = false;
                cbSartu.Visible = false;
                cbIrten.Visible = false;
                fs.FormClosed += (s, args) =>
                {
                    lblErabiltzailea.Visible = true;
                    lblPasahitza.Visible = true;
                    txtErabiltzailea.Visible = true;
                    txtPasahitza.Visible = true;
                    cbIrten.Visible = true;
                    cbSartu.Visible = true;
                    txtErabiltzailea.Text = "";
                    txtPasahitza.Text = "";
                    txtErabiltzailea.Focus();
                };
            }
            else
            {
                MessageBox.Show("Erabiltzaile edo pasahitz okerra");
                lblErabiltzailea.Visible = true;
                lblPasahitza.Visible = true;
                txtErabiltzailea.Visible = true;
                txtPasahitza.Visible = true;
                cbIrten.Visible = true;
                cbSartu.Visible = true;
                txtErabiltzailea.Text = "";
                txtPasahitza.Text = "";
                txtErabiltzailea.Focus();
            }
        }
        private void txtErabiltzailea_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbIrten_MouseDown(object sender, MouseEventArgs e)
        {
        
        }
        private void cbIrten_MouseMove(object sender, MouseEventArgs e)
        {
            this.txi = true;
        }
    }
}
