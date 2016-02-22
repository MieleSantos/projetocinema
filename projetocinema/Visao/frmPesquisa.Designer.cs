namespace projetocinema.Visao
{
    partial class frmPesquisa
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
            this.gbPesquisaDados = new System.Windows.Forms.GroupBox();
            this.btnPesCinema = new System.Windows.Forms.Button();
            this.Cidade = new System.Windows.Forms.Label();
            this.btPesquisaCidade = new System.Windows.Forms.Button();
            this.txtPesquisaCidade = new System.Windows.Forms.TextBox();
            this.btPSair = new System.Windows.Forms.Button();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtResuPesFilme = new System.Windows.Forms.DataGridView();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btVerFilmes = new System.Windows.Forms.Button();
            this.txtConsultaFilmeP = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPesquisaDados.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResuPesFilme)).BeginInit();
            this.gbxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPesquisaDados
            // 
            this.gbPesquisaDados.Controls.Add(this.btnPesCinema);
            this.gbPesquisaDados.Controls.Add(this.Cidade);
            this.gbPesquisaDados.Controls.Add(this.btPesquisaCidade);
            this.gbPesquisaDados.Controls.Add(this.txtPesquisaCidade);
            this.gbPesquisaDados.Location = new System.Drawing.Point(14, 52);
            this.gbPesquisaDados.Name = "gbPesquisaDados";
            this.gbPesquisaDados.Size = new System.Drawing.Size(299, 167);
            this.gbPesquisaDados.TabIndex = 0;
            this.gbPesquisaDados.TabStop = false;
            // 
            // btnPesCinema
            // 
            this.btnPesCinema.Location = new System.Drawing.Point(173, 95);
            this.btnPesCinema.Name = "btnPesCinema";
            this.btnPesCinema.Size = new System.Drawing.Size(113, 28);
            this.btnPesCinema.TabIndex = 6;
            this.btnPesCinema.Text = "Pesquisa Cinema";
            this.btnPesCinema.UseVisualStyleBackColor = true;
            this.btnPesCinema.Click += new System.EventHandler(this.btnPesCinema_Click);
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(7, 25);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(101, 15);
            this.Cidade.TabIndex = 3;
            this.Cidade.Text = "Consultar Cidade";
            // 
            // btPesquisaCidade
            // 
            this.btPesquisaCidade.Location = new System.Drawing.Point(173, 49);
            this.btPesquisaCidade.Name = "btPesquisaCidade";
            this.btPesquisaCidade.Size = new System.Drawing.Size(113, 28);
            this.btPesquisaCidade.TabIndex = 3;
            this.btPesquisaCidade.Text = "Consulta Cidade ";
            this.btPesquisaCidade.UseVisualStyleBackColor = true;
            this.btPesquisaCidade.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // txtPesquisaCidade
            // 
            this.txtPesquisaCidade.Enabled = false;
            this.txtPesquisaCidade.Location = new System.Drawing.Point(10, 53);
            this.txtPesquisaCidade.Name = "txtPesquisaCidade";
            this.txtPesquisaCidade.Size = new System.Drawing.Size(146, 21);
            this.txtPesquisaCidade.TabIndex = 2;
            // 
            // btPSair
            // 
            this.btPSair.Location = new System.Drawing.Point(872, 3);
            this.btPSair.Name = "btPSair";
            this.btPSair.Size = new System.Drawing.Size(54, 28);
            this.btPSair.TabIndex = 5;
            this.btPSair.Text = "X";
            this.btPSair.UseVisualStyleBackColor = true;
            this.btPSair.Click += new System.EventHandler(this.btPSair_Click);
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPesquisa.Controls.Add(this.label2);
            this.pnPesquisa.Controls.Add(this.dtResuPesFilme);
            this.pnPesquisa.Location = new System.Drawing.Point(14, 256);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(910, 247);
            this.pnPesquisa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Filmes em exibição\r\n";
            // 
            // dtResuPesFilme
            // 
            this.dtResuPesFilme.AllowUserToAddRows = false;
            this.dtResuPesFilme.AllowUserToDeleteRows = false;
            this.dtResuPesFilme.AllowUserToOrderColumns = true;
            this.dtResuPesFilme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtResuPesFilme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtResuPesFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtResuPesFilme.Location = new System.Drawing.Point(8, 32);
            this.dtResuPesFilme.Name = "dtResuPesFilme";
            this.dtResuPesFilme.ReadOnly = true;
            this.dtResuPesFilme.Size = new System.Drawing.Size(895, 200);
            this.dtResuPesFilme.TabIndex = 0;
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.label4);
            this.gbxResultado.Controls.Add(this.btVerFilmes);
            this.gbxResultado.Controls.Add(this.txtConsultaFilmeP);
            this.gbxResultado.Controls.Add(this.dgvPesquisa);
            this.gbxResultado.Location = new System.Drawing.Point(321, 52);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(605, 167);
            this.gbxResultado.TabIndex = 6;
            this.gbxResultado.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Consulta filmes por cinemas";
            // 
            // btVerFilmes
            // 
            this.btVerFilmes.Location = new System.Drawing.Point(497, 13);
            this.btVerFilmes.Name = "btVerFilmes";
            this.btVerFilmes.Size = new System.Drawing.Size(101, 27);
            this.btVerFilmes.TabIndex = 3;
            this.btVerFilmes.Text = "Ver filmes";
            this.btVerFilmes.UseVisualStyleBackColor = true;
            this.btVerFilmes.Click += new System.EventHandler(this.btVerFilmes_Click);
            // 
            // txtConsultaFilmeP
            // 
            this.txtConsultaFilmeP.Enabled = false;
            this.txtConsultaFilmeP.Location = new System.Drawing.Point(174, 19);
            this.txtConsultaFilmeP.Name = "txtConsultaFilmeP";
            this.txtConsultaFilmeP.Size = new System.Drawing.Size(317, 21);
            this.txtConsultaFilmeP.TabIndex = 2;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToOrderColumns = true;
            this.dgvPesquisa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPesquisa.Location = new System.Drawing.Point(6, 46);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(590, 111);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPesquisa_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click no cinema para poder ver a lista de exibição ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Consulte a cidade e depois clica em pesquisa  cinemas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesquisa de Cinemas por cidades ";
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(938, 515);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnPesquisa);
            this.Controls.Add(this.btPSair);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.gbPesquisaDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Cinemas e filmes";
            this.gbPesquisaDados.ResumeLayout(false);
            this.gbPesquisaDados.PerformLayout();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResuPesFilme)).EndInit();
            this.gbxResultado.ResumeLayout(false);
            this.gbxResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPesquisaDados;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Button btPesquisaCidade;
        private System.Windows.Forms.Button btPSair;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btVerFilmes;
        private System.Windows.Forms.TextBox txtConsultaFilmeP;
        private System.Windows.Forms.Panel pnPesquisa;
        private System.Windows.Forms.DataGridView dtResuPesFilme;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPesquisaCidade;
        private System.Windows.Forms.Button btnPesCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}