namespace projetocinema.Visao
{
    partial class FrmUsuario
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
            this.gbPUsuario = new System.Windows.Forms.GroupBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.txtPNome = new System.Windows.Forms.TextBox();
            this.txtPCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPNovo = new System.Windows.Forms.Button();
            this.btPAlterar = new System.Windows.Forms.Button();
            this.btPSalvar = new System.Windows.Forms.Button();
            this.btPCancelar = new System.Windows.Forms.Button();
            this.btPExcluir = new System.Windows.Forms.Button();
            this.btPSair = new System.Windows.Forms.Button();
            this.gbPDadosUsuario = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgDadoUsuario = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPUsuario.SuspendLayout();
            this.gbPDadosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPUsuario
            // 
            this.gbPUsuario.Controls.Add(this.txtPEmail);
            this.gbPUsuario.Controls.Add(this.txtPNome);
            this.gbPUsuario.Controls.Add(this.txtPCodigo);
            this.gbPUsuario.Controls.Add(this.label3);
            this.gbPUsuario.Controls.Add(this.label2);
            this.gbPUsuario.Controls.Add(this.label1);
            this.gbPUsuario.Location = new System.Drawing.Point(14, 35);
            this.gbPUsuario.Name = "gbPUsuario";
            this.gbPUsuario.Size = new System.Drawing.Size(399, 133);
            this.gbPUsuario.TabIndex = 0;
            this.gbPUsuario.TabStop = false;
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(13, 89);
            this.txtPEmail.MaxLength = 30;
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(357, 21);
            this.txtPEmail.TabIndex = 3;
            this.txtPEmail.Tag = "k";
            // 
            // txtPNome
            // 
            this.txtPNome.Location = new System.Drawing.Point(13, 42);
            this.txtPNome.MaxLength = 20;
            this.txtPNome.Name = "txtPNome";
            this.txtPNome.Size = new System.Drawing.Size(357, 21);
            this.txtPNome.TabIndex = 2;
            this.txtPNome.Tag = "Nome";
            this.txtPNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNome_KeyPress);
            // 
            // txtPCodigo
            // 
            this.txtPCodigo.Enabled = false;
            this.txtPCodigo.Location = new System.Drawing.Point(135, 67);
            this.txtPCodigo.MaxLength = 5;
            this.txtPCodigo.Name = "txtPCodigo";
            this.txtPCodigo.Size = new System.Drawing.Size(67, 21);
            this.txtPCodigo.TabIndex = 1;
            this.txtPCodigo.Tag = "k";
            this.txtPCodigo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // btPNovo
            // 
            this.btPNovo.Location = new System.Drawing.Point(14, 174);
            this.btPNovo.Name = "btPNovo";
            this.btPNovo.Size = new System.Drawing.Size(61, 35);
            this.btPNovo.TabIndex = 1;
            this.btPNovo.Text = "Novo";
            this.btPNovo.UseVisualStyleBackColor = true;
            this.btPNovo.Click += new System.EventHandler(this.btPNovo_Click);
            // 
            // btPAlterar
            // 
            this.btPAlterar.Location = new System.Drawing.Point(82, 174);
            this.btPAlterar.Name = "btPAlterar";
            this.btPAlterar.Size = new System.Drawing.Size(61, 35);
            this.btPAlterar.TabIndex = 2;
            this.btPAlterar.Text = "Alterar";
            this.btPAlterar.UseVisualStyleBackColor = true;
            this.btPAlterar.Click += new System.EventHandler(this.btPAlterar_Click);
            // 
            // btPSalvar
            // 
            this.btPSalvar.Location = new System.Drawing.Point(149, 174);
            this.btPSalvar.Name = "btPSalvar";
            this.btPSalvar.Size = new System.Drawing.Size(61, 35);
            this.btPSalvar.TabIndex = 3;
            this.btPSalvar.Text = "Salvar";
            this.btPSalvar.UseVisualStyleBackColor = true;
            this.btPSalvar.Click += new System.EventHandler(this.btPSalvar_Click);
            // 
            // btPCancelar
            // 
            this.btPCancelar.Location = new System.Drawing.Point(217, 174);
            this.btPCancelar.Name = "btPCancelar";
            this.btPCancelar.Size = new System.Drawing.Size(61, 35);
            this.btPCancelar.TabIndex = 4;
            this.btPCancelar.Text = "Cancel";
            this.btPCancelar.UseVisualStyleBackColor = true;
            this.btPCancelar.Click += new System.EventHandler(this.btPCancelar_Click);
            // 
            // btPExcluir
            // 
            this.btPExcluir.Location = new System.Drawing.Point(285, 174);
            this.btPExcluir.Name = "btPExcluir";
            this.btPExcluir.Size = new System.Drawing.Size(61, 35);
            this.btPExcluir.TabIndex = 5;
            this.btPExcluir.Text = "Excluir";
            this.btPExcluir.UseVisualStyleBackColor = true;
            this.btPExcluir.Click += new System.EventHandler(this.btPExcluir_Click);
            // 
            // btPSair
            // 
            this.btPSair.Location = new System.Drawing.Point(352, 174);
            this.btPSair.Name = "btPSair";
            this.btPSair.Size = new System.Drawing.Size(61, 35);
            this.btPSair.TabIndex = 6;
            this.btPSair.Text = "Sair";
            this.btPSair.UseVisualStyleBackColor = true;
            this.btPSair.Click += new System.EventHandler(this.btPSair_Click);
            // 
            // gbPDadosUsuario
            // 
            this.gbPDadosUsuario.Controls.Add(this.txtConsulta);
            this.gbPDadosUsuario.Controls.Add(this.label4);
            this.gbPDadosUsuario.Controls.Add(this.dtgDadoUsuario);
            this.gbPDadosUsuario.Location = new System.Drawing.Point(14, 216);
            this.gbPDadosUsuario.Name = "gbPDadosUsuario";
            this.gbPDadosUsuario.Size = new System.Drawing.Size(399, 155);
            this.gbPDadosUsuario.TabIndex = 2;
            this.gbPDadosUsuario.TabStop = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(7, 37);
            this.txtConsulta.MaxLength = 30;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(376, 21);
            this.txtConsulta.TabIndex = 2;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Digite seu email pra alterar ou excluir  seu usuário";
            // 
            // dtgDadoUsuario
            // 
            this.dtgDadoUsuario.AllowUserToAddRows = false;
            this.dtgDadoUsuario.AllowUserToDeleteRows = false;
            this.dtgDadoUsuario.AllowUserToOrderColumns = true;
            this.dtgDadoUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDadoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadoUsuario.Location = new System.Drawing.Point(7, 67);
            this.dtgDadoUsuario.Name = "dtgDadoUsuario";
            this.dtgDadoUsuario.ReadOnly = true;
            this.dtgDadoUsuario.Size = new System.Drawing.Size(379, 69);
            this.dtgDadoUsuario.TabIndex = 0;
            this.dtgDadoUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadoUsuario_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "* Preencimento obrigatório";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cadastro de usuário";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(422, 399);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbPDadosUsuario);
            this.Controls.Add(this.btPSair);
            this.Controls.Add(this.btPExcluir);
            this.Controls.Add(this.btPCancelar);
            this.Controls.Add(this.btPSalvar);
            this.Controls.Add(this.btPAlterar);
            this.Controls.Add(this.btPNovo);
            this.Controls.Add(this.gbPUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.gbPUsuario.ResumeLayout(false);
            this.gbPUsuario.PerformLayout();
            this.gbPDadosUsuario.ResumeLayout(false);
            this.gbPDadosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPUsuario;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.TextBox txtPNome;
        private System.Windows.Forms.TextBox txtPCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPNovo;
        private System.Windows.Forms.Button btPAlterar;
        private System.Windows.Forms.Button btPSalvar;
        private System.Windows.Forms.Button btPCancelar;
        private System.Windows.Forms.Button btPExcluir;
        private System.Windows.Forms.Button btPSair;
        private System.Windows.Forms.GroupBox gbPDadosUsuario;
        private System.Windows.Forms.DataGridView dtgDadoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}