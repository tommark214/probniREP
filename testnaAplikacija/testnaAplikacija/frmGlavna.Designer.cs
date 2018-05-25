namespace testnaAplikacija
{
    partial class frmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiITimoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodavanjeToolStripMenuItem
            // 
            this.dodavanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiITimoviToolStripMenuItem});
            this.dodavanjeToolStripMenuItem.Name = "dodavanjeToolStripMenuItem";
            this.dodavanjeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.dodavanjeToolStripMenuItem.Text = "Dodavanje";
            // 
            // studentiITimoviToolStripMenuItem
            // 
            this.studentiITimoviToolStripMenuItem.Name = "studentiITimoviToolStripMenuItem";
            this.studentiITimoviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiITimoviToolStripMenuItem.Text = "Studenti i timovi";
            this.studentiITimoviToolStripMenuItem.Click += new System.EventHandler(this.studentiITimoviToolStripMenuItem_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGlavna";
            this.Text = "frmGlavna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiITimoviToolStripMenuItem;
    }
}