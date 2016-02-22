namespace projetocinema.Visao
{
    partial class FrmAtuacao
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
            this.gbAtuacao = new System.Windows.Forms.GroupBox();
            this.panFilme = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listFilme = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listArtista = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAtuacao = new System.Windows.Forms.TextBox();
            this.gbDadosAtuacao = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgDadoAtuacao = new System.Windows.Forms.DataGridView();
            this.btNovoAtuacao = new System.Windows.Forms.Button();
            this.btSalvarAtuacao = new System.Windows.Forms.Button();
            this.btAlterarAtuacao = new System.Windows.Forms.Button();
            this.btCancelarAtuacao = new System.Windows.Forms.Button();
            this.btExcluirAtuacao = new System.Windows.Forms.Button();
            this.btSairAtuacao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAtuacao.SuspendLayout();
            this.panFilme.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDadosAtuacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadoAtuacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAtuacao
            // 
            this.gbAtuacao.Controls.Add(this.panFilme);
            this.gbAtuacao.Controls.Add(this.panel2);
            this.gbAtuacao.Controls.Add(this.label4);
            this.gbAtuacao.Controls.Add(this.txtIdAtuacao);
            this.gbAtuacao.Location = new System.Drawing.Point(10, 39);
            this.gbAtuacao.Name = "gbAtuacao";
            this.gbAtuacao.Size = new System.Drawing.Size(441, 186);
            this.gbAtuacao.TabIndex = 0;
            this.gbAtuacao.TabStop = false;
            // 
            // panFilme
            // 
            this.panFilme.Controls.Add(this.label6);
            this.panFilme.Controls.Add(this.listFilme);
            this.panFilme.Location = new System.Drawing.Point(220, 70);
            this.panFilme.Name = "panFilme";
            this.panFilme.Size = new System.Drawing.Size(208, 108);
            this.panFilme.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filmes";
            // 
            // listFilme
            // 
            this.listFilme.FormattingEnabled = true;
            this.listFilme.ItemHeight = 15;
            this.listFilme.Location = new System.Drawing.Point(0, 24);
            this.listFilme.Name = "listFilme";
            this.listFilme.Size = new System.Drawing.Size(207, 79);
            this.listFilme.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listArtista);
            this.panel2.Location = new System.Drawing.Point(7, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 108);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Artistas";
            // 
            // listArtista
            // 
            this.listArtista.FormattingEnabled = true;
            this.listArtista.ItemHeight = 15;
            this.listArtista.Location = new System.Drawing.Point(0, 23);
            this.listArtista.Name = "listArtista";
            this.listArtista.Size = new System.Drawing.Size(193, 79);
            this.listArtista.TabIndex = 0;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo*";
            // 
            // txtIdAtuacao
            // 
            this.txtIdAtuacao.Enabled = false;
            this.txtIdAtuacao.Location = new System.Drawing.Point(14, 38);
            this.txtIdAtuacao.MaxLength = 5;
            this.txtIdAtuacao.Name = "txtIdAtuacao";
            this.txtIdAtuacao.Size = new System.Drawing.Size(100, 21);
            this.txtIdAtuacao.TabIndex = 1;
            this.txtIdAtuacao.Tag = "f";
            // 
            // gbDadosAtuacao
            // 
            this.gbDadosAtuacao.Controls.Add(this.txtConsulta);
            this.gbDadosAtuacao.Controls.Add(this.label5);
            this.gbDadosAtuacao.Controls.Add(this.dgDadoAtuacao);
            this.gbDadosAtuacao.Location = new System.Drawing.Point(10, 275);
            this.gbDadosAtuacao.Name = "gbDadosAtuacao";
            this.gbDadosAtuacao.Size = new System.Drawing.Size(441, 211);
            this.gbDadosAtuacao.TabIndex = 1;
            this.gbDadosAtuacao.TabStop = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(90, 20);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(338, 21);
            this.txtConsulta.TabIndex = 2;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Consulta";
            // 
            // dgDadoAtuacao
            // 
            this.dgDadoAtuacao.AllowUserToAddRows = false;
            this.dgDadoAtuacao.AllowUserToDeleteRows = false;
            this.dgDadoAtuacao.AllowUserToOrderColumns = true;
            this.dgDadoAtuacao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDadoAtuacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDadoAtuacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadoAtuacao.Location = new System.Drawing.Point(14, 50);
            this.dgDadoAtuacao.Name = "dgDadoAtuacao";
            this.dgDadoAtuacao.ReadOnly = true;
            this.dgDadoAtuacao.Size = new System.Drawing.Size(414, 156);
            this.dgDadoAtuacao.TabIndex = 0;
            this.dgDadoAtuacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDadoAtuacao_CellClick);
            // 
            // btNovoAtuacao
            // 
            this.btNovoAtuacao.Location = new System.Drawing.Point(10, 232);
            this.btNovoAtuacao.Name = "btNovoAtuacao";
            this.btNovoAtuacao.Size = new System.Drawing.Size(66, 36);
            this.btNovoAtuacao.TabIndex = 2;
            this.btNovoAtuacao.Text = "Novo";
            this.btNovoAtuacao.UseVisualStyleBackColor = true;
            this.btNovoAtuacao.Click += new System.EventHandler(this.btNovoAtuacao_Click);
            // 
            // btSalvarAtuacao
            // 
            this.btSalvarAtuacao.Location = new System.Drawing.Point(84, 232);
            this.btSalvarAtuacao.Name = "btSalvarAtuacao";
            this.btSalvarAtuacao.Size = new System.Drawing.Size(66, 36);
            this.btSalvarAtuacao.TabIndex = 3;
            this.btSalvarAtuacao.Text = "Salvar";
            this.btSalvarAtuacao.UseVisualStyleBackColor = true;
            this.btSalvarAtuacao.Click += new System.EventHandler(this.btSalvarAtuacao_Click);
            // 
            // btAlterarAtuacao
            // 
            this.btAlterarAtuacao.Location = new System.Drawing.Point(157, 232);
            this.btAlterarAtuacao.Name = "btAlterarAtuacao";
            this.btAlterarAtuacao.Size = new System.Drawing.Size(66, 36);
            this.btAlterarAtuacao.TabIndex = 4;
            this.btAlterarAtuacao.Text = "Alterar";
            this.btAlterarAtuacao.UseVisualStyleBackColor = true;
            this.btAlterarAtuacao.Click += new System.EventHandler(this.btAlterarAtuacao_Click);
            // 
            // btCancelarAtuacao
            // 
            this.btCancelarAtuacao.Location = new System.Drawing.Point(231, 232);
            this.btCancelarAtuacao.Name = "btCancelarAtuacao";
            this.btCancelarAtuacao.Size = new System.Drawing.Size(69, 36);
            this.btCancelarAtuacao.TabIndex = 5;
            this.btCancelarAtuacao.Text = "Cancelar";
            this.btCancelarAtuacao.UseVisualStyleBackColor = true;
            this.btCancelarAtuacao.Click += new System.EventHandler(this.btCancelarAtuacao_Click_1);
            // 
            // btExcluirAtuacao
            // 
            this.btExcluirAtuacao.Location = new System.Drawing.Point(307, 232);
            this.btExcluirAtuacao.Name = "btExcluirAtuacao";
            this.btExcluirAtuacao.Size = new System.Drawing.Size(65, 36);
            this.btExcluirAtuacao.TabIndex = 6;
            this.btExcluirAtuacao.Text = "Excluir";
            this.btExcluirAtuacao.UseVisualStyleBackColor = true;
            this.btExcluirAtuacao.Click += new System.EventHandler(this.btExcluirAtuacao_Click);
            // 
            // btSairAtuacao
            // 
            this.btSairAtuacao.Location = new System.Drawing.Point(379, 232);
            this.btSairAtuacao.Name = "btSairAtuacao";
            this.btSairAtuacao.Size = new System.Drawing.Size(72, 36);
            this.btSairAtuacao.TabIndex = 7;
            this.btSairAtuacao.Text = "Sair";
            this.btSairAtuacao.UseVisualStyleBackColor = true;
            this.btSairAtuacao.Click += new System.EventHandler(this.btSairAtuacao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "* Preencimento obrigatório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Atuação dos artista nos filmes";
            // 
            // FrmAtuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(458, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btSairAtuacao);
            this.Controls.Add(this.btExcluirAtuacao);
            this.Controls.Add(this.btCancelarAtuacao);
            this.Controls.Add(this.btAlterarAtuacao);
            this.Controls.Add(this.btSalvarAtuacao);
            this.Controls.Add(this.btNovoAtuacao);
            this.Controls.Add(this.gbDadosAtuacao);
            this.Controls.Add(this.gbAtuacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAtuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAtuacao_Load);
            this.gbAtuacao.ResumeLayout(false);
            this.gbAtuacao.PerformLayout();
            this.panFilme.ResumeLayout(false);
            this.panFilme.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbDadosAtuacao.ResumeLayout(false);
            this.gbDadosAtuacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadoAtuacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAtuacao;
        private System.Windows.Forms.GroupBox gbDadosAtuacao;
        private System.Windows.Forms.Button btNovoAtuacao;
        private System.Windows.Forms.Button btSalvarAtuacao;
        private System.Windows.Forms.Button btAlterarAtuacao;
        private System.Windows.Forms.Button btCancelarAtuacao;
        private System.Windows.Forms.Button btExcluirAtuacao;
        private System.Windows.Forms.Button btSairAtuacao;
        private System.Windows.Forms.DataGridView dgDadoAtuacao;
        private System.Windows.Forms.TextBox txtIdAtuacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panFilme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listArtista;
        private System.Windows.Forms.Label label1;
    }
}