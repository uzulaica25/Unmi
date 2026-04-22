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
    public partial class FIntzidentziak : Form
    {
        public List<Intzidentziak> LisInt = new List<Intzidentziak>();
        public Erabiltzaileak era;
        public FIntzidentziak(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIntzidentziak_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisInt = intzidentziakDB.IntzidentziakZerrendatu(era);
            dgvIntzidentziak.DataSource = LisInt;
        }

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
                    Aktibatu(10);
                }
                else
                {
                    MessageBox.Show("Intzidentzia ez da gehitu.");
                }
                cbGehitu.Text = "Gehitu";
            }
        }

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
                    Aktibatu(10);
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
                    Aktibatu(10);
                    cbEzabatu.Text = "Ezabatu";
                }
                else
                {
                    MessageBox.Show("Intzidentzia ez da ezabatu.");
                }
            }
        }

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
                    Aktibatu(10);
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

        private void Aktibatu(int z1)
        {
            List<Gailuak> LisGai = new List<Gailuak>();

            // z1 1=Gehitu, 2=Aldatu, 3=Ezabatu, 4=Aurkitu, 10=Gehitu/Aldatu amaitu
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
            else if (z1 == 10)
            {
                Desaktibatu();
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                cbAurkitu.Visible = true;
                dgvIntzidentziak.Visible = true;
                FIntzidentziak_Load(null, null);
            }
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

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

        private void cmbId_SelectedValueChanged(object sender, EventArgs e)
        {
            Intzidentziak intzidentziak = null;
            intzidentziak = (Intzidentziak)cmbId.SelectedItem;
            if(intzidentziak != null)
            {
                txtMezua.Text = intzidentziak.Mezua;
                dtpData.Value = intzidentziak.Data.ToDateTime(new TimeOnly(0, 0));
                cmbGailua.Text = intzidentziak.Gailua.Id;
            }
        }
    }
}
