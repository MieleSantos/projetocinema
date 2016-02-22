namespace projetocinema.Visao
{
    partial class FrmSessao
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
            this.gbxSessao = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSalaCinema = new System.Windows.Forms.ComboBox();
            this.cmbIdFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dthorario = new System.Windows.Forms.DateTimePicker();
            this.dtdExibicao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroSessao = new System.Windows.Forms.TextBox();
            this.gbxDadosSessao = new System.Windows.Forms.GroupBox();
            this.dgvDadoSessao = new System.Windows.Forms.DataGridView();
            this.btNovoSessao = new System.Windows.Forms.Button();
            this.btAlterarSessao = new System.Windows.Forms.Button();
            this.btSalvarSessao = new System.Windows.Forms.Button();
            this.btCancelarSessao = new System.Windows.Forms.Button();
            this.btSairSessao = new System.Windows.Forms.Button();
            this.btExcluirSessao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSessao.SuspendLayout();
            this.gbxDadosSessao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadoSessao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSessao
            // 
            this.gbxSessao.Controls.Add(this.label7);
            this.gbxSessao.Controls.Add(this.cmbSalaCinema);
            this.gbxSessao.Controls.Add(this.cmbIdFilme);
            this.gbxSessao.Controls.Add(this.label1);
            this.gbxSessao.Controls.Add(this.dthorario);
            this.gbxSessao.Controls.Add(this.dtdExibicao);
            this.gbxSessao.Controls.Add(this.label6);
            this.gbxSessao.Controls.Add(this.label5);
            this.gbxSessao.Controls.Add(this.label2);
            this.gbxSessao.Controls.Add(this.txtNumeroSessao);
            this.gbxSessao.Location = new System.Drawing.Point(13, 31);
            this.gbxSessao.Name = "gbxSessao";
            this.gbxSessao.Size = new System.Drawing.Size(676, 93);
            this.gbxSessao.TabIndex = 0;
            this.gbxSessao.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cinema";
            // 
            // cmbSalaCinema
            // 
            this.cmbSalaCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaCinema.FormattingEnabled = true;
            this.cmbSalaCinema.Location = new System.Drawing.Point(354, 37);
            this.cmbSalaCinema.Name = "cmbSalaCinema";
            this.cmbSalaCinema.Size = new System.Drawing.Size(122, 23);
            this.cmbSalaCinema.TabIndex = 5;
            // 
            // cmbIdFilme
            // 
            this.cmbIdFilme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdFilme.FormattingEnabled = true;
            this.cmbIdFilme.Location = new System.Drawing.Point(88, 37);
            this.cmbIdFilme.Name = "cmbIdFilme";
            this.cmbIdFilme.Size = new System.Drawing.Size(246, 23);
            this.cmbIdFilme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filme";
            // 
            // dthorario
            // 
            this.dthorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthorario.Location = new System.Drawing.Point(589, 39);
            this.dthorario.Name = "dthorario";
            this.dthorario.Size = new System.Drawing.Size(68, 21);
            this.dthorario.TabIndex = 3;
            // 
            // dtdExibicao
            // 
            this.dtdExibicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdExibicao.Location = new System.Drawing.Point(492, 39);
            this.dtdExibicao.Name = "dtdExibicao";
            this.dtdExibicao.Size = new System.Drawing.Size(83, 21);
            this.dtdExibicao.TabIndex = 2;
            this.dtdExibicao.Value = new System.DateTime(2015, 5, 12, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Horário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Exibição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = " Sessao*";
            // 
            // txtNumeroSessao
            // 
            this.txtNumeroSessao.Enabled = false;
            this.txtNumeroSessao.Location = new System.Drawing.Point(19, 37);
            this.txtNumeroSessao.MaxLength = 5;
            this.txtNumeroSessao.Name = "txtNumeroSessao";
            this.txtNumeroSessao.Size = new System.Drawing.Size(51, 21);
            this.txtNumeroSessao.TabIndex = 1;
            this.txtNumeroSessao.Tag = "f";
            this.txtNumeroSessao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroSessao_KeyPress);
            // 
            // gbxDadosSessao
            // 
            this.gbxDadosSessao.Controls.Add(this.dgvDadoSessao);
            this.gbxDadosSessao.Location = new System.Drawing.Point(14, 171);
            this.gbxDadosSessao.Name = "gbxDadosSessao";
            this.gbxDadosSessao.Size = new System.Drawing.Size(675, 233);
            this.gbxDadosSessao.TabIndex = 1;
            this.gbxDadosSessao.TabStop = false;
            // 
            // dgvDadoSessao
            // 
            this.dgvDadoSessao.AllowUserToAddRows = false;
            this.dgvDadoSessao.AllowUserToDeleteRows = false;
            this.dgvDadoSessao.AllowUserToOrderColumns = true;
            this.dgvDadoSessao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDadoSessao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDadoSessao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadoSessao.Location = new System.Drawing.Point(10, 20);
            this.dgvDadoSessao.Name = "dgvDadoSessao";
            this.dgvDadoSessao.ReadOnly = true;
            this.dgvDadoSessao.Size = new System.Drawing.Size(659, 202);
            this.dgvDadoSessao.TabIndex = 2;
            this.dgvDadoSessao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtqDadoSessao_CellClick);
            // 
            // btNovoSessao
            // 
            this.btNovoSessao.Location = new System.Drawing.Point(269, 130);
            this.btNovoSessao.Name = "btNovoSessao";
            this.btNovoSessao.Size = new System.Drawing.Size(65, 35);
            this.btNovoSessao.TabIndex = 1;
            this.btNovoSessao.Text = "Novo";
            this.btNovoSessao.UseVisualStyleBackColor = true;
            this.btNovoSessao.Click += new System.EventHandler(this.btNovoSessao_Click);
            // 
            // btAlterarSessao
            // 
            this.btAlterarSessao.Location = new System.Drawing.Point(340, 130);
            this.btAlterarSessao.Name = "btAlterarSessao";
            this.btAlterarSessao.Size = new System.Drawing.Size(65, 35);
            this.btAlterarSessao.TabIndex = 2;
            this.btAlterarSessao.Text = "Alterar";
            this.btAlterarSessao.UseVisualStyleBackColor = true;
            this.btAlterarSessao.Click += new System.EventHandler(this.btAlterarSessao_Click);
            // 
            // btSalvarSessao
            // 
            this.btSalvarSessao.Location = new System.Drawing.Point(411, 130);
            this.btSalvarSessao.Name = "btSalvarSessao";
            this.btSalvarSessao.Size = new System.Drawing.Size(65, 35);
            this.btSalvarSessao.TabIndex = 3;
            this.btSalvarSessao.Text = "Salvar";
            this.btSalvarSessao.UseVisualStyleBackColor = true;
            this.btSalvarSessao.Click += new System.EventHandler(this.btSalvarSessao_Click);
            // 
            // btCancelarSessao
            // 
            this.btCancelarSessao.Location = new System.Drawing.Point(482, 130);
            this.btCancelarSessao.Name = "btCancelarSessao";
            this.btCancelarSessao.Size = new System.Drawing.Size(65, 35);
            this.btCancelarSessao.TabIndex = 4;
            this.btCancelarSessao.Text = "Cancel";
            this.btCancelarSessao.UseVisualStyleBackColor = true;
            this.btCancelarSessao.Click += new System.EventHandler(this.btCancelarSessao_Click);
            // 
            // btSairSessao
            // 
            this.btSairSessao.Location = new System.Drawing.Point(624, 130);
            this.btSairSessao.Name = "btSairSessao";
            this.btSairSessao.Size = new System.Drawing.Size(65, 35);
            this.btSairSessao.TabIndex = 6;
            this.btSairSessao.Text = "Sair";
            this.btSairSessao.UseVisualStyleBackColor = true;
            this.btSairSessao.Click += new System.EventHandler(this.btSairSessao_Click);
            // 
            // btExcluirSessao
            // 
            this.btExcluirSessao.Location = new System.Drawing.Point(553, 130);
            this.btExcluirSessao.Name = "btExcluirSessao";
            this.btExcluirSessao.Size = new System.Drawing.Size(65, 35);
            this.btExcluirSessao.TabIndex = 5;
            this.btExcluirSessao.Text = "Excluir";
            this.btExcluirSessao.UseVisualStyleBackColor = true;
            this.btExcluirSessao.Click += new System.EventHandler(this.btExcluirSessao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "*  Preenchimento obrigatório";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sessão do cinemas";
            // 
            // FrmSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(701, 428);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExcluirSessao);
            this.Controls.Add(this.btSairSessao);
            this.Controls.Add(this.btCancelarSessao);
            this.Controls.Add(this.btSalvarSessao);
            this.Controls.Add(this.btAlterarSessao);
            this.Controls.Add(this.btNovoSessao);
            this.Controls.Add(this.gbxDadosSessao);
            this.Controls.Add(this.gbxSessao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessao do Cinema";
            this.Load += new System.EventHandler(this.FrmSessao_Load);
            this.gbxSessao.ResumeLayout(false);
            this.gbxSessao.PerformLayout();
            this.gbxDadosSessao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadoSessao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSessao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroSessao;
        private System.Windows.Forms.GroupBox gbxDadosSessao;
        private System.Windows.Forms.DataGridView dgvDadoSessao;
        private System.Windows.Forms.Button btNovoSessao;
        private System.Windows.Forms.Button btAlterarSessao;
        private System.Windows.Forms.Button btSalvarSessao;
        private System.Windows.Forms.Button btCancelarSessao;
        private System.Windows.Forms.Button btSairSessao;
        private System.Windows.Forms.Button btExcluirSessao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtdExibicao;
        private System.Windows.Forms.DateTimePicker dthorario;
        private System.Windows.Forms.ComboBox cmbIdFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSalaCinema;
        private System.Windows.Forms.Label label4;
    }
}