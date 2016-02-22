namespace projetocinema.Visao
{
    partial class FrmConfiguracao
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
            this.gbConexao = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtBancoUsuario = new System.Windows.Forms.TextBox();
            this.txctPortaConexao = new System.Windows.Forms.TextBox();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvarDados = new System.Windows.Forms.Button();
            this.btTestaConexao = new System.Windows.Forms.Button();
            this.btSairBanco = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConexao
            // 
            this.gbConexao.Controls.Add(this.txtSenha);
            this.gbConexao.Controls.Add(this.txtBancoUsuario);
            this.gbConexao.Controls.Add(this.txctPortaConexao);
            this.gbConexao.Controls.Add(this.txtBancoDados);
            this.gbConexao.Controls.Add(this.txtServidor);
            this.gbConexao.Controls.Add(this.label5);
            this.gbConexao.Controls.Add(this.label4);
            this.gbConexao.Controls.Add(this.label3);
            this.gbConexao.Controls.Add(this.label2);
            this.gbConexao.Controls.Add(this.label1);
            this.gbConexao.Location = new System.Drawing.Point(23, 37);
            this.gbConexao.Name = "gbConexao";
            this.gbConexao.Size = new System.Drawing.Size(280, 254);
            this.gbConexao.TabIndex = 0;
            this.gbConexao.TabStop = false;
            this.gbConexao.Tag = "";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(20, 168);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(236, 21);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Tag = "";
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtBancoUsuario
            // 
            this.txtBancoUsuario.Location = new System.Drawing.Point(20, 126);
            this.txtBancoUsuario.Name = "txtBancoUsuario";
            this.txtBancoUsuario.Size = new System.Drawing.Size(236, 21);
            this.txtBancoUsuario.TabIndex = 3;
            this.txtBancoUsuario.Tag = "";
            this.txtBancoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBancoUsuario_KeyPress);
            // 
            // txctPortaConexao
            // 
            this.txctPortaConexao.Location = new System.Drawing.Point(20, 85);
            this.txctPortaConexao.Name = "txctPortaConexao";
            this.txctPortaConexao.Size = new System.Drawing.Size(236, 21);
            this.txctPortaConexao.TabIndex = 2;
            this.txctPortaConexao.Tag = "";
            this.txctPortaConexao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txctPortaConexao_KeyPress);
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.Location = new System.Drawing.Point(23, 213);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(236, 21);
            this.txtBancoDados.TabIndex = 5;
            this.txtBancoDados.Tag = "";
            this.txtBancoDados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBancoDados_KeyPress);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(20, 40);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(236, 21);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Tag = "";
            this.txtServidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServidor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porta de Conexão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco de dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // btSalvarDados
            // 
            this.btSalvarDados.Location = new System.Drawing.Point(23, 298);
            this.btSalvarDados.Name = "btSalvarDados";
            this.btSalvarDados.Size = new System.Drawing.Size(87, 40);
            this.btSalvarDados.TabIndex = 6;
            this.btSalvarDados.Tag = "";
            this.btSalvarDados.Text = "Salvar dados";
            this.btSalvarDados.UseVisualStyleBackColor = true;
            this.btSalvarDados.Click += new System.EventHandler(this.btSalvarDados_Click);
            // 
            // btTestaConexao
            // 
            this.btTestaConexao.Location = new System.Drawing.Point(120, 298);
            this.btTestaConexao.Name = "btTestaConexao";
            this.btTestaConexao.Size = new System.Drawing.Size(87, 40);
            this.btTestaConexao.TabIndex = 7;
            this.btTestaConexao.Tag = "";
            this.btTestaConexao.Text = "Testar conexão";
            this.btTestaConexao.UseVisualStyleBackColor = true;
            this.btTestaConexao.Click += new System.EventHandler(this.btTestaConexao_Click);
            // 
            // btSairBanco
            // 
            this.btSairBanco.Location = new System.Drawing.Point(215, 298);
            this.btSairBanco.Name = "btSairBanco";
            this.btSairBanco.Size = new System.Drawing.Size(87, 40);
            this.btSairBanco.TabIndex = 8;
            this.btSairBanco.Tag = "";
            this.btSairBanco.Text = "Sair";
            this.btSairBanco.UseVisualStyleBackColor = true;
            this.btSairBanco.Click += new System.EventHandler(this.btSairBanco_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Conexão com o bando de dados";
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(322, 352);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSairBanco);
            this.Controls.Add(this.btTestaConexao);
            this.Controls.Add(this.btSalvarDados);
            this.Controls.Add(this.gbConexao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar arquivo de registro";
            this.gbConexao.ResumeLayout(false);
            this.gbConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConexao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtBancoUsuario;
        private System.Windows.Forms.TextBox txctPortaConexao;
        private System.Windows.Forms.TextBox txtBancoDados;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvarDados;
        private System.Windows.Forms.Button btTestaConexao;
        private System.Windows.Forms.Button btSairBanco;
        private System.Windows.Forms.Label label6;
    }
}