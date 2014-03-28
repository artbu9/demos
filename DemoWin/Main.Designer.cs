namespace DemoWin
{
    partial class Main
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
            this.lblHello = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.llblRight = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(93, 101);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 12);
            this.lblHello.TabIndex = 0;
            // 
            // lblAlert
            // 
            this.lblAlert.Location = new System.Drawing.Point(95, 199);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(75, 23);
            this.lblAlert.TabIndex = 1;
            this.lblAlert.Text = "提示";
            this.lblAlert.UseVisualStyleBackColor = true;
            this.lblAlert.Click += new System.EventHandler(this.lblAlert_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(23, 26);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(29, 12);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Left";
            // 
            // llblRight
            // 
            this.llblRight.AutoSize = true;
            this.llblRight.Location = new System.Drawing.Point(223, 26);
            this.llblRight.Name = "llblRight";
            this.llblRight.Size = new System.Drawing.Size(35, 12);
            this.llblRight.TabIndex = 3;
            this.llblRight.TabStop = true;
            this.llblRight.Text = "Right";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.llblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblHello);
            this.Name = "Main";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button lblAlert;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.LinkLabel llblRight;
    }
}

