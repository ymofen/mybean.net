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
            this.txtBeanID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.actsMain = new Crad.Windows.Forms.Actions.ActionList();
            this.actGetBean = new Crad.Windows.Forms.Actions.Action();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muiFile,
            this.muiAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(723, 25);
            this.mnuMain.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtBeanID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 45);
            this.panel1.TabIndex = 5;
            // 
            // txtBeanID
            // 
            this.txtBeanID.FormattingEnabled = true;
            this.txtBeanID.Location = new System.Drawing.Point(12, 13);
            this.txtBeanID.Name = "txtBeanID";
            this.txtBeanID.Size = new System.Drawing.Size(160, 20);
            this.txtBeanID.TabIndex = 0;
            // 
            // button1
            // 
            this.actsMain.SetAction(this.button1, this.actGetBean);
            this.button1.Location = new System.Drawing.Point(178, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "创建插件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // actsMain
            // 
            this.actsMain.Actions.Add(this.actGetBean);
            this.actsMain.ContainerControl = this;
            // 
            // actGetBean
            // 
            this.actGetBean.Text = "创建插件";
            this.actGetBean.Execute += new System.EventHandler(this.actGetBean_Execute);
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
            ((System.ComponentModel.ISupportInitialize)(this.actsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem muiFile;
        private System.Windows.Forms.ToolStripMenuItem muiAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtBeanID;
        private System.Windows.Forms.Button button1;
        private Crad.Windows.Forms.Actions.ActionList actsMain;
        private Crad.Windows.Forms.Actions.Action actGetBean;

    }
}