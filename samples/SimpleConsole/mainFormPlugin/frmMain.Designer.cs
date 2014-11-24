namespace mainFormPlugin
{
    partial class frmMain
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
            this.pgcMain = new System.Windows.Forms.TabControl();
            this.tsMain = new System.Windows.Forms.TabPage();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.muiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pgcMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgcMain
            // 
            this.pgcMain.Controls.Add(this.tsMain);
            this.pgcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgcMain.Location = new System.Drawing.Point(0, 25);
            this.pgcMain.Name = "pgcMain";
            this.pgcMain.SelectedIndex = 0;
            this.pgcMain.Size = new System.Drawing.Size(717, 363);
            this.pgcMain.TabIndex = 0;
            // 
            // tsMain
            // 
            this.tsMain.Location = new System.Drawing.Point(4, 22);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(3);
            this.tsMain.Size = new System.Drawing.Size(709, 337);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "主页";
            this.tsMain.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muiFile,
            this.muiAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(717, 25);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "主菜单";
            // 
            // muiFile
            // 
            this.muiFile.Name = "muiFile";
            this.muiFile.Size = new System.Drawing.Size(58, 21);
            this.muiFile.Text = "文件(&F)";
            // 
            // muiAbout
            // 
            this.muiAbout.Name = "muiAbout";
            this.muiAbout.Size = new System.Drawing.Size(60, 21);
            this.muiAbout.Text = "关于(&A)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.Controls.Add(this.pgcMain);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.pgcMain.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl pgcMain;
        private System.Windows.Forms.TabPage tsMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem muiFile;
        private System.Windows.Forms.ToolStripMenuItem muiAbout;
    }
}