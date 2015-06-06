namespace SimpleConsole
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBeanID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(135, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 27);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "ShowDialog";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBeanID
            // 
            this.txtBeanID.Location = new System.Drawing.Point(12, 12);
            this.txtBeanID.Name = "txtBeanID";
            this.txtBeanID.Size = new System.Drawing.Size(100, 21);
            this.txtBeanID.TabIndex = 1;
            this.txtBeanID.Text = "libChild02";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ShowAsNormal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBeanID);
            this.Controls.Add(this.btnShow);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtBeanID;
        private System.Windows.Forms.Button button1;
    }
}

