using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using InbentarioaUnmi.Formularioak;


namespace InbentarioaUnmi
{
    /// <summary>
    /// Sistemako saio-hasierako (login) interfazea.
    /// Erabiltzailearen autentifikazioa kudeatzen du eta aplikazio nagusira sarbidea ematen du.
    /// </summary>
    public partial class FLogina : Form
    {
        private Erabiltzaileak era;
        private bool txi = false;
        /// <summary>
        /// Login formularioa hasieratzen du.
        /// </summary>
        public FLogina()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Formularioa kargatzean hasierako egoera ezartzen du (kontrolak desgaituta).
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void FLogina_Load(object sender, EventArgs e)
        {
            txtPasahitza.Enabled = false;
            cbSartu.Enabled = false;
            txtErabiltzailea.Focus();
        }
        /// <summary>
        /// Aplikazioa ixten du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbIrten_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Erabiltzaile izena sartuta dagoela egiaztatzen du eta pasahitz eremua aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
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
        /// <summary>
        /// Pasahitza sartuta dagoela egiaztatzen du eta saioa hasteko botoia aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
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
        /// <summary>
        /// Erabiltzailea autentifikatzen du eta saioa hasten du baliozko kredentzialak baditu.
        /// Bestela errore mezua erakusten du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
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
        /// <summary>
        /// Irten botoiaren gainean sagua dagoenean kontrol-fluxua aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Saguaren event argudioak</param>
        private void cbIrten_MouseMove(object sender, MouseEventArgs e)
        {
            this.txi = true;
        }
        /// <summary>
        /// Erabiltzaile eremua aktibatzen du eta kontrol-fluxua berrezartzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Saguaren event argudioak</param>
        private void txtErabiltzailea_MouseMove(object sender, MouseEventArgs e)
        {
            this.txi = false;
            txtErabiltzailea.Focus();
        }
    }
}
