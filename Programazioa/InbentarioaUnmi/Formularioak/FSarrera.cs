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
    /// <summary>
    /// Saioaren sarrera nagusiko formularioa.
    /// Erabiltzailearen rolaren arabera menu nagusiko aukerak erakusten ditu.
    /// </summary>
    public partial class FSarrera : Form
    {
        private Erabiltzaileak era;
        private Panel panela;
        /// <summary>
        /// FSarrera formularioa hasieratzen du eta erabiltzailearen datuak pantailan kargatzen ditu.
        /// Rolaren arabera funtzionalitate desberdinak aktibatzen ditu.
        /// </summary>
        /// <param name="era">Saioa hasita duen erabiltzailea</param>
        /// <param name="panela">Nabigazio panel nagusia</param>
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
        /// <summary>
        /// Saioaren sarrera formularioa ixten du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        /// <summary>
        /// Formularioa kargatzean lehen aukera aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void FSarrera_Load(object sender, EventArgs e)
        {
            cbInbentarioa.Focus();
        }
        /// <summary>
        /// Inbentarioaren formularioa irekitzen du eta panel nagusian kargatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbInbentarioa_Click(object sender, EventArgs e)
        {
            FInbentarioa fi = new FInbentarioa(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panela.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();

        }
        /// <summary>
        /// Intzidentzien kudeaketa formularioa irekitzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbIntzidentziak_Click(object sender, EventArgs e)
        {
            FIntzidentziak fi = new FIntzidentziak(era);
            fi.TopLevel = false;
            fi.Dock = DockStyle.Fill;
            panela.Controls.Add(fi);
            fi.BringToFront();
            fi.Show();
        }
        /// <summary>
        /// Mintegien kudeaketa formularioa irekitzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbMintegia_Click(object sender, EventArgs e)
        {
            FMintegia fm = new FMintegia(era);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panela.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();
        }
        /// <summary>
        /// Erabiltzaileen kudeaketa formularioa irekitzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
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
