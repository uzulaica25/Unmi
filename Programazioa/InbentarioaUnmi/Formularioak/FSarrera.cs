using InbentarioaUnmi.DatuModeloak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InbentarioaUnmi.Formularioak
{
    public partial class FSarrera : Form
    {
        private Erabiltzaileak era;
        private Panel panela;
        public FSarrera(Erabiltzaileak era, Panel panela)
        {
            InitializeComponent();
            this.panela = panela;
            this.era = era;
            txtIzena.Text = era.Izena;
            txtMintegia.Text = era.Mintegia.Izena;
            txtIzena.Enabled = false;
            txtMintegia.Enabled = false;
            txtRola.Enabled = false;
            if (era.Rola == "Irakaslea")
            {
                cbInbentarioa.Enabled = true;
                cbIntzidentziak.Enabled = true;
                cbMintegia.Visible = false;
                cbErabiltzailea.Visible = false;
                txtRola.Text = era.Rola;
            }
            else if (era.Rola == "MintegiBurua")
            {
                cbInbentarioa.Enabled = true;
                cbIntzidentziak.Enabled = true;
                cbMintegia.Visible = false;
                cbErabiltzailea.Enabled = true;
                cbErabiltzailea.Visible = true;
                txtRola.Text = "Mintegi burua";
            }
            else if (era.Rola == "IKTArduraduna")
            {
                cbInbentarioa.Enabled = true;
                cbIntzidentziak.Enabled = true;
                cbMintegia.Enabled = true;
                cbErabiltzailea.Enabled = true;
                cbInbentarioa.Visible = true;
                cbIntzidentziak.Visible = true;
                cbMintegia.Visible = true;
                cbErabiltzailea.Visible = true;
                txtRola.Text = "IKT arduraduna";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void FSarrera_Load(object sender, EventArgs e)
        {
            cbInbentarioa.Focus();
        }

        private void cbInbentarioa_Click(object sender, EventArgs e)
        {
            FInbentarioa fi = new FInbentarioa(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panela.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();

        }

        private void cbIntzidentziak_Click(object sender, EventArgs e)
        {
            FIntzidentziak fi = new FIntzidentziak(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panela.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();
        }

        private void cbMintegia_Click(object sender, EventArgs e)
        {
            FMintegia fm = new FMintegia(era);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panela.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();
        }

        private void cbErabiltzailea_Click(object sender, EventArgs e)
        {
            FErabiltzailea fe = new FErabiltzailea(era);
            fe.TopLevel = false;
            fe.Dock = DockStyle.Fill;
            panela.Controls.Add(fe);
            fe.BringToFront();
            fe.Show();
        }

    }
}
