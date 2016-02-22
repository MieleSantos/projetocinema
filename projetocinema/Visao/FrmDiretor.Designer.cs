namespace projetocinema.Visao
{
    partial class FrmDiretor
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
            this.gbxDiretor = new System.Windows.Forms.GroupBox();
            this.txtNomeD = new System.Windows.Forms.TextBox();
            this.txtCodigoD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNovoD = new System.Windows.Forms.Button();
            this.btSalvarD = new System.Windows.Forms.Button();
            this.btAlterarD = new System.Windows.Forms.Button();
            this.btCancelarD = new System.Windows.Forms.Button();
            this.btExcluirD = new System.Windows.Forms.Button();
            this.btSairD = new System.Windows.Forms.Button();
            this.gpxdadosDiretor = new System.Windows.Forms.GroupBox();
            this.dtgDiretor = new System.Windows.Forms.DataGridView();
            this.txtConcultaD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxDiretor.SuspendLayout();
            this.gpxdadosDiretor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiretor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDiretor
            // 
            this.gbxDiretor.Controls.Add(this.txtNomeD);
            this.gbxDiretor.Controls.Add(this.txtCodigoD);
            this.gbxDiretor.Controls.Add(this.label2);
            this.gbxDiretor.Controls.Add(this.label1);
            this.gbxDiretor.Location = new System.Drawing.Point(17, 44);
            this.gbxDiretor.Name = "gbxDiretor";
            this.gbxDiretor.Size = new System.Drawing.Size(386, 90);
            this.gbxDiretor.TabIndex = 0;
            this.gbxDiretor.TabStop = false;
            // 
            // txtNomeD
            // 
            this.txtNomeD.Location = new System.Drawing.Point(101, 43);
            this.txtNomeD.MaxLength = 40;
            this.txtNomeD.Name = "txtNomeD";
            this.txtNomeD.Size = new System.Drawing.Size(267, 21);
            this.txtNomeD.TabIndex = 2;
            this.txtNomeD.Tag = "Nome";
            this.txtNomeD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeD_KeyPress);
            // 
            // txtCodigoD
            // 
            this.txtCodigoD.Enabled = false;
            this.txtCodigoD.Location = new System.Drawing.Point(12, 43);
            this.txtCodigoD.MaxLength = 5;
            this.txtCodigoD.Name = "txtCodigoD";
            this.txtCodigoD.Size = new System.Drawing.Size(72, 21);
            this.txtCodigoD.TabIndex = 1;
            this.txtCodigoD.Tag = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código*";
            // 
            // btNovoD
            // 
            this.btNovoD.Location = new System.Drawing.Point(17, 141);
            this.btNovoD.Name = "btNovoD";
            this.btNovoD.Size = new System.Drawing.Size(58, 33);
            this.btNovoD.TabIndex = 1;
            this.btNovoD.Text = "Novo";
            this.btNovoD.UseVisualStyleBackColor = true;
            this.btNovoD.Click += new System.EventHandler(this.btNovoD_Click);
            // 
            // btSalvarD
            // 
            this.btSalvarD.Location = new System.Drawing.Point(85, 141);
            this.btSalvarD.Name = "btSalvarD";
            this.btSalvarD.Size = new System.Drawing.Size(58, 33);
            this.btSalvarD.TabIndex = 2;
            this.btSalvarD.Text = "Salvar";
            this.btSalvarD.UseVisualStyleBackColor = true;
            this.btSalvarD.Click += new System.EventHandler(this.btSalvarD_Click);
            // 
            // btAlterarD
            // 
            this.btAlterarD.Location = new System.Drawing.Point(150, 141);
            this.btAlterarD.Name = "btAlterarD";
            this.btAlterarD.Size = new System.Drawing.Size(58, 33);
            this.btAlterarD.TabIndex = 3;
            this.btAlterarD.Text = "Alterar";
            this.btAlterarD.UseVisualStyleBackColor = true;
            this.btAlterarD.Click += new System.EventHandler(this.btAlterarD_Click);
            // 
            // btCancelarD
            // 
            this.btCancelarD.Location = new System.Drawing.Point(216, 141);
            this.btCancelarD.Name = "btCancelarD";
            this.btCancelarD.Size = new System.Drawing.Size(58, 33);
            this.btCancelarD.TabIndex = 4;
            this.btCancelarD.Text = "Cancel";
            this.btCancelarD.UseVisualStyleBackColor = true;
            this.btCancelarD.Click += new System.EventHandler(this.btCancelarD_Click);
            // 
            // btExcluirD
            // 
            this.btExcluirD.Location = new System.Drawing.Point(281, 141);
            this.btExcluirD.Name = "btExcluirD";
            this.btExcluirD.Size = new System.Drawing.Size(58, 33);
            this.btExcluirD.TabIndex = 5;
            this.btExcluirD.Text = "Excluir";
            this.btExcluirD.UseVisualStyleBackColor = true;
            this.btExcluirD.Click += new System.EventHandler(this.btExcluirD_Click);
            // 
            // btSairD
            // 
            this.btSairD.Location = new System.Drawing.Point(346, 141);
            this.btSairD.Name = "btSairD";
            this.btSairD.Size = new System.Drawing.Size(58, 33);
            this.btSairD.TabIndex = 6;
            this.btSairD.Text = "Sair";
            this.btSairD.UseVisualStyleBackColor = true;
            this.btSairD.Click += new System.EventHandler(this.btSairD_Click);
            // 
            // gpxdadosDiretor
            // 
            this.gpxdadosDiretor.Controls.Add(this.dtgDiretor);
            this.gpxdadosDiretor.Controls.Add(this.txtConcultaD);
            this.gpxdadosDiretor.Controls.Add(this.label3);
            this.gpxdadosDiretor.Location = new System.Drawing.Point(17, 181);
            this.gpxdadosDiretor.Name = "gpxdadosDiretor";
            this.gpxdadosDiretor.Size = new System.Drawing.Size(386, 225);
            this.gpxdadosDiretor.TabIndex = 2;
            this.gpxdadosDiretor.TabStop = false;
            // 
            // dtgDiretor
            // 
            this.dtgDiretor.AllowUserToAddRows = false;
            this.dtgDiretor.AllowUserToDeleteRows = false;
            this.dtgDiretor.AllowUserToOrderColumns = true;
            this.dtgDiretor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDiretor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDiretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiretor.Location = new System.Drawing.Point(12, 53);
            this.dtgDiretor.Name = "dtgDiretor";
            this.dtgDiretor.ReadOnly = true;
            this.dtgDiretor.Size = new System.Drawing.Size(356, 166);
            this.dtgDiretor.TabIndex = 2;
            this.dtgDiretor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiretor_CellClick);
            // 
            // txtConcultaD
            // 
            this.txtConcultaD.Location = new System.Drawing.Point(67, 20);
            this.txtConcultaD.Name = "txtConcultaD";
            this.txtConcultaD.Size = new System.Drawing.Size(301, 21);
            this.txtConcultaD.TabIndex = 1;
            this.txtConcultaD.TextChanged += new System.EventHandler(this.txtConcultaD_TextChanged);
            this.txtConcultaD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcultaD_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "* Preencimento obrigatório";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cadastro de Diretor";
            // 
            // FrmDiretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(415, 435);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gpxdadosDiretor);
            this.Controls.Add(this.btSairD);
            this.Controls.Add(this.btExcluirD);
            this.Controls.Add(this.btCancelarD);
            this.Controls.Add(this.btAlterarD);
            this.Controls.Add(this.btSalvarD);
            this.Controls.Add(this.btNovoD);
            this.Controls.Add(this.gbxDiretor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiretor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de diretor";
            this.Load += new System.EventHandler(this.FrmDiretor_Load);
            this.gbxDiretor.ResumeLayout(false);
            this.gbxDiretor.PerformLayout();
            this.gpxdadosDiretor.ResumeLayout(false);
            this.gpxdadosDiretor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiretor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDiretor;
        private System.Windows.Forms.TextBox txtNomeD;
        private System.Windows.Forms.TextBox txtCodigoD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNovoD;
        private System.Windows.Forms.Button btSalvarD;
        private System.Windows.Forms.Button btAlterarD;
        private System.Windows.Forms.Button btCancelarD;
        private System.Windows.Forms.Button btExcluirD;
        private System.Windows.Forms.Button btSairD;
        private System.Windows.Forms.GroupBox gpxdadosDiretor;
        private System.Windows.Forms.DataGridView dtgDiretor;
        private System.Windows.Forms.TextBox txtConcultaD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}