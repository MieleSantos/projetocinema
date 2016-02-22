namespace projetocinema.Visao
{
    partial class FrmAtor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAtor = new System.Windows.Forms.GroupBox();
            this.txtNomeAtor = new System.Windows.Forms.TextBox();
            this.txtCodigoAtor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtorSair = new System.Windows.Forms.Button();
            this.btAtorExcluir = new System.Windows.Forms.Button();
            this.btAtorCancelar = new System.Windows.Forms.Button();
            this.btAtorSalvar = new System.Windows.Forms.Button();
            this.btAtorAlterar = new System.Windows.Forms.Button();
            this.btAtorNovo = new System.Windows.Forms.Button();
            this.gbAtorDados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsultaAtor = new System.Windows.Forms.TextBox();
            this.dtDadosAtor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAtor.SuspendLayout();
            this.gbAtorDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDadosAtor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAtor
            // 
            this.gbAtor.Controls.Add(this.txtNomeAtor);
            this.gbAtor.Controls.Add(this.txtCodigoAtor);
            this.gbAtor.Controls.Add(this.label2);
            this.gbAtor.Controls.Add(this.label1);
            this.gbAtor.Location = new System.Drawing.Point(13, 37);
            this.gbAtor.Name = "gbAtor";
            this.gbAtor.Size = new System.Drawing.Size(413, 88);
            this.gbAtor.TabIndex = 0;
            this.gbAtor.TabStop = false;
            // 
            // txtNomeAtor
            // 
            this.txtNomeAtor.Location = new System.Drawing.Point(125, 45);
            this.txtNomeAtor.MaxLength = 40;
            this.txtNomeAtor.Name = "txtNomeAtor";
            this.txtNomeAtor.Size = new System.Drawing.Size(255, 21);
            this.txtNomeAtor.TabIndex = 2;
            this.txtNomeAtor.Tag = "Nome";
            this.txtNomeAtor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAtor_KeyPress);
            // 
            // txtCodigoAtor
            // 
            this.txtCodigoAtor.Enabled = false;
            this.txtCodigoAtor.Location = new System.Drawing.Point(26, 45);
            this.txtCodigoAtor.MaxLength = 5;
            this.txtCodigoAtor.Name = "txtCodigoAtor";
            this.txtCodigoAtor.Size = new System.Drawing.Size(72, 21);
            this.txtCodigoAtor.TabIndex = 1;
            this.txtCodigoAtor.Tag = "r";
            this.txtCodigoAtor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoAtorDiretor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código*";
            // 
            // btAtorSair
            // 
            this.btAtorSair.Location = new System.Drawing.Point(363, 132);
            this.btAtorSair.Name = "btAtorSair";
            this.btAtorSair.Size = new System.Drawing.Size(63, 33);
            this.btAtorSair.TabIndex = 6;
            this.btAtorSair.Text = "Sair";
            this.btAtorSair.UseVisualStyleBackColor = true;
            this.btAtorSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAtorExcluir
            // 
            this.btAtorExcluir.Location = new System.Drawing.Point(293, 132);
            this.btAtorExcluir.Name = "btAtorExcluir";
            this.btAtorExcluir.Size = new System.Drawing.Size(63, 33);
            this.btAtorExcluir.TabIndex = 5;
            this.btAtorExcluir.Text = "Excluir";
            this.btAtorExcluir.UseVisualStyleBackColor = true;
            this.btAtorExcluir.Click += new System.EventHandler(this.btAtorExcluir_Click);
            // 
            // btAtorCancelar
            // 
            this.btAtorCancelar.Location = new System.Drawing.Point(223, 132);
            this.btAtorCancelar.Name = "btAtorCancelar";
            this.btAtorCancelar.Size = new System.Drawing.Size(63, 33);
            this.btAtorCancelar.TabIndex = 4;
            this.btAtorCancelar.Text = "Cancela";
            this.btAtorCancelar.UseVisualStyleBackColor = true;
            this.btAtorCancelar.Click += new System.EventHandler(this.btAtorCancelar_Click);
            // 
            // btAtorSalvar
            // 
            this.btAtorSalvar.Location = new System.Drawing.Point(153, 132);
            this.btAtorSalvar.Name = "btAtorSalvar";
            this.btAtorSalvar.Size = new System.Drawing.Size(63, 33);
            this.btAtorSalvar.TabIndex = 3;
            this.btAtorSalvar.Text = "Salvar";
            this.btAtorSalvar.UseVisualStyleBackColor = true;
            this.btAtorSalvar.Click += new System.EventHandler(this.btAtorSalvar_Click);
            // 
            // btAtorAlterar
            // 
            this.btAtorAlterar.Location = new System.Drawing.Point(83, 132);
            this.btAtorAlterar.Name = "btAtorAlterar";
            this.btAtorAlterar.Size = new System.Drawing.Size(63, 33);
            this.btAtorAlterar.TabIndex = 2;
            this.btAtorAlterar.Text = "Alterar";
            this.btAtorAlterar.UseVisualStyleBackColor = true;
            this.btAtorAlterar.Click += new System.EventHandler(this.btAtorAlterar_Click);
            // 
            // btAtorNovo
            // 
            this.btAtorNovo.Location = new System.Drawing.Point(13, 132);
            this.btAtorNovo.Name = "btAtorNovo";
            this.btAtorNovo.Size = new System.Drawing.Size(63, 33);
            this.btAtorNovo.TabIndex = 1;
            this.btAtorNovo.Text = "Novo";
            this.btAtorNovo.UseVisualStyleBackColor = true;
            this.btAtorNovo.Click += new System.EventHandler(this.btAtorNovo_Click);
            // 
            // gbAtorDados
            // 
            this.gbAtorDados.Controls.Add(this.label5);
            this.gbAtorDados.Controls.Add(this.txtConsultaAtor);
            this.gbAtorDados.Controls.Add(this.dtDadosAtor);
            this.gbAtorDados.Location = new System.Drawing.Point(17, 172);
            this.gbAtorDados.Name = "gbAtorDados";
            this.gbAtorDados.Size = new System.Drawing.Size(410, 215);
            this.gbAtorDados.TabIndex = 7;
            this.gbAtorDados.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Consulta";
            // 
            // txtConsultaAtor
            // 
            this.txtConsultaAtor.Location = new System.Drawing.Point(77, 16);
            this.txtConsultaAtor.Name = "txtConsultaAtor";
            this.txtConsultaAtor.Size = new System.Drawing.Size(314, 21);
            this.txtConsultaAtor.TabIndex = 1;
            this.txtConsultaAtor.TextChanged += new System.EventHandler(this.txtConsultaAtor_TextChanged);
            this.txtConsultaAtor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaAtor_KeyPress);
            // 
            // dtDadosAtor
            // 
            this.dtDadosAtor.AllowUserToAddRows = false;
            this.dtDadosAtor.AllowUserToDeleteRows = false;
            this.dtDadosAtor.AllowUserToOrderColumns = true;
            this.dtDadosAtor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtDadosAtor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtDadosAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDadosAtor.Location = new System.Drawing.Point(16, 46);
            this.dtDadosAtor.Name = "dtDadosAtor";
            this.dtDadosAtor.ReadOnly = true;
            this.dtDadosAtor.Size = new System.Drawing.Size(375, 156);
            this.dtDadosAtor.TabIndex = 0;
            this.dtDadosAtor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDadosAtorDiretor_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "* Preencimento obrigatório e não aceita número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cadastro de Ator";
            // 
            // FrmAtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(436, 415);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbAtorDados);
            this.Controls.Add(this.btAtorNovo);
            this.Controls.Add(this.btAtorAlterar);
            this.Controls.Add(this.btAtorSalvar);
            this.Controls.Add(this.btAtorCancelar);
            this.Controls.Add(this.btAtorExcluir);
            this.Controls.Add(this.btAtorSair);
            this.Controls.Add(this.gbAtor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Ator ";
            this.Load += new System.EventHandler(this.FrmAtorDiretor_Load);
            this.gbAtor.ResumeLayout(false);
            this.gbAtor.PerformLayout();
            this.gbAtorDados.ResumeLayout(false);
            this.gbAtorDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDadosAtor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAtor;
        private System.Windows.Forms.TextBox txtNomeAtor;
        private System.Windows.Forms.TextBox txtCodigoAtor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtorSair;
        private System.Windows.Forms.Button btAtorExcluir;
        private System.Windows.Forms.Button btAtorCancelar;
        private System.Windows.Forms.Button btAtorSalvar;
        private System.Windows.Forms.Button btAtorAlterar;
        private System.Windows.Forms.Button btAtorNovo;
        private System.Windows.Forms.GroupBox gbAtorDados;
        private System.Windows.Forms.DataGridView dtDadosAtor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsultaAtor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}