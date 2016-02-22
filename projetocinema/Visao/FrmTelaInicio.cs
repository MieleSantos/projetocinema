using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetocinema.Visao
{
    public partial class FrmTelaInicio : Form
    {
        public FrmTelaInicio()
        {
            InitializeComponent();
            tmhoras.Enabled = true;

        }

        private void tmhoras_Tick(object sender, EventArgs e)
        {
            try
            {
                prbStatus.Value += 2;
                lbStatus.Text = prbStatus.Value.ToString() + "%";
            }
            catch (Exception ex)
            {
                prbStatus.Value = 100;
                lbStatus.Text = prbStatus.Value.ToString() + "%";
                tmhoras.Enabled = false;

               
            }
        }
    }
}
