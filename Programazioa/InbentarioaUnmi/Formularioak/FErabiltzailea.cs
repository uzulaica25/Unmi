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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InbentarioaUnmi.Formularioak
{
    public partial class FErabiltzailea : Form
    {
        public List<Erabiltzaileak> LisEra = new List<Erabiltzaileak>();
        public Erabiltzaileak era;
        public FErabiltzailea(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FErabiltzailea_Load(object sender, EventArgs e)
        {
            cbGehitu.Focus();
            LisEra.Clear();
            LisEra = ErabiltzaileaDB.ErabiltzaileaZerrendatu();
            dgvErabiltzaileak.DataSource = null;
            if (era.Rola == "MintegiBurua")
            {
                var filtrado = LisEra.Where(x => x.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvErabiltzaileak.DataSource = filtrado;

            }
            else
            {
                dgvErabiltzaileak.DataSource = LisEra;
            }
            dgvErabiltzaileak.ReadOnly = true;
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {
            int eragiketa;
            string Eizena, pas, rola = " ", min;
            Erabiltzaileak er;
            Mintegiak mintegia;

            if (cbGehitu.Text == "Gehitu")
            {
                cbGehitu.Text = "Gorde";
                Aktibatu(1);
            }
            else
            {
                Eizena = txtErabiltzailea.Text;
                pas = txtPasahitza.Text;
                rola = cmbRola.Text;
                min = cmbMintegia.Text;
                mintegia = MintegiaDB.MintegiaBilatu(min);
                er = new Erabiltzaileak(Eizena, pas, mintegia, rola);
                eragiketa = ErabiltzaileaDB.ErabiltzaileaGehitu(er);
                if (eragiketa == 1)
                {
                    MessageBox.Show(Eizena + " erabiltzailea gehitu da.");
                    Aktibatu(10);
                }
                else
                {
                    MessageBox.Show("Erabiltzailea ez da gehitu. Mesedez, saiatu berriro.");
                    cbGehitu_Click(sender, e);
                }
            }
        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            Erabiltzaileak er;
            Mintegiak mintegia;
            string Id, pas, erab, rola, min;

            if (cbAldatu.Text == "Aldatu")
            {
                cbAldatu.Text = "Gorde";
                Aktibatu(2);
            }
            else
            {
                Id = cmbId.Text;
                erab = txtErabiltzailea.Text;
                pas = txtPasahitza.Text;
                rola = cmbRola.Text;
                min = cmbMintegia.Text;
                mintegia = MintegiaDB.MintegiaBilatu(min);
                if (rola == "MintegiBurua")
                {
                    foreach(var usu in LisEra)
                    {
                        if (usu.Rola == rola && usu.Mintegia.Id == min)
                        {
                            MessageBox.Show("Mintegi horrek jada badu mintegi burua");
                            return;
                        }
                    }
                }
                er = new Erabiltzaileak(Id, erab, pas, mintegia, rola);
                erantzuna = ErabiltzaileaDB.ErabiltzaileaAldatu(er);
                if (erantzuna == 1)
                {
                    MessageBox.Show(er.Izena + " erabiltzailearen datuak aldatu dira.");
                    Aktibatu(10);
                }
                else
                {
                    MessageBox.Show("Erabiltzailea ez da aldatu. Mesedez, saiatu berriro.");
                    cbAldatu_Click(sender, e);
                }
                cbAldatu.Text = "Aldatu";
            }
        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {
            int erantzuna;
            string Eid;
            Erabiltzaileak er = null;
            if (cbEzabatu.Text == "Ezabatu")
            {
                cbEzabatu.Text = "Bai";
                Aktibatu(3);
            }
            else
            {
                Eid = cmbId.Text;
                if (Eid == era.Id)
                {
                    MessageBox.Show("Ezin duzu zure erabiltzailea ezabatu. Mesedez, sartu beste bat.");
                    cmbId.Focus();
                    return;
                }
                else
                {

                    foreach (var item in LisEra)
                    {
                        if (item.Id == Eid)
                        {
                            er = item;
                            break;
                        }
                    }
                    erantzuna = ErabiltzaileaDB.ErabiltzaileaEzabatu(er);
                    if (erantzuna == 1)
                    {
                        MessageBox.Show("Erabiltzailea ezabatu da.");
                        Aktibatu(10);
                    }
                    else
                    {
                        MessageBox.Show("Erabiltzailea ez da ezabatu. Mesedez, saiatu berriro.");
                        cbEzabatu_Click(sender, e);
                    }
                }
            }
        }

        private void cmbMintegia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Desaktibatu()
        {
            // Formularioko elementuak ezkutatzen ditu.

            dgvErabiltzaileak.Visible = false;
            cbGehitu.Visible = false;
            cbAldatu.Visible = false;
            cbEzabatu.Visible = false;
            cbIrten.Visible = true;
            lblId.Visible = false;
            cmbId.Visible = false;
            lblErabiltzailea.Visible = false;
            txtErabiltzailea.Visible = false;
            lblPasahitza.Visible = false;
            txtPasahitza.Visible = false;
            lblRola.Visible = false;
            cmbRola.Visible = false;
            cmbMintegia.Visible = false;
            lblMintegia.Visible = false;
        }

        private void Aktibatu(int z1)
        {
            Desaktibatu();
            // z1 1=Gehitu, 2=Aldatu, 3=Ezabatu, 10=Hasiera panela
            if (z1 == 1 ||z1 == 2 || z1 == 3)
            {
                lblId.Visible = true;
                cmbId.Visible = true;
                cmbId.Enabled = true;
                cmbId.DataSource = LisEra;
                cmbId.DisplayMember = "Id";
                cmbId.ValueMember = "Id";
                cmbId.SelectedIndex = -1;
                lblErabiltzailea.Visible = true;
                txtErabiltzailea.Visible = true;
                txtErabiltzailea.Enabled = false;
                txtErabiltzailea.Text = "";
                lblPasahitza.Visible = true;
                txtPasahitza.Visible = true;
                txtPasahitza.Enabled = false;
                txtPasahitza.Text = "";
                lblRola.Visible = true;
                cmbRola.Visible = true;
                cmbRola.Enabled = false;
                cmbRola.SelectedIndex = -1;
                lblMintegia.Visible = true;
                cmbMintegia.Visible = true;
                cmbMintegia.Enabled = false;
                MintegiakKargatu();

                if (z1 == 2)
                {
                    cbAldatu.Visible = true;
                    cmbId.Focus();
                }
                else if (z1 == 3)
                {
                    cbEzabatu.Visible = true;
                    cmbId.Focus();
                }else
                {
                    txtErabiltzailea.Enabled = true;
                    txtPasahitza.Enabled = true;
                    cmbRola.Enabled = true;
                    cmbMintegia.Enabled = true;
                    cmbId.Enabled = false;
                    cbGehitu.Visible = true;
                    cbGehitu.Enabled = false;
                }
                
            }
            else if (z1 == 10)
            {
                cbGehitu.Visible = true;
                cbAldatu.Visible = true;
                cbEzabatu.Visible = true;
                dgvErabiltzaileak.Visible = true;
                FErabiltzailea_Load(null, null);
            }
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;

            id = cmbId.Text;
            foreach (var item in LisEra)
            {
                if (item.Id == id)
                {
                    txtErabiltzailea.Text = item.Izena;
                    txtPasahitza.Text = item.Pasahitza;
                    cmbRola.Text = item.Rola;
                    cmbMintegia.Text = item.Mintegia.Id;
                    break;
                }
            }
        }

        private void txtErabiltzailea_Leave(object sender, EventArgs e)
        {
            string t;
            bool txi = false;
            if (!string.IsNullOrWhiteSpace(txtErabiltzailea.Text) && cbGehitu.Text == "Gorde")
            {
                t = txtErabiltzailea.Text;
                foreach (var item in LisEra)
                {
                    if (item.Izena == t)
                    {
                        MessageBox.Show("Erabiltzaile izen hori dagoeneko existitzen da. Mesedez, sartu beste bat.");
                        txtErabiltzailea.Text = "";
                        txtErabiltzailea.Focus();
                        txi = true;
                        break;
                    }
                }
                if (txi)
                {
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
            string t;
            if (!string.IsNullOrWhiteSpace(txtPasahitza.Text))
            {
                t = txtPasahitza.Text;
                if (t.Length < 8)
                {
                    MessageBox.Show("Pasahitzak gutxienez 8 karaktere izan behar ditu. Mesedez, sartu beste bat.");
                    txtPasahitza.Text = "";
                    txtPasahitza.Focus();
                }
                else
                {
                    cmbRola.Enabled = true;
                    cmbRola.Focus();
                }
            }
        }

        private void cmbRola_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRola.Text))
            {
                cmbMintegia.Enabled = true;
                cmbMintegia.Focus();
            }
        }

        private void cmbMintegia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbMintegia.Text))
            {
                cbGehitu.Enabled = true;
                cbGehitu.Focus();
            }
        }

        private void cmbId_Leave(object sender, EventArgs e)
        {
            cmbId.Enabled = false;
            if (cbAldatu.Text == "Gorde")
            {
                txtErabiltzailea.Enabled = true;
                txtPasahitza.Enabled = true;
                cmbRola.Enabled = true;
                cmbMintegia.Enabled = true;
                txtErabiltzailea.Focus();
            }
            else
            {
                cbEzabatu.Focus();
            }
        }

        private void MintegiakKargatu()
        {
            var lisMin = MintegiaDB.MintegiakListaratu();
            cmbMintegia.DataSource = lisMin;
            cmbMintegia.DisplayMember = "Izena";
            cmbMintegia.ValueMember = "Id";
            cmbMintegia.SelectedIndex = -1;
        }
    }
}
