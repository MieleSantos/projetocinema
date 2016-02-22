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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();          
        }
   
        private void btPSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesCidade objForm = new FrmPesCidade(this);
            objForm.ShowDialog();                      
        }
 //Recupera as informações dos cinemas que  tem na cidade escolhida  
        private void btnPesCinema_Click(object sender, EventArgs e)
        {     
            dgvPesquisa.DataSource = Cinema.recuperarTodosCinemas(txtPesquisaCidade.Text); 
          
        }
//Recupera o nome do cinema 
        private void dtgPesquisa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
            txtConsultaFilmeP.Text  = dgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();                               
        }
//recupera os filmes que o cinema vai exibir
        private void btVerFilmes_Click(object sender, EventArgs e)
        {
            dtResuPesFilme.DataSource = Filme.BuscaFilme(txtConsultaFilmeP.Text);           
        }
    }
}
