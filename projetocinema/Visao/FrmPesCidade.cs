using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetocinema.Modelo;

namespace projetocinema.Visao
{
    public partial class FrmPesCidade : Form
    {
        private frmPesquisa formPaiInstancia;

        public FrmPesCidade(frmPesquisa formPai)
        {
            InitializeComponent();
            formPaiInstancia = formPai;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cidade = dgvCidades.CurrentRow.Cells[0].Value.ToString();
            formPaiInstancia.txtPesquisaCidade.Text = cidade;
            this.Close();
        }

        private void FrmPesCidade_Load(object sender, EventArgs e)
        {              
            // falar que o datagridview recebe os dados do metodo selecionattodasCidades da classe cinema
            //implementar essa parte
            dgvCidades.DataSource = Cinema.recuperarTodoasCidades();
        }

        
    }
}
