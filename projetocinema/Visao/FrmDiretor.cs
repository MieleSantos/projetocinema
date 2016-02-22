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
    public partial class FrmDiretor : Form
    {
        public FrmDiretor()
        {
            InitializeComponent();
        }

        private void FrmDiretor_Load(object sender, EventArgs e)
        {
            controlabtD(true);
            AtualizaDiretor();
        }

        private void controlabtD(bool boolLiberabtNovo)
        {
            if (boolLiberabtNovo == true)
            {
                btNovoD.Enabled = true;
                btAlterarD.Enabled = true;
                btExcluirD.Enabled = true;
                btSairD.Enabled = true;
                gpxdadosDiretor.Enabled = true;

                btSalvarD.Enabled = false;
                btCancelarD.Enabled = false;
                gbxDiretor.Enabled = false;
            }
            else 
            {
                btNovoD.Enabled = false;
                btAlterarD.Enabled = false;
                btExcluirD.Enabled = false;
                btSairD.Enabled = false;
                gpxdadosDiretor.Enabled = false;

                btSalvarD.Enabled = true;
                btCancelarD.Enabled = true;
                gbxDiretor.Enabled = true;
            }             
        }

        private string validaDadosDiretor() 
        {
            string strMensagem = "";

            foreach (Control c in gbxDiretor.Controls) 
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "p")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + "não foi preenchido corretamente.\n";
                    }                
                }             
            }
            return strMensagem;
        
        }

        private void btSalvarD_Click(object sender, EventArgs e)
        {
            string strDiretor = validaDadosDiretor();

            if (strDiretor == "")
            {
                try
                {
                    Diretor objDiretor = new Diretor();
                    objDiretor.StrNome = txtNomeD.Text;

                    if (txtCodigoD.Text == "")
                    {
                        objDiretor.salvar();
                    }
                    else
                    {
                        objDiretor.IntCodDiretor = Convert.ToInt16(txtCodigoD.Text);
                        objDiretor.alterar();
                    }
                    controlabtD(true);
                    AtualizaDiretor();
                    LimpaCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dados do diretor nao foram salvos. \n " + ex.Message);
                }
            }
            else 
            {
                MessageBox.Show(strDiretor);
            }

        }

        private void dtgDiretor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoD.Text = dtgDiretor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeD.Text = dtgDiretor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btNovoD_Click(object sender, EventArgs e)
        {
            controlabtD(false);
            LimpaCampos();

        }

        private void btAlterarD_Click(object sender, EventArgs e)
        {
            if (txtCodigoD.Text != "")
            {
                controlabtD(false);
                AtualizaDiretor();
            }
            else 
            {
                MessageBox.Show(this, "Selecione o registro que deseja alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpaCampos() 
        {
            txtCodigoD.Text = "";
            txtNomeD.Text = "";
        }

        private void btCancelarD_Click(object sender, EventArgs e)
        {
            controlabtD(true);
            LimpaCampos();
        }

        private void btExcluirD_Click(object sender, EventArgs e)
        {
            if (txtCodigoD.Text != "") 
            {
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastros?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes) 
                {
                    try
                    {
                        Diretor objDiretor = new Diretor();
                        objDiretor.IntCodDiretor = Convert.ToInt16(txtCodigoD.Text);
                        objDiretor.excluir();
                        AtualizaDiretor();
                        LimpaCampos();

                        MessageBox.Show(this, "O registro foi excluído");
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(this, "o registro não foi excluído");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              
            }
        }

        private void AtualizaDiretor()
        {
            try
            {
                dtgDiretor.DataSource = Diretor.recuperarTodos();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro dos diretores. \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void txtConcultaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                dtgDiretor.DataSource = Diretor.recuperarTodosFiltroD(txtConcultaD.Text);
            }
        }

        private void txtConcultaD_TextChanged(object sender, EventArgs e)
        {
            dtgDiretor.DataSource = Diretor.recuperarTodosFiltroD(txtConcultaD.Text);
        }

        private void btSairD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeD_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
