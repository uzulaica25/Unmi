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
            if(era.Rola != " ")
            {
                cbInbentarioa.Enabled = true;
                cbIntzidentziak.Enabled = true;
                cbMintegia.Enabled = true;
                cbErabiltzailea.Enabled = true;
            }
             else
            {
                cbInbentarioa.Enabled = true;
                cbIntzidentziak.Enabled = true;
                cbMintegia.Enabled = false;
                cbErabiltzailea.Enabled = false;
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
