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
        public FSarrera(Erabiltzaileak era)
        {
            InitializeComponent();
            this.era = era;
            txtIzena.Text = era.Izena;
            txtMintegia.Text = era.Mintegia.Izena;
            txtIzena.Enabled = false;
            txtMintegia.Enabled = false;
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
    }
}
