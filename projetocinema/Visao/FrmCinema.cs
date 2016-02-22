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
    public partial class FormCinema : Form
    {
        public FormCinema()
        {
            InitializeComponent();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlaBtCinema(bool booLiberaBtCNovo)
        {
            if (booLiberaBtCNovo == true)
            {
                BtNovo.Enabled = true;
                BtAlterar.Enabled = true;             
                BtExcluir.Enabled = true;
                BtSair.Enabled = true;
                gpbCinemaDado.Enabled = true;

                btnSalvar.Enabled = false;
                btCancelar.Enabled = false;
                GpbCinema.Enabled = false;
            }
            else
            {
                BtNovo.Enabled = false;
                BtAlterar.Enabled = false;              
                BtExcluir.Enabled = false;
                BtSair.Enabled = false;
                gpbCinemaDado.Enabled = false;

                btnSalvar.Enabled = true;
                btCancelar.Enabled = true;
                GpbCinema.Enabled = true;
            }
        }
       
        private string validarDadosCinemas()
        {
            string strMensagem = "";

            foreach (Control c in GpbCinema.Controls)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string strCinema = validarDadosCinemas();
          
            if (strCinema == "")
            {
                try
                {
                    Cinema objCinema = new Cinema();
                    objCinema.StrNome = txtNome.Text;
                    objCinema.StrRua = txtEndereco.Text;
                    objCinema.IntNumero = Convert.ToInt16(txtNumero.Text);
                    objCinema.StrBairro = txtBairro.Text;
                    objCinema.StrCidade = txtCidade.Text;
                    objCinema.StrEstado = cmbCinemaEstado.SelectedItem.ToString();
                    
                    if (txtCodigo.Text == "") 
                    {
                        objCinema.salvar();
                    }
                    else
                    {
                        objCinema.IntCodigo = Convert.ToInt16(txtCodigo.Text);
                        objCinema.alterar();
                    }
                                      
                    controlaBtCinema(true);
                    AtualizaGrid();
                    LimparCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dados do usuario nao foram salvos. \n " + ex.Message);
                }
             }
            else
            {
                MessageBox.Show(strCinema);
            }            
        }

        private void dgvCinema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCinema.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvCinema.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dgvCinema.Rows[e.RowIndex].Cells[2].Value.ToString();          
            txtBairro.Text = dgvCinema.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dgvCinema.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCidade.Text = dgvCinema.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbCinemaEstado.Text = dgvCinema.Rows[e.RowIndex].Cells[6].Value.ToString();            
        }


        private void FormCinema_Load(object sender, EventArgs e)
        {           
            AtualizaGrid();
            controlaBtCinema(true);
        } 

        private void BtNovo_Click(object sender, EventArgs e)
        {
            controlaBtCinema(false);
            LimparCampo();

        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                controlaBtCinema(false);
            }
            else 
            {
                MessageBox.Show(this,"Selecione o registro que deseja alterar","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            controlaBtCinema(true);
            LimparCampo();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                DialogResult resultado = MessageBox.Show(this, "Tem certeza que deseja excluir esse cadastro?", "Atenção", MessageBoxButtons.YesNo);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Cinema objCinema = new Cinema();
                        objCinema.IntCodigo = Convert.ToInt16(txtCodigo.Text);
                        objCinema.excluir();
                        LimparCampo();
                        AtualizaGrid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "O cadastro não foi excluído.\n" + ex.Message);
                    }
                }                                     
            }
            else
            {
                MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        public void LimparCampo()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cmbCinemaEstado.Text = "";
        }

        private void AtualizaGrid()
        {
            try
            {
               
                dgvCinema.DataSource = Cinema.recuperarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro dos cinemas. \nContate o administrador. \n\n" + ex.Message);
            }
        }
                   
        private void txtConsultarCinema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
              
                dgvCinema.DataSource = Cinema.recuperarTodosFiltro(txtConsultarCinema.Text);
            }          
        }
        private void txtConsultarCinema_TextChanged(object sender, EventArgs e)
        {
            dgvCinema.DataSource = Cinema.recuperarTodosFiltro(txtConsultarCinema.Text);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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
