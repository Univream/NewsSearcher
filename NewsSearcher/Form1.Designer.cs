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
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(189, 13);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(110, 23);
            this.CmdSearch.TabIndex = 0;
            this.CmdSearch.Text = "Search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearcher
            // 
            this.TxtSearcher.Location = new System.Drawing.Point(189, 43);
            this.TxtSearcher.Name = "TxtSearcher";
            this.TxtSearcher.Size = new System.Drawing.Size(110, 20);
            this.TxtSearcher.TabIndex = 1;
            this.TxtSearcher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LstNews
            // 
            this.LstNews.FormattingEnabled = true;
            this.LstNews.Location = new System.Drawing.Point(13, 13);
            this.LstNews.Name = "LstNews";
            this.LstNews.Size = new System.Drawing.Size(170, 251);
            this.LstNews.TabIndex = 2;
            // 
            // FrmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 281);
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
    }
}

