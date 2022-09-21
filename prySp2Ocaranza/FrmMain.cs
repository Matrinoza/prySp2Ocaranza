using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySp2Ocaranza
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipo.SelectedIndex != -1) // metodo de habilitacion 
            {
                CmbPersonas.Enabled = true;
            }
        }

        private void CmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPersonas.SelectedIndex != -1)
            {
                TxtDias.Enabled = true;
            }
        }

        private void TxtDias_TextChanged(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                MrcAdcionales.Enabled = true;
                MrcPago.Enabled = true;
            }
        }

        private void RbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            RbTarjeta.Enabled = true;
            CmbTarjeta.SelectedIndex = 0;
        }
    }
}
