using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using InbentarioaUnmi.Formularioak;


namespace InbentarioaUnmi
{
    public partial class FLogina : Form
    {
        private Erabiltzaileak era;
        public FLogina()
        {
            InitializeComponent();
        }

        private void FLogina_Load(object sender, EventArgs e)
        {
            txtPasahitza.Enabled = false;
            cbSartu.Enabled = false;
            menuStrip1.Visible = false;
            txtErabiltzailea.Focus();
        }
        private void cbIrten_Click_1(object sender, EventArgs e)
        {
             this.Close();
        }
        private void txtErabiltzailea_Leave(object sender, EventArgs e)
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
        private void txtPasahitza_Leave(object sender, EventArgs e)
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
                menuStrip1.Visible = true;
                menuStrip1.Enabled = true;

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
                    menuStrip1.Visible = false;
                    menuStrip1.Enabled = false;
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
                menuStrip1.Visible = false;
                menuStrip1.Enabled = false;
                txtErabiltzailea.Text = "";
                txtPasahitza.Text = "";
                txtErabiltzailea.Focus();
            }
        }

        private void sarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSarrera fs = new FSarrera(era, panelak);
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            panelak.Controls.Add(fs);
            fs.BringToFront();
            fs.Show();
        }

        private void erabiltzaileakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FErabiltzailea fe = new FErabiltzailea(era);
            fe.TopLevel = false;
            fe.Dock = DockStyle.Fill;
            panelak.Controls.Add(fe);
            fe.BringToFront();
            fe.Show();
        }

        private void mintegiakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMintegia fm = new FMintegia(era);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelak.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();
        }
        private void inbentarioaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInbentarioa fi = new FInbentarioa(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panelak.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();
        }

        private void intzidentziakToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FIntzidentziak fi = new FIntzidentziak(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panelak.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();
        }

        private void erabiltzaileaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FErabiltzailea fe = new FErabiltzailea(era);
            fe.TopLevel = false;
            fe.Dock = DockStyle.Fill;
            panelak.Controls.Add(fe);
            fe.BringToFront();
            fe.Show();
        }
    }
}
