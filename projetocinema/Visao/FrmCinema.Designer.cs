namespace projetocinema.Visao
{
    partial class FormCinema
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
            this.GpbCinema = new System.Windows.Forms.GroupBox();
            this.cmbCinemaEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.BtNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbCinemaDado = new System.Windows.Forms.GroupBox();
            this.txtConsultarCinema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCinema = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GpbCinema.SuspendLayout();
            this.gpbCinemaDado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbCinema
            // 
            this.GpbCinema.Controls.Add(this.cmbCinemaEstado);
            this.GpbCinema.Controls.Add(this.txtCidade);
            this.GpbCinema.Controls.Add(this.txtBairro);
            this.GpbCinema.Controls.Add(this.label7);
            this.GpbCinema.Controls.Add(this.label6);
            this.GpbCinema.Controls.Add(this.label5);
            this.GpbCinema.Controls.Add(this.label4);
            this.GpbCinema.Controls.Add(this.label3);
            this.GpbCinema.Controls.Add(this.label2);
            this.GpbCinema.Controls.Add(this.label1);
            this.GpbCinema.Controls.Add(this.txtEndereco);
            this.GpbCinema.Controls.Add(this.txtNumero);
            this.GpbCinema.Controls.Add(this.txtNome);
            this.GpbCinema.Controls.Add(this.txtCodigo);
            this.GpbCinema.Location = new System.Drawing.Point(14, 29);
            this.GpbCinema.Name = "GpbCinema";
            this.GpbCinema.Size = new System.Drawing.Size(684, 117);
            this.GpbCinema.TabIndex = 0;
            this.GpbCinema.TabStop = false;
            // 
            // cmbCinemaEstado
            // 
            this.cmbCinemaEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinemaEstado.FormattingEnabled = true;
            this.cmbCinemaEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbCinemaEstado.Location = new System.Drawing.Point(607, 75);
            this.cmbCinemaEstado.Name = "cmbCinemaEstado";
            this.cmbCinemaEstado.Size = new System.Drawing.Size(57, 23);
            this.cmbCinemaEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(413, 77);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 21);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Tag = "r";
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(138, 77);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 21);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.Tag = "r";
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(413, 36);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(251, 21);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.Tag = "r";
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(26, 77);
            this.txtNumero.MaxLength = 4;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(90, 21);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Tag = "r";
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 37);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Nome";
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(26, 37);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tag = "r";
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // BtNovo
            // 
            this.BtNovo.Location = new System.Drawing.Point(274, 152);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(66, 33);
            this.BtNovo.TabIndex = 1;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = true;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(488, 152);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(66, 33);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // BtAlterar
            // 
            this.BtAlterar.Location = new System.Drawing.Point(346, 152);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(66, 33);
            this.BtAlterar.TabIndex = 2;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Location = new System.Drawing.Point(560, 152);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(66, 33);
            this.BtExcluir.TabIndex = 5;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtSair
            // 
            this.BtSair.Location = new System.Drawing.Point(632, 152);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(66, 33);
            this.BtSair.TabIndex = 6;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(416, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 33);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpbCinemaDado
            // 
            this.gpbCinemaDado.Controls.Add(this.txtConsultarCinema);
            this.gpbCinemaDado.Controls.Add(this.label9);
            this.gpbCinemaDado.Controls.Add(this.dgvCinema);
            this.gpbCinemaDado.Location = new System.Drawing.Point(15, 191);
            this.gpbCinemaDado.Name = "gpbCinemaDado";
            this.gpbCinemaDado.Size = new System.Drawing.Size(683, 298);
            this.gpbCinemaDado.TabIndex = 7;
            this.gpbCinemaDado.TabStop = false;
            // 
            // txtConsultarCinema
            // 
            this.txtConsultarCinema.Location = new System.Drawing.Point(121, 18);
            this.txtConsultarCinema.Name = "txtConsultarCinema";
            this.txtConsultarCinema.Size = new System.Drawing.Size(556, 21);
            this.txtConsultarCinema.TabIndex = 3;
            this.txtConsultarCinema.TextChanged += new System.EventHandler(this.txtConsultarCinema_TextChanged);
            this.txtConsultarCinema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarCinema_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Consultar Cinema";
            // 
            // dgvCinema
            // 
            this.dgvCinema.AllowUserToAddRows = false;
            this.dgvCinema.AllowUserToDeleteRows = false;
            this.dgvCinema.AllowUserToOrderColumns = true;
            this.dgvCinema.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCinema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinema.Location = new System.Drawing.Point(7, 48);
            this.dgvCinema.Name = "dgvCinema";
            this.dgvCinema.ReadOnly = true;
            this.dgvCinema.Size = new System.Drawing.Size(670, 244);
            this.dgvCinema.TabIndex = 0;
            this.dgvCinema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinema_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "* Preencimento obrigatório";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cadastro de Cinemas";
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(720, 516);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gpbCinemaDado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.BtSair);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtAlterar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.BtNovo);
            this.Controls.Add(this.GpbCinema);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cinemas";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            this.GpbCinema.ResumeLayout(false);
            this.GpbCinema.PerformLayout();
            this.gpbCinemaDado.ResumeLayout(false);
            this.gpbCinemaDado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbCinema;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbCinemaDado;
        private System.Windows.Forms.DataGridView dgvCinema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsultarCinema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCinemaEstado;
        private System.Windows.Forms.Label label10;
    }
}