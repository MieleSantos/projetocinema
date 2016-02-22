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
    public partial class FrmSessao : Form
    {
        public FrmSessao()
        {
            InitializeComponent();
        }

        private void btSairSessao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlarbtSessao(bool BoolbtNovoSessao)
        {
            if (BoolbtNovoSessao)
            {
                btNovoSessao.Enabled = true;
                btAlterarSessao.Enabled = true;
                btExcluirSessao.Enabled = true;
                btSairSessao.Enabled = true;
                gbxDadosSessao.Enabled = true;

                btSalvarSessao.Enabled = false;
                btCancelarSessao.Enabled = false;
                gbxSessao.Enabled = false;

            }else
            {
                btNovoSessao.Enabled = false;
                btAlterarSessao.Enabled = false;
                btExcluirSessao.Enabled = false;
                btSairSessao.Enabled = false;
                gbxDadosSessao.Enabled = false;

                btSalvarSessao.Enabled = true;
                btCancelarSessao.Enabled = true;
                gbxSessao.Enabled = true;
            }
        }

        private string ValidaDadosSessao()
        {
         
          string strMensagem = "";

            foreach (Control c in gbxSessao.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "f")
                    {
                        strMensagem = strMensagem + "O campo "  +  c.Tag.ToString()  +  " nao foi preenchido corretamente.\n";                     
                    }
                }
            }

           
            return strMensagem;
        
        }

        private void btSalvarSessao_Click(object sender, EventArgs e)
        {

            string strMsgSessao = ValidaDadosSessao();

            if(strMsgSessao == "")
            {
               try
               {
                   Sessao objSessao = new Sessao();            
                   objSessao.DtDataExibicao = dtdExibicao.Value.Date;
                   objSessao.Dthorario = dthorario.Value;
                   objSessao.IntIdFilme = Convert.ToInt16(cmbIdFilme.SelectedValue.ToString());
                   objSessao.IntCodigoSala = Convert.ToInt16(cmbSalaCinema.SelectedValue.ToString());

                   if (txtNumeroSessao.Text == "")
                   {

                       objSessao.salvar();
                   }
                   else 
                   {
                       objSessao.IntNumeroSessao = Convert.ToInt16(txtNumeroSessao.Text);
                       objSessao.alterar();
                   }
                   controlarbtSessao(true);
                   AtualizaGrid();
                   LimparCampos();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Dados da sessao não foram salvos. \n " + ex.Message);
               }
            }
            else
            {
                MessageBox.Show(strMsgSessao);
            }
        }

        private void dtqDadoSessao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumeroSessao.Text = dgvDadoSessao.Rows[e.RowIndex].Cells[1].Value.ToString();          
            dtdExibicao.Text = dgvDadoSessao.Rows[e.RowIndex].Cells[2].Value.ToString();
            dthorario.Text = dgvDadoSessao.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbIdFilme.SelectedValue = dgvDadoSessao.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbSalaCinema.SelectedValue = dgvDadoSessao.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void FrmSessao_Load(object sender, EventArgs e)
        {
            AtualizaComboBox();
            AtualizaGrid();
            controlarbtSessao(true);
        }

        private void btNovoSessao_Click(object sender, EventArgs e)
        {
            controlarbtSessao(false);
            LimparCampos();
        }

        private void btAlterarSessao_Click(object sender, EventArgs e)
        {
            if(txtNumeroSessao.Text != "")
            {
                controlarbtSessao(false);
            }
            else
            {
                MessageBox.Show(this, "Selecione o registro para alterar","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btCancelarSessao_Click(object sender, EventArgs e)
        {
            controlarbtSessao(true);
            LimparCampos();
        } 

        private void btExcluirSessao_Click(object sender, EventArgs e)
        {
            if (txtNumeroSessao.Text != "")
            {
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastros?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {                   
                        Sessao objsessao = new Sessao();
                        objsessao.IntNumeroSessao = Convert.ToInt16(txtNumeroSessao.Text);
                        objsessao.excluir();
                        LimparCampos();
                        AtualizaGrid();

                        MessageBox.Show(this, "O cadastro foi excluído");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "O cadastro não foi excluído!");
                    }

                }
            }
            else 
            {
                MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumeroSessao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                
            }
            else
            {
                e.Handled = false;
            }

        }

        public void LimparCampos()
        {
            txtNumeroSessao.Text = "";
            dtdExibicao.Value = DateTime.Today;
            dthorario.Value = DateTime.Today;
            cmbIdFilme.Text = "";
            cmbSalaCinema.Text = "";
        }

        private void AtualizaGrid()
        {
            try
            {
                dgvDadoSessao.DataSource = Sessao.recuperarTodosS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro das  sessões. \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void AtualizaComboBox()
        {
            cmbIdFilme.DataSource = Filme.recuperarTodosF();          
            cmbIdFilme.DisplayMember = "Nome";
            cmbIdFilme.ValueMember = "Código";
           
            cmbSalaCinema.DataSource = Cinema.recuperarTodos();
            cmbSalaCinema.DisplayMember = "Nome";
            cmbSalaCinema.ValueMember = "Código";           
        }

    }
}
