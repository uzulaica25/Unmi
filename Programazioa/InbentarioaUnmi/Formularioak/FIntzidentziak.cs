using InbentarioaUnmi.DatuBasea;
using InbentarioaUnmi.DatuModeloak;
using Mysqlx.Crud;
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
    /// Intzidentzien kudeaketarako Windows Forms interfazea.
    /// Intzidentziak gehitu, aldatu, ezabatu eta bilatzeko funtzionalitatea eskaintzen du.
    /// </summary>
    public partial class FIntzidentziak : Form
    {
        public List<Intzidentziak> LisInt = new List<Intzidentziak>();
        public Erabiltzaileak era;

        /// <summary>
        /// Intzidentzien formulario berria sortzen du erabiltzailearen informazioarekin.
        /// </summary>
        /// <param name="era">Saioa hasi duen erabiltzailea</param>
        public FIntzidentziak(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Formularioa kargatzean hasierako datuak eta baimenak konfiguratzen ditu.
        /// Erabiltzailearen rolaren arabera aukerak mugatzen ditu.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void FIntzidentziak_Load(object sender, EventArgs e)
        {
            if (era.Rola == "Irakaslea")
            {
                cbGehitu.Visible = false;
                cbAldatu.Visible = false;
                cbEzabatu.Visible = false;
                cbAurkitu.Visible = false;
                cbIrten.Visible = true;
                cbIrten.Focus();
            }
            cbGehitu.Focus();
            LisInt = intzidentziakDB.IntzidentziakZerrendatu(era);
            dgvIntzidentziak.DataSource = LisInt;
        }
        /// <summary>
        /// Intzidentzia berri bat gehitzen du edo gehitzeko modua aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbGehitu_Click(object sender, EventArgs e)
        {
            Intzidentziak intz;
            Gailuak g;
            DateOnly data;
            string mezua;
            int eran;

            Desaktibatu();
            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                Aktibatu(1);
                cbGehitu.Enabled = true;
            }
            else
            {
                g = (Gailuak)cmbGailua.SelectedItem;
                data = DateOnly.FromDateTime(dtpData.Value);
                mezua = txtMezua.Text;

                intz = new Intzidentziak("aa", g, " ", data, mezua);

                eran = intzidentziakDB.IntzidentziaGehitu(intz);

                if (eran == 1)
                {
                    MessageBox.Show("Intzidentzia gehitu da.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Intzidentzia ez da gehitu.");
                }
                cbGehitu.Text = "Gehitu";
            }
        }
        /// <summary>
        /// Hautatutako intzidentzia bat eguneratzen du edo edizio modua aktibatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbAldatu_Click(object sender, EventArgs e)
        {
            List<Gailuak> LisGai = new List<Gailuak>();
            Gailuak g = null;
            Intzidentziak intz, intzidentzia;
            DateOnly data;
            string mezua, id;
            int eran;

            Desaktibatu();
            if (cbAldatu.Text == "Aldatu")
            {
                cbAldatu.Text = "Gorde";
                Aktibatu(2);
            }
            else
            {
                intzidentzia = (Intzidentziak)cmbId.SelectedItem;
                id = cmbGailua.SelectedValue.ToString();
                foreach (Gailuak g1 in cmbGailua.Items)
                {
                    if (g1.Id == id)
                    {
                        g = g1;
                        break;
                    }
                }
                data = DateOnly.FromDateTime(dtpData.Value);
                mezua = txtMezua.Text;

                intz = new Intzidentziak(cmbId.Text, g, " ", data, mezua);

                eran = intzidentziakDB.IntzidentziaAldatu(intz, intzidentzia);
                if (eran == 1)
                {
                    MessageBox.Show("Intzidentzia eguneratu da.");
                    this.Close();
                    cbAldatu.Text = "Aldatu";
                }
                else
                {
                    MessageBox.Show("Intzidentzia ez da eguneratu.");
                    cbAldatu.Text = "Aldatu";
                    cbAldatu_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// Hautatutako intzidentzia bat ezabatzen du edo ezabatzeko baieztapena eskatzen du.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            Intzidentziak intzidentzia;
            int eran;

            Desaktibatu();
            if (cbEzabatu.Text == "Ezabatu")
            {
                cbEzabatu.Text = "Bai";
                Aktibatu(3);
            }
            else
            {
                intzidentzia = (Intzidentziak)cmbId.SelectedItem;
                eran = intzidentziakDB.IntzidentziaEzabatu(intzidentzia);
                if (eran == 1)
                {
                    MessageBox.Show("Intzidentzia ezabatu da.");
                    this.Close();
                    cbEzabatu.Text = "Ezabatu";
                }
                else
                {
                    MessageBox.Show("Intzidentzia ez da ezabatu.");
                }
            }
        }
        /// <summary>
        /// Gailu baten arabera intzidentziak bilatzen ditu eta datu-taulan erakusten ditu.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cbAurkitu_Click(object sender, EventArgs e)
        {
            List<Gailuak> LisGai = new List<Gailuak>();
            List<Intzidentziak> Intzi = new List<Intzidentziak>();
            Gailuak g;

            Desaktibatu();
            if (cbAurkitu.Text == "Aurkitu")
            {
                Aktibatu(4);
                LisGai = InbentarioaDB.GailuakListaratu(era);
                cmbGailua.DataSource = LisGai;
                cmbGailua.DisplayMember = "Id";
                cbAurkitu.Text = "Bilatu";
            }
            else
            {
                g = (Gailuak)cmbGailua.SelectedItem;
                Intzi = intzidentziakDB.IntzidentziaAurkitu(g);
                if (Intzi.Count == 0)
                {
                    MessageBox.Show("Ez da intzidentzia aurkitu.");
                    this.Close();
                    return;
                }
                else
                {
                    dgvIntzidentziak.Visible = true;
                    dgvIntzidentziak.DataSource = Intzi;
                    cbAurkitu.Text = "Aurkitu";
                }
            }
        }
        /// <summary>
        /// Formularioaren kontrol guztiak ezkutatu edo desaktibatzen ditu.
        /// </summary>
        private void Desaktibatu()
        {
            // Formularioko elementuak ezkutatzen ditu.

            dgvIntzidentziak.Visible = false;
            cbGehitu.Visible = false;
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            cbAurkitu.Visible = false;
            cbIrten.Visible = true;
            lblId.Visible = false;
            cmbId.Visible = false;
            lblMezua.Visible = false;
            txtMezua.Visible = false;
            lblData.Visible = false;
            dtpData.Visible = false;
            lblGailua.Visible = false;
            cmbGailua.Visible = false;
        }
        /// <summary>
        /// Formularioaren kontrolak aktibatzen ditu aukeratutako ekintzaren arabera.
        /// </summary>
        /// <param name="z1">Eragiketa mota (1=gehitu, 2=aldatu, 3=ezabatu, 4=bilatu)</param>
        private void Aktibatu(int z1)
        {
            List<Gailuak> LisGai = new List<Gailuak>();

            // z1 1=Gehitu, 2=Aldatu, 3=Ezabatu, 4=Aurkitu
            if (z1 == 1 || z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = true;
                cmbId.DataSource = LisInt;
                cmbId.DisplayMember = "Id";
                cmbId.SelectedIndex = -1;
                lblMezua.Visible = true;
                txtMezua.Visible = true;
                txtMezua.Text = "";
                txtMezua.Enabled = false;
                lblData.Visible = true;
                dtpData.Visible = true;
                dtpData.Enabled = false;
                lblGailua.Visible = true;
                cmbGailua.Visible = true;
                cmbGailua.Enabled = false;
                LisGai = InbentarioaDB.GailuakListaratu(era);
                cmbGailua.DataSource = LisGai;
                cmbGailua.DisplayMember = "Id";
                cmbGailua.SelectedIndex = -1;
                if (z1 == 1)
                {
                    cmbGailua.Enabled = true;
                    dtpData.Enabled = true;
                    txtMezua.Enabled = true;
                    cmbGailua.Focus();
                    cmbId.Enabled = false;
                    cbGehitu.Visible = true;
                }
                else if (z1 == 2)
                {
                    cmbId.Focus();
                    cbAldatu.Visible = true;
                }
                else
                {
                    cmbId.Focus();
                    cbEzabatu.Visible = true;
                }
            }
            else if (z1 == 4)
            {
                lblGailua.Visible = true;
                cmbGailua.Visible = true;
                LisGai = InbentarioaDB.GailuakListaratu(era);
                cmbGailua.DataSource = LisGai;
                cmbGailua.DisplayMember = "Id";
                cmbGailua.SelectedIndex = -1;
                cbAurkitu.Visible = true;
            }
        }
        /// <summary>
        /// ID konbinazio-koadroaren aukeraketa aldaketaren gertakaria.
        /// (Momentuz funtzionalitaterik gabe)
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// ID eremutik irtetean balidazioa egiten du eta beste kontrol batzuk aktibatzen ditu.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cmbId_Leave(object sender, EventArgs e)
        {
            if (cbEzabatu.Text == "Bai")
            {
                cbEzabatu.Focus();
            }
            else
            {
                if (cmbId.SelectedItem != null)
                {
                    cmbId.Enabled = false;
                    txtMezua.Enabled = true;
                    dtpData.Enabled = true;
                    cmbGailua.Enabled = true;
                    cmbGailua.Focus();
                }
            }
        }
        /// <summary>
        /// Aukeratutako intzidentziaren datuak formularioan kargatzen ditu.
        /// </summary>
        /// <param name="sender">Jatorrizko objektua</param>
        /// <param name="e">Event argudioak</param>
        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            Intzidentziak intzidentziak = null;
            intzidentziak = (Intzidentziak)cmbId.SelectedItem;
            if (intzidentziak != null)
            {
                txtMezua.Text = intzidentziak.Mezua;
                dtpData.Value = intzidentziak.Data.ToDateTime(new TimeOnly(0, 0));
                cmbGailua.Text = intzidentziak.Gailua.Id;
            }
        }
    }
}
