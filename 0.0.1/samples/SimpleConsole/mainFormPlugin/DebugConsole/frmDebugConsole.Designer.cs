namespace mainFormPlugin.DebugConsole
{
    partial class frmDebugConsole
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.muiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetBean = new System.Windows.Forms.Button();
            this.txtBeanID = new System.Windows.Forms.ComboBox();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muiFile,
            this.muiAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(723, 24);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "主菜单";
            // 
            // muiFile
            // 
            this.muiFile.Name = "muiFile";
            this.muiFile.Size = new System.Drawing.Size(59, 20);
            this.muiFile.Text = "文件(&F)";
            // 
            // muiAbout
            // 
            this.muiAbout.Name = "muiAbout";
            this.muiAbout.Size = new System.Drawing.Size(59, 20);
            this.muiAbout.Text = "关于(&A)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetBean);
            this.panel1.Controls.Add(this.txtBeanID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 45);
            this.panel1.TabIndex = 5;
            // 
            // GetBean
            // 
            this.GetBean.Location = new System.Drawing.Point(178, 13);
            this.GetBean.Name = "GetBean";
            this.GetBean.Size = new System.Drawing.Size(75, 23);
            this.GetBean.TabIndex = 1;
            this.GetBean.Text = "创建插件";
            this.GetBean.UseVisualStyleBackColor = true;
            this.GetBean.Click += new System.EventHandler(this.GetBean_Click);
            // 
            // txtBeanID
            // 
            this.txtBeanID.FormattingEnabled = true;
            this.txtBeanID.Location = new System.Drawing.Point(12, 13);
            this.txtBeanID.Name = "txtBeanID";
            this.txtBeanID.Size = new System.Drawing.Size(160, 20);
            this.txtBeanID.TabIndex = 0;
            // 
            // frmDebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.Name = "frmDebugConsole";
            this.Text = "调试控制台";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem muiFile;
        private System.Windows.Forms.ToolStripMenuItem muiAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtBeanID;
        private System.Windows.Forms.Button GetBean;

    }
}