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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Munedit = new System.Windows.Forms.ToolStripMenuItem();
            this.Munlanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.Mungerman = new System.Windows.Forms.ToolStripMenuItem();
            this.Munenglish = new System.Windows.Forms.ToolStripMenuItem();
            this.Munfrance = new System.Windows.Forms.ToolStripMenuItem();
            this.MunCboLength = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Enabled = false;
            this.CmdSearch.Location = new System.Drawing.Point(573, 38);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(162, 23);
            this.CmdSearch.TabIndex = 0;
            this.CmdSearch.Text = "Search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearcher
            // 
            this.TxtSearcher.Location = new System.Drawing.Point(573, 67);
            this.TxtSearcher.Name = "TxtSearcher";
            this.TxtSearcher.Size = new System.Drawing.Size(162, 20);
            this.TxtSearcher.TabIndex = 1;
            this.TxtSearcher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSearcher.TextChanged += new System.EventHandler(this.TxtSearcher_TextChanged);
            // 
            // LstNews
            // 
            this.LstNews.FormattingEnabled = true;
            this.LstNews.Location = new System.Drawing.Point(12, 38);
            this.LstNews.Name = "LstNews";
            this.LstNews.Size = new System.Drawing.Size(554, 277);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Munedit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Munedit
            // 
            this.Munedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Munlanguage,
            this.MunCboLength});
            this.Munedit.Name = "Munedit";
            this.Munedit.Size = new System.Drawing.Size(39, 20);
            this.Munedit.Text = "Edit";
            // 
            // Munlanguage
            // 
            this.Munlanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mungerman,
            this.Munenglish,
            this.Munfrance});
            this.Munlanguage.Name = "Munlanguage";
            this.Munlanguage.Size = new System.Drawing.Size(181, 22);
            this.Munlanguage.Text = "Language";
            // 
            // Mungerman
            // 
            this.Mungerman.Name = "Mungerman";
            this.Mungerman.Size = new System.Drawing.Size(152, 22);
            this.Mungerman.Text = "German";
            this.Mungerman.Click += new System.EventHandler(this.Mungerman_Click);
            // 
            // Munenglish
            // 
            this.Munenglish.Checked = true;
            this.Munenglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Munenglish.Name = "Munenglish";
            this.Munenglish.Size = new System.Drawing.Size(152, 22);
            this.Munenglish.Text = "English";
            this.Munenglish.Click += new System.EventHandler(this.Munenglish_Click);
            // 
            // Munfrance
            // 
            this.Munfrance.Name = "Munfrance";
            this.Munfrance.Size = new System.Drawing.Size(152, 22);
            this.Munfrance.Text = "France";
            this.Munfrance.Click += new System.EventHandler(this.Munfrance_Click);
            // 
            // MunCboLength
            // 
            this.MunCboLength.Name = "MunCboLength";
            this.MunCboLength.Size = new System.Drawing.Size(121, 23);
            // 
            // FrmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 459);
            this.Controls.Add(this.Lblinfo);
            this.Controls.Add(this.LstNews);
            this.Controls.Add(this.TxtSearcher);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNews";
            this.Text = "News";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearcher;
        private System.Windows.Forms.ListBox LstNews;
        private System.Windows.Forms.Label Lblinfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Munedit;
        private System.Windows.Forms.ToolStripMenuItem Munlanguage;
        private System.Windows.Forms.ToolStripMenuItem Mungerman;
        private System.Windows.Forms.ToolStripMenuItem Munenglish;
        private System.Windows.Forms.ToolStripMenuItem Munfrance;
        private System.Windows.Forms.ToolStripComboBox MunCboLength;
    }
}

