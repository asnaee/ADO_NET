namespace FINAL
{
    partial class Form1
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
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiutorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiutorEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiutorUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiutorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiutorEntryToolStripMenuItem,
            this.subjectEntryToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // tiutorEntryToolStripMenuItem
            // 
            this.tiutorEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiutorEntryToolStripMenuItem1,
            this.tiutorUpdateDeleteToolStripMenuItem,
            this.tiutorListToolStripMenuItem});
            this.tiutorEntryToolStripMenuItem.Name = "tiutorEntryToolStripMenuItem";
            this.tiutorEntryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tiutorEntryToolStripMenuItem.Text = "TiutorInformation";
            // 
            // tiutorEntryToolStripMenuItem1
            // 
            this.tiutorEntryToolStripMenuItem1.Name = "tiutorEntryToolStripMenuItem1";
            this.tiutorEntryToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.tiutorEntryToolStripMenuItem1.Text = "TiutorEntry";
            this.tiutorEntryToolStripMenuItem1.Click += new System.EventHandler(this.tiutorEntryToolStripMenuItem1_Click);
            // 
            // tiutorUpdateDeleteToolStripMenuItem
            // 
            this.tiutorUpdateDeleteToolStripMenuItem.Name = "tiutorUpdateDeleteToolStripMenuItem";
            this.tiutorUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tiutorUpdateDeleteToolStripMenuItem.Text = "TiutorUpdate/Delete";
            this.tiutorUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.tiutorUpdateDeleteToolStripMenuItem_Click);
            // 
            // tiutorListToolStripMenuItem
            // 
            this.tiutorListToolStripMenuItem.Name = "tiutorListToolStripMenuItem";
            this.tiutorListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tiutorListToolStripMenuItem.Text = "Tiutor List";
            this.tiutorListToolStripMenuItem.Click += new System.EventHandler(this.tiutorListToolStripMenuItem_Click);
            // 
            // subjectEntryToolStripMenuItem
            // 
            this.subjectEntryToolStripMenuItem.Name = "subjectEntryToolStripMenuItem";
            this.subjectEntryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.subjectEntryToolStripMenuItem.Text = "SubjectEntry";
            this.subjectEntryToolStripMenuItem.Click += new System.EventHandler(this.subjectEntryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiutorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiutorEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiutorUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiutorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
    }
}

