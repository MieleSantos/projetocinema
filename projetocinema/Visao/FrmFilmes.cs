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
    public partial class FormFilmes : Form
    {
        public FormFilmes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFilmes_Load(object sender, EventArgs e)
        {
            AtualizaComboBox();
            AtualizaGridF();
            controlaBtnFilmes(true);
        }

        private void controlaBtnFilmes(bool booLiberaBtNovo) 
        {

            if (booLiberaBtNovo == true)
            {
                BtNovo.Enabled = true;
                BtAlterar.Enabled = true;
                BtExcluir.Enabled = true;
                BtSair.Enabled = true;
                gpbdadosFilmes.Enabled = true;

                
                btnSalvar.Enabled = false;
                BtCancelar.Enabled = false;
                GbxFilmes.Enabled = false;
            }
            else 
             {
                 BtNovo.Enabled = false;
                 BtAlterar.Enabled = false;
                 BtExcluir.Enabled = false;
                 BtSair.Enabled = false;     
                 gpbdadosFilmes.Enabled = false;

                 
                 btnSalvar.Enabled = true;
                 BtCancelar.Enabled = true;
                 GbxFilmes.Enabled = true;
            }
        }
       
        private string validarDadosFilmes()
        {
            string strMensagem = "";

            foreach (Control c in GbxFilmes.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "n")
                    {
                        strMensagem = strMensagem + "O campo "  +  c.Tag.ToString()  +  " nao foi preenchido corretamente.\n";
                     
                    }
                }
            }

            return strMensagem;
        }

  
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string strMsg = validarDadosFilmes();
       
            if (strMsg == "")
            {
                try
                {
                    Filme objFilme = new Filme();                  
                    objFilme.StrfNome1 = txNome.Text;
                    objFilme.StrfCategoria1 = cbCategoria.SelectedItem.ToString();
                    objFilme.IntDuracao = Convert.ToInt16(cmbDuracao.SelectedItem.ToString());
                    objFilme.StrPaisOrigem1 = txPais_origem.Text;
                    objFilme.StrClassificacao = cbClassificacao.SelectedItem.ToString();                
                    objFilme.IntCodDiretor = Convert.ToInt16(cmbDiretor.SelectedValue.ToString());
                    objFilme.IntAnoDirecao = Convert.ToInt16(cmbAnoDirecaoD.SelectedItem.ToString());

                   

                    if (txCodigo.Text == "")
                    {
                        objFilme.salvar();
                    }
                    else 
                    {
                        objFilme.IntCodigo = Convert.ToInt16(txCodigo.Text);
                        objFilme.alterar();
                    }
                                    
                    controlaBtnFilmes(true);
                    AtualizaGridF();
                    LimpaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dados do filme não foram salvos. \n " + ex.Message ); 
                }
            }
            else
            {
                MessageBox.Show(strMsg);
            }           
        }

        private void dgvFilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {                      
               txCodigo.Text = dgvFilme.Rows[e.RowIndex].Cells[0].Value.ToString();
               txNome.Text = dgvFilme.Rows[e.RowIndex].Cells[1].Value.ToString();
               cbCategoria.Text = dgvFilme.Rows[e.RowIndex].Cells[2].Value.ToString();
               cmbDuracao.Text = dgvFilme.Rows[e.RowIndex].Cells[3].Value.ToString();
               cbClassificacao.Text= dgvFilme.Rows[e.RowIndex].Cells[4].Value.ToString();
               txPais_origem.Text = dgvFilme.Rows[e.RowIndex].Cells[5].Value.ToString();
               cmbDiretor.SelectedValue = dgvFilme.Rows[e.RowIndex].Cells[6].Value.ToString();
               cmbAnoDirecaoD.Text = dgvFilme.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
   
            controlaBtnFilmes(false);
            LimpaCampos();
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (txCodigo.Text != "")
            {
                controlaBtnFilmes(false);
            }
            else 
            {
                MessageBox.Show(this, "Selecione um registro para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            controlaBtnFilmes(true);
            LimpaCampos();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txCodigo.Text != "")
            {
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastros?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Filme objFilme = new Filme();
                        objFilme.IntCodigo = Convert.ToInt16(txCodigo.Text);
                        objFilme.excluir();
                        LimpaCampos();
                        AtualizaGridF();

                        MessageBox.Show(this, "O filme foi excluído");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "O filme não foi excluído!");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        public void LimpaCampos()
        {
            txCodigo.Text = "";
            txNome.Text = "";
            cbCategoria.Text = "";
            cmbDuracao.Text = "";
            cbClassificacao.Text = "";
            txPais_origem.Text = "";      
            cmbDiretor.Text = "";
            cmbAnoDirecaoD.Text = ""; 
        }
//Atualiza o datagrid com as inormações dos filmes
        private void AtualizaGridF()
        {
            try
            {
                dgvFilme.DataSource = Filme.recuperarTodosF();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro dos filmes. \nContate o administrador. \n\n" + ex.Message);
            }
        }
      
        private void txtConsultaFilme_TextChanged(object sender, EventArgs e)
        {
            dgvFilme.DataSource = Filme.recuperarTodosFiltroF(txtConsultaFilme.Text);
        }

       
 //recupera as informações do ator e diretor para salvar nos filmes            
       private void AtualizaComboBox()
        {      
            cmbDiretor.DataSource = Diretor.recuperarTodos();
            cmbDiretor.DisplayMember = "Diretor";
            cmbDiretor.ValueMember = "Código";
                      
        }
// Código para não permite que o usuário digite número no campo que só aceita letras e letras em campos que só aceita números

       private void txPais_origem_KeyPress(object sender, KeyPressEventArgs e)
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

       private void txtConsultaFilme_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == 13)
           {

               dgvFilme.DataSource = Filme.recuperarTodosFiltroF(txtConsultaFilme.Text);
           }
       }

       private void txNome_KeyPress(object sender, KeyPressEventArgs e)
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
