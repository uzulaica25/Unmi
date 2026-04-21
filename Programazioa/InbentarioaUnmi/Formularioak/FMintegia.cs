using InbentarioaUnmi.DatuBasea;
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
    public partial class FMintegia : Form
    {
        public Erabiltzaileak era;
        public List<Mintegiak> LisMin = new List<Mintegiak>();
        public FMintegia(Erabiltzaileak era)
        {
            this.era = era;
            InitializeComponent();
        }
        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FMintegia_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisMin = MintegiaDB.MintegiakListaratu();
            dgvMintegiak.DataSource = LisMin;
        }
        private void cbGehitu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            string Mizena;
            Mintegiak mi;
            if (cbGehitu.Text == "Gehitu")
            {
                cmbId.Text = "";
                Aktibatu(1);
                cbGehitu.Text = "Gorde";
            }
            else
            {
                while (true)
                {
                    Mizena = txtIzena.Text.Trim();
                    if (string.IsNullOrEmpty(Mizena))
                    {
                        throw new Exception("Mintegiaren izena ezin da hutsik egon.");
                    }
                    else
                    {
                        break;
                    }
                }
                mi = new Mintegiak(Mizena);
                erantzuna = MintegiaDB.MintegiakGehitu(mi);
                if (erantzuna == 1)
                {
                    MessageBox.Show(mi.Izena + " mintegia gehitu da.");
                    Aktibatu(10);
                }
                else
                {
                    MessageBox.Show("Mintegia ez da gehitu. Mesedez, saiatu berriro.");
                    cbGehitu_Click(sender, e);
                }
                cbGehitu.Text = "Gehitu";
            }
        }
        private void cbAldatu_Click_1(object sender, EventArgs e)
        {
            int erantzuna;
            Mintegiak min = null;
            string Mid, berria;

            if (cbAldatu.Text == "Aldatu")
            {
                Aktibatu(2);
                cbAldatu.Text = "Gorde";
            }
            else
            {
                Mid = cmbId.Text;
                foreach (Mintegiak m in LisMin)
                {
                    if (m.Id == Mid)
                    {
                        m.Izena = txtIzena.Text.Trim();
                        min = m;
                        break;
                    }
                }
                erantzuna = MintegiaDB.MintegiakAldatu(min);
                if (erantzuna == 1)
                {
                    MessageBox.Show("Mintegia aldatu da.");
                    Aktibatu(10);
                }
                else
                {
                    MessageBox.Show("Mintegia ez da aldatu. Mesedez, egiaztatu ID-a zuzena dela eta saiatu berriro.");
                    cbAldatu_Click_1(sender, e);
                }
                cbAldatu.Text = "Aldatu";
            }
        }
        private void cbEzabatu_Click_1(object sender, EventArgs e)
        {
            int erantzuna;
            string Mizena, id;
            Mintegiak mi;
            
            if(cbEzabatu.Text == "Ezabatu")
            {
                Aktibatu(3);
                cbEzabatu.Text = "Gorde";
            }
            else
            {
                id = cmbId.Text;
                Mizena = txtIzena.Text.Trim();
                mi = new Mintegiak(id, Mizena);
                DialogResult result = MessageBox.Show("Ziur zaude " + mi.Izena + " mintegia ezabatu nahi duzula? Mintegiarekin batera mintegiaren erabiltzaile eta gailuak ezabatuko dira.", "Berretsi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    erantzuna = MintegiaDB.MintegiakEzabatu(mi);
                    if (erantzuna == 1)
                    {
                        MessageBox.Show("Mintegia ezabatu da.");
                        Aktibatu(10);
                    }
                    else
                    {
                        MessageBox.Show("Mintegia ez da ezabatu. Mesedez, egiaztatu ID-a zuzena dela eta saiatu berriro.");
                        cbEzabatu_Click_1(sender, e);
                    }
                }
                else
                {
                    cbIrten_Click(sender, e);
                }
                cbEzabatu.Text = "Ezabatu";
            }
        }
        private void Desaktibatu()
        {
            // Formularioko elementuak ezkutatzen ditu.

            dgvMintegiak.Visible = false;
            cbGehitu.Visible = false;
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            cbIrten.Visible = true;
            lblId.Visible = false;
            cmbId.Visible = false;
            lblIzena.Visible = false;
            txtIzena.Visible = false;
        }
        private void Aktibatu(int z1)
        {
            Desaktibatu();
            // z1 1=Gehitu, 2=Aldatu, 3=Ezabatu, 10=Gehitu/Aldatu amaitu
            if (z1 == 1)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = false;
                lblIzena.Visible = true;
                txtIzena.Visible = true;
                txtIzena.Text = "";
                cbGehitu.Visible = true;
            }
            else if (z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = true;
                cmbId.DataSource = LisMin;
                cmbId.DisplayMember = "Id";
                lblIzena.Visible = true;
                txtIzena.Visible = true;
                txtIzena.Enabled = false;

                if (z1 == 2)
                {
                    cbAldatu.Visible = true;
                }
                else
                {
                    cbEzabatu.Visible = true;
                }
                cmbId.Focus();
            }
            else if (z1 == 10)
            {
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvMintegiak.Visible = true;
                FMintegia_Load(null, null);
            }
        }

        private void txtIzena_Leave(object sender, EventArgs e)
        {
            bool txi = false;
            while (txi == false)
            {
                txi = false;
                if (string.IsNullOrEmpty(txtIzena.Text.Trim()))
                {
                    MessageBox.Show("Mintegiaren izena ezin da hutsik egon.");
                    txtIzena.Focus();
                    break;
                }
                foreach (Mintegiak m in LisMin)
                {
                    if (m.Izena == txtIzena.Text.Trim())
                    {
                        MessageBox.Show("Mintegiaren izena ezin da errepikatu.");
                        txtIzena.Focus();
                        return;
                    }
                    else
                    {
                        txi = true;
                        break;
                    }
                }
            }
            if (txi == true)
            {
                if (cbGehitu.Text == "Gorde")
                {
                    cbGehitu.Focus();
                }
                else if (cbAldatu.Text == "Gorde")
                {
                    cbAldatu.Focus();
                }
            }
        }

        private void cmbId_Leave(object sender, EventArgs e)
        {
            txtIzena.Enabled = true;
            txtIzena.Focus();
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id;
            Mintegiak m;
            Id = cmbId.Text;
            foreach (Mintegiak min in LisMin)
            {
                if (min.Id == Id)
                {
                    m = min;
                    txtIzena.Text = m.Izena;
                    txtIzena.Enabled = true;
                    txtIzena.Focus();
                    break;
                }
            }
        }
    }
}
