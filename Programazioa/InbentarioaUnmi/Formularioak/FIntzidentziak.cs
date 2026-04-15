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
            LisInt = intzidentziakDB.IntzidentziakZerrendatu();

            if (era.Rola == "Irakaslea")
            {
                cbGehitu.Visible = false;
                cbAldatu.Visible = false;
                cbEzabatu.Visible = false;
                var filtrado = LisInt.Where(x => x.Gailua.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvintzidentziak.DataSource = filtrado;

            }
            else if (era.Rola == "MintegiBurua")
            {
                var filtrado = LisInt.Where(x => x.Gailua.Mintegia.Id == era.Mintegia.Id).ToList();
                dgvintzidentziak.DataSource = filtrado;
                
            }
            else
            {
                dgvintzidentziak.DataSource = LisInt;
            }
        }

        private void cbGehitu_Click(object sender, EventArgs e)
        {

        }

        private void cbAldatu_Click(object sender, EventArgs e)
        {

        }

        private void cbEzabatu_Click(object sender, EventArgs e)
        {

        }
    }
}
