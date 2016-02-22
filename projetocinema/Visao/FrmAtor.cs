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
    public partial class FrmAtor : Form
    {
        public FrmAtor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void controlabtAtor(bool boolLiberabtNovo)
        {
            if (boolLiberabtNovo == true)
            {
                btAtorNovo.Enabled = true;
                btAtorAlterar.Enabled = true;
                btAtorExcluir.Enabled = true;
                btAtorSair.Enabled = true;
                gbAtorDados.Enabled = true;


                btAtorSalvar.Enabled = false;
                btAtorCancelar.Enabled = false;
                gbAtor.Enabled = false;
            }
            else
            {
                btAtorNovo.Enabled = false;
                btAtorAlterar.Enabled = false;
                btAtorExcluir.Enabled = false;
                btAtorSair.Enabled = false;
                gbAtorDados.Enabled = false;


                btAtorSalvar.Enabled = true;
                btAtorCancelar.Enabled = true;
                gbAtor.Enabled = true;

            }

        }

        private string validarDadosAtorDiretor()
        {
            string strMensagem = "";

            foreach (Control c in gbAtor.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "r")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " nao foi preenchido corretamente.\n";
                    }
                }
            }

            return strMensagem;

        }
        private void btAtorSalvar_Click(object sender, EventArgs e)
        {
            string strAtorD = validarDadosAtorDiretor();

            if (strAtorD == "")
            {
              
                try
                {
                    Ator objAtor = new Ator();             
                    objAtor.StrNome = txtNomeAtor.Text;                   

                    if (txtCodigoAtor.Text == "")
                    {
                        objAtor.salvar();
                    }
                    else 
                    {
                        objAtor.IntCodigoA = Convert.ToInt16(txtCodigoAtor.Text);
                        objAtor.alterar();
                    }
                    controlabtAtor(true);
                    AtualizaGrid();
                    LimpaCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dados do usuario nao foram salvos. \n " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(strAtorD);
            }

        }

        private void dtDadosAtorDiretor_CellClick(object sender, DataGridViewCellEventArgs e)
        {                   
                txtCodigoAtor.Text = dtDadosAtor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomeAtor.Text = dtDadosAtor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FrmAtorDiretor_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            controlabtAtor(true);
        }

        private void btAtorNovo_Click(object sender, EventArgs e)
        {
            controlabtAtor(false);
            LimpaCampos();
        }

        private void btAtorAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigoAtor.Text != "")
            {
               
                controlabtAtor(false);
            }
            else
            {
                MessageBox.Show(this, "Selecione o registro que deseja alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btAtorCancelar_Click(object sender, EventArgs e)
        {
            controlabtAtor(true);
            LimpaCampos();
        }

        private void btAtorExcluir_Click(object sender, EventArgs e)
        {
             if (txtCodigoAtor.Text != "")
            {
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastros?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                       Ator objAtor = new Ator();
                        objAtor.IntCodigoA = Convert.ToInt16(txtCodigoAtor.Text);
                        objAtor.excluir();
                        LimpaCampos();
                        AtualizaGrid();
                        
                        
                     
                        MessageBox.Show(this, "O registro foi excluído");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "O rgistro não foi excluído!");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

       
            }
           
        private void txtCodigoAtorDiretor_KeyPress(object sender, KeyPressEventArgs e)
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

        public void LimpaCampos()
        {

            txtCodigoAtor.Text = "";
            txtNomeAtor.Text = "";
        }

        private void AtualizaGrid()
        {
            try
            {
                dtDadosAtor.DataSource = Ator.recuperarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro dos usuário. \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void txtConsultaAtor_TextChanged(object sender, EventArgs e)
        {
            dtDadosAtor.DataSource = Ator.recuperarTodosFiltro(txtConsultaAtor.Text);
        }

        private void txtConsultaAtor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtDadosAtor.DataSource = Ator.recuperarTodosFiltro(txtConsultaAtor.Text);
            }
        }

        private void txtNomeAtor_KeyPress(object sender, KeyPressEventArgs e)
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
