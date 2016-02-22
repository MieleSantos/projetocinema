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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btPSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlabtPUsuario(bool booLiberabtPNovo)
        {

            if (booLiberabtPNovo == true)
            {
                btPNovo.Enabled = true;
                btPAlterar.Enabled = true;
                btPExcluir.Enabled = true;
                btPSair.Enabled = true;
                dtgDadoUsuario.Enabled = true;

                
                btPSalvar.Enabled = false;
                btPCancelar.Enabled = false;
                gbPUsuario.Enabled = false;
            }
            else
            {
                btPNovo.Enabled = false;
                btPAlterar.Enabled = false;
                btPExcluir.Enabled = false;
                btPSair.Enabled = false;
                dtgDadoUsuario.Enabled = false;
              
                
                btPSalvar.Enabled = true;
                btPCancelar.Enabled = true;
                gbPUsuario.Enabled = true;
            }
        }
       
        private string validarDadosCinemas()
        {
            string strMensagem = "";

            foreach (Control c in gbPUsuario.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "k")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " nao foi preenchido corretamente.\n";                      
                    }
                }
            }

            return strMensagem;
        }

        private void btPSalvar_Click(object sender, EventArgs e)
        {
            string strCinema = validarDadosCinemas();

            if (strCinema == "")
            {
               try
                {
                    Usuario objUsuario = new Usuario();                  
                    objUsuario.StrUNome = txtPNome.Text;
                    objUsuario.StrEmail = txtPEmail.Text;

                    if (txtPCodigo.Text == "")
                    {
                        objUsuario.salvar();
                    }
                    else
                    {
                        objUsuario.IntUCodigo = Convert.ToInt16(txtPCodigo.Text);
                        objUsuario.alterar();
                        
                    }                            
                    controlabtPUsuario(true);
                    AtualizaGrid();
                    LimpaCampos();
                    
                }
                catch ( Exception ex) 
                {
                    MessageBox.Show("Dados do usuario nao foram salvos. \n " + ex.Message); 
                }
            }
            else
            {
                MessageBox.Show(strCinema);
            }  
        }

        private void dtgDadoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtPCodigo.Text = dtgDadoUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPNome.Text = dtgDadoUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPEmail.Text = dtgDadoUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
         }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
          //  AtualizaGrid();
            controlabtPUsuario(true); 
        }

        private void btPNovo_Click(object sender, EventArgs e)
        {
            controlabtPUsuario(false);
            LimpaCampos();
        }

        private void btPAlterar_Click(object sender, EventArgs e)
        {
            if (txtPCodigo.Text != "")
            {
                controlabtPUsuario(false);

            }
           else
            {
                MessageBox.Show(this, "Selecione um registro para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btPCancelar_Click(object sender, EventArgs e)
        {
            controlabtPUsuario(true);
            LimpaCampos();
        }

        private void btPExcluir_Click(object sender, EventArgs e)
        {
            
            if (txtPCodigo.Text != "")
            {
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastros?","Atenção",MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Usuario objUsuario = new Usuario();
                        objUsuario.IntUCodigo = Convert.ToInt16(txtPCodigo.Text);
                        objUsuario.excluir();
                        AtualizaGrid();
                        LimpaCampos();

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

        private void LimpaCampos()
        {
            txtPCodigo.Text = "";
            txtPNome.Text = "";
            txtPEmail.Text = "";
            txtConsulta.Text = "";
        }

        private void AtualizaGrid()
        {
            try
            {
                dtgDadoUsuario.DataSource = Usuario.recuperarTodos(txtPNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro dos usuário. \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //try e catch
                dtgDadoUsuario.DataSource = Usuario.recuperarTodosFiltro(txtConsulta.Text);
            }
        }

        private void txtPCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

       private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dtgDadoUsuario.DataSource = Usuario.recuperarTodosFiltro(txtConsulta.Text);
        }

       private void txtPNome_KeyPress(object sender, KeyPressEventArgs e)
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
