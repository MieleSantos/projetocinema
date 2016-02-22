using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projetocinema.Modelo;
using projetocinema.Visao;

namespace projetocinema.Visao
{
    public partial class FrmAtuacao : Form
    {
        public FrmAtuacao()
        {
            InitializeComponent();
        }

        private void AtualizaLista()
        {
          //  Select CodFilme AS Código,NomeFilme AS Nome,Categoria AS Categoria,Duracao AS Duração_min,Classificacao AS Classificação,PaisOrigem AS País_de_Origem,CodigoArtista as Artista,CodigoDiretor As Diretor from filme";
            listFilme.DataSource = Filme.recuperarTodosF();
            listFilme.DisplayMember = "Nome";
            listFilme.ValueMember = "Código";

             //Select CodArtista AS IDArtista,NomeArtista AS Ator from artista";
             listArtista.DataSource = Ator.recuperarTodos();
             listArtista.DisplayMember = "Artista";
             listArtista.ValueMember = "ID_Artista";     
         }

   
        private void btSairAtuacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlarbtAtuacao(bool BoolbtNovoatuacao)
        {
            if (BoolbtNovoatuacao == true)
            {
                btNovoAtuacao.Enabled = true;
                btAlterarAtuacao.Enabled = true;
                btExcluirAtuacao.Enabled = true;
                btSairAtuacao.Enabled = true;
                dgDadoAtuacao.Enabled = true;

                btSalvarAtuacao.Enabled = false;
                btCancelarAtuacao.Enabled = false;
                gbAtuacao.Enabled = false;
            }
            else
            {
                btNovoAtuacao.Enabled = false;
                btAlterarAtuacao.Enabled = false;
                btExcluirAtuacao.Enabled = false;
                btSairAtuacao.Enabled = false;
                dgDadoAtuacao.Enabled = false;

                btSalvarAtuacao.Enabled = true;
                btCancelarAtuacao.Enabled = true;
                gbAtuacao.Enabled = true;
            }
        }

        private string ValidaDadosAtuacao()
        {

            string strMensagem = "";

            foreach (Control c in gbAtuacao.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "f")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " nao foi preenchido corretamente.\n";
                    }
                }
            }

            return strMensagem;
        }
        
       
        private void btSalvarAtuacao_Click(object sender, EventArgs e)
        {
            string strAtuacao = ValidaDadosAtuacao();
            
            if (strAtuacao == "")
            {
                try
                {                        
                        Atuacao objAtuaEm = new Atuacao();
                        objAtuaEm.IntCodigoFilme = Convert.ToInt16(listFilme.SelectedValue.ToString());
                        objAtuaEm.IntCodigoArtista = Convert.ToInt16(listArtista.SelectedValue.ToString());
                    
                    //verificarCadastroFilmeAtor();
                    //faz um select pra ver se ja existe na tabela o mesmo ator para o mesmo filme
                    //se sim, vc nao salva... nao continua e informa o usuarui

                    //se nao houver, vc salav


                    if (txtIdAtuacao.Text == "")
                    {                       
                        objAtuaEm.salva();
                    }
                    else
                    {                       
                        objAtuaEm.IntCodigoFilme = Convert.ToInt16(txtIdAtuacao.Text);
                        objAtuaEm.alterar();
                    }
                    controlarbtAtuacao(true);
                    Atualizargrid();
                    LimpaAtuacao();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("O artista selecionado já atua neste filme! \n " + ex.Message);

                }

            }
        }

        private void dgDadoAtuacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtIdAtuacao.Text = dgDadoAtuacao.Rows[e.RowIndex].Cells[0].Value.ToString();
                listArtista.SelectedItem = dgDadoAtuacao.Rows[e.RowIndex].Cells[1].Value.ToString();
                listFilme.SelectedItem = dgDadoAtuacao.Rows[e.RowIndex].Cells[2].Value.ToString();
                
        }

        private void btAlterarAtuacao_Click(object sender, EventArgs e)
        {

            if (txtIdAtuacao.Text == "")
            {
                MessageBox.Show("Selecione um registro para alterar.");
            }
            else
            {
                controlarbtAtuacao(false);
            }
        }

        private void btCancelarAtuacao_Click(object sender, EventArgs e)
        {
            controlarbtAtuacao(true);
            LimpaAtuacao();
        }

        private void btExcluirAtuacao_Click(object sender, EventArgs e)
        {

            if (txtIdAtuacao.Text != "")
            {          
                DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == System.Windows.Forms.DialogResult.Yes)
                {
                     try
                    {                  
                         Atuacao objAtuacao = new Atuacao();
                         objAtuacao.IntCodigoFilme= Convert.ToInt16(txtIdAtuacao.Text);
                         objAtuacao.excluir();
                         LimpaAtuacao();
                         Atualizargrid();

                         MessageBox.Show(this, "O cadastro foi excluído.\n");
               
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

        private void btNovoAtuacao_Click(object sender, EventArgs e)
        {
            controlarbtAtuacao(false);
            LimpaAtuacao();
        }

        public void LimpaAtuacao()
        {
            txtIdAtuacao.Text = "";
            listArtista.Text = "";
            listFilme.Text = "";
            
        }

        public void Atualizargrid()
        {
            try
            {
                dgDadoAtuacao.DataSource = Atuacao.RecuperarTodosA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar o cadastro das atuações. \nContate o administrador. \n\n" + ex.Message);
            }
        }
          
        private void btCancelarAtuacao_Click_1(object sender, EventArgs e)
        {
            controlarbtAtuacao(true);
            LimpaAtuacao();
        }

        private void FrmAtuacao_Load(object sender, EventArgs e)
        {
            Atualizargrid();
            AtualizaLista();    
            controlarbtAtuacao(true);
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgDadoAtuacao.DataSource = Atuacao.recuperarTodosFiltroAtuacao(txtConsulta.Text);
        }
    }
}
