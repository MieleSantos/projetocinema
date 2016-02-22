namespace projetocinema.Visao
{
    partial class Frmprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atordiretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atuacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.cadastroToolStripMenuItem1,
            this.sairToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(485, 25);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "Menu";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atordiretorToolStripMenuItem,
            this.diretorToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.atuacaoToolStripMenuItem,
            this.cinemToolStripMenuItem,
            this.sessaoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.cadastroToolStripMenuItem.Text = "Novo";
            // 
            // atordiretorToolStripMenuItem
            // 
            this.atordiretorToolStripMenuItem.Name = "atordiretorToolStripMenuItem";
            this.atordiretorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atordiretorToolStripMenuItem.Text = "Ator";
            this.atordiretorToolStripMenuItem.Click += new System.EventHandler(this.atorToolStripMenuItem_Click);
            // 
            // diretorToolStripMenuItem
            // 
            this.diretorToolStripMenuItem.Name = "diretorToolStripMenuItem";
            this.diretorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.diretorToolStripMenuItem.Text = "Diretor";
            this.diretorToolStripMenuItem.Click += new System.EventHandler(this.diretorToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // atuacaoToolStripMenuItem
            // 
            this.atuacaoToolStripMenuItem.Name = "atuacaoToolStripMenuItem";
            this.atuacaoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atuacaoToolStripMenuItem.Text = "Atuacao";
            this.atuacaoToolStripMenuItem.Click += new System.EventHandler(this.atuacaoToolStripMenuItem_Click);
            // 
            // cinemToolStripMenuItem
            // 
            this.cinemToolStripMenuItem.Name = "cinemToolStripMenuItem";
            this.cinemToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cinemToolStripMenuItem.Text = "Cinemas";
            this.cinemToolStripMenuItem.Click += new System.EventHandler(this.cinemToolStripMenuItem_Click);
            // 
            // sessaoToolStripMenuItem
            // 
            this.sessaoToolStripMenuItem.Name = "sessaoToolStripMenuItem";
            this.sessaoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sessaoToolStripMenuItem.Text = "Sessão";
            this.sessaoToolStripMenuItem.Click += new System.EventHandler(this.sessaoToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(137, 21);
            this.cadastroToolStripMenuItem1.Text = "Cadastro de Pessoa";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemasToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.sairToolStripMenuItem.Text = "Pesquisas";
            // 
            // cinemasToolStripMenuItem
            // 
            this.cinemasToolStripMenuItem.Name = "cinemasToolStripMenuItem";
            this.cinemasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cinemasToolStripMenuItem.Text = "Cinema";
            this.cinemasToolStripMenuItem.Click += new System.EventHandler(this.PesquisaToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.relatorioToolStripMenuItem.Text = "Informações";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.dadosToolStripMenuItem.Text = "Dados de conexão com o banco de dados";
            this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(327, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(42, 21);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 530);
            this.ControlBox = false;
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-Vindo ao Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atordiretorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atuacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diretorToolStripMenuItem;
    }
}

