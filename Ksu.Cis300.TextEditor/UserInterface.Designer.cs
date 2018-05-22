namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.uxmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxtextBox = new System.Windows.Forms.TextBox();
            this.uxopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxmenuStrip
            // 
            this.uxmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uxmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxmenuStrip.Name = "uxmenuStrip";
            this.uxmenuStrip.Size = new System.Drawing.Size(535, 24);
            this.uxmenuStrip.TabIndex = 0;
            this.uxmenuStrip.Text = "uxmenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // uxtextBox
            // 
            this.uxtextBox.Location = new System.Drawing.Point(12, 27);
            this.uxtextBox.Multiline = true;
            this.uxtextBox.Name = "uxtextBox";
            this.uxtextBox.Size = new System.Drawing.Size(511, 304);
            this.uxtextBox.TabIndex = 1;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 343);
            this.Controls.Add(this.uxtextBox);
            this.Controls.Add(this.uxmenuStrip);
            this.MainMenuStrip = this.uxmenuStrip;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxmenuStrip.ResumeLayout(false);
            this.uxmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.TextBox uxtextBox;
        private System.Windows.Forms.OpenFileDialog uxopenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxsaveFileDialog;
    }
}

