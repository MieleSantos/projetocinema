using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace projetocinema.Visao
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        
          this.Hide();
         /* 
           Thread obthread = new Thread(new ThreadStart(exibiSplash));
           // iniciando o objeto thread
            obthread.Start();
            Thread.Sleep(6000);
            obthread.Abort();
            this.Show();*/
        }

        private void exibiSplash() 
        {
            FrmTelaInicio obfrmTelainicio = new FrmTelaInicio();
            obfrmTelainicio.ShowDialog();
      
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }  
    
        private void cinemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormCinema frmCinema = new FormCinema();
           frmCinema.ShowDialog();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilmes frmFilmes = new FormFilmes();
            frmFilmes.ShowDialog();
        }

        private void PesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisa frmPesquisa = new frmPesquisa();
            frmPesquisa.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void sessaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSessao frmSessao = new FrmSessao();
            frmSessao.ShowDialog();
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracao frmConfiguracao = new FrmConfiguracao();
            frmConfiguracao.ShowDialog();
        }


        private void atorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtor frmAtorDiretor = new FrmAtor();
            frmAtorDiretor.ShowDialog();
        }

        private void atuacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtuacao frmAtuaEm = new FrmAtuacao();
            frmAtuaEm.ShowDialog();
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiretor frmDiretor = new FrmDiretor();
            frmDiretor.ShowDialog();
        }

       
    }
}
