namespace projetocinema.Visao
{
    partial class FrmTelaInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicio));
            this.prbStatus = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tmhoras = new System.Windows.Forms.Timer(this.components);
            this.pctboxImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // prbStatus
            // 
            this.prbStatus.Location = new System.Drawing.Point(21, 348);
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(406, 23);
            this.prbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbStatus.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Black;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStatus.Location = new System.Drawing.Point(413, 333);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "label1";
            // 
            // tmhoras
            // 
            this.tmhoras.Tick += new System.EventHandler(this.tmhoras_Tick);
            // 
            // pctboxImagem
            // 
            this.pctboxImagem.BackColor = System.Drawing.Color.Silver;
            this.pctboxImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctboxImagem.Image")));
            this.pctboxImagem.InitialImage = null;
            this.pctboxImagem.Location = new System.Drawing.Point(2, 1);
            this.pctboxImagem.Name = "pctboxImagem";
            this.pctboxImagem.Size = new System.Drawing.Size(446, 318);
            this.pctboxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxImagem.TabIndex = 0;
            this.pctboxImagem.TabStop = false;
            // 
            // FrmTelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(449, 383);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.prbStatus);
            this.Controls.Add(this.pctboxImagem);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxImagem;
        private System.Windows.Forms.ProgressBar prbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Timer tmhoras;
    }
}