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
    public partial class FInbentarioa : Form
    {
        public FInbentarioa(Erabiltzaileak era)
        {
            InitializeComponent();
        }

        private void cbIrten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FInbentarioa_Load(object sender, EventArgs e)
        {

        }
    }
}
