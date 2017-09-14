namespace NewsSearcher
{
    partial class FrmNews
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearcher = new System.Windows.Forms.TextBox();
            this.LstNews = new System.Windows.Forms.ListBox();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Enabled = false;
            this.CmdSearch.Location = new System.Drawing.Point(406, 13);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(144, 23);
            this.CmdSearch.TabIndex = 0;
            this.CmdSearch.Text = "Search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearcher
            // 
            this.TxtSearcher.Location = new System.Drawing.Point(406, 44);
            this.TxtSearcher.Name = "TxtSearcher";
            this.TxtSearcher.Size = new System.Drawing.Size(144, 20);
            this.TxtSearcher.TabIndex = 1;
            this.TxtSearcher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSearcher.TextChanged += new System.EventHandler(this.TxtSearcher_TextChanged);
            // 
            // LstNews
            // 
            this.LstNews.FormattingEnabled = true;
            this.LstNews.Location = new System.Drawing.Point(13, 13);
            this.LstNews.Name = "LstNews";
            this.LstNews.Size = new System.Drawing.Size(387, 303);
            this.LstNews.TabIndex = 2;
            this.LstNews.SelectedIndexChanged += new System.EventHandler(this.LstNews_SelectedIndexChanged);
            // 
            // Lblinfo
            // 
            this.Lblinfo.AutoSize = true;
            this.Lblinfo.Location = new System.Drawing.Point(12, 328);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(0, 13);
            this.Lblinfo.TabIndex = 3;
            // 
            // FrmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 459);
            this.Controls.Add(this.Lblinfo);
            this.Controls.Add(this.LstNews);
            this.Controls.Add(this.TxtSearcher);
            this.Controls.Add(this.CmdSearch);
            this.Name = "FrmNews";
            this.Text = "News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearcher;
        private System.Windows.Forms.ListBox LstNews;
        private System.Windows.Forms.Label Lblinfo;
    }
}

