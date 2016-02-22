using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetocinema.Util;
using projetocinema.ConexaoBD;

namespace projetocinema.Visao
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        private bool salvarDados() 
        {
            try
            {
                Registro objReg = new Registro();

                objReg.setValor("Servidor", txtServidor.Text);
                objReg.setValor("Porta", txctPortaConexao.Text);
                objReg.setValor("Login", txtBancoUsuario.Text);
                objReg.setValor("Senha", txtSenha.Text);
                objReg.setValor("Banco", txtBancoDados.Text);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void btSairBanco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarDados_Click(object sender, EventArgs e)
        {
            if (salvarDados()) 
            {
                MessageBox.Show("Dados de conexão com o banco foram salvos!");
            }
        }

        private void btTestaConexao_Click(object sender, EventArgs e)
        {
            string strMsg = "";

            salvarDados();

            BancoOracle.GetInstancia().desconectar();

            if (BancoOracle.GetInstancia().TestaConexao())
            {
                strMsg = "Conexão estabelecida com sucesso!";
            }
            else 
            {
                strMsg = "Conexão não estabelecida com sucesso!" + BancoOracle.GetInstancia().GetErro();
            }

            MessageBox.Show(strMsg);
        }

        private void txtServidor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txctPortaConexao_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBancoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBancoDados_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }     
    }
}
