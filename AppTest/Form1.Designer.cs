namespace AppTest
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollBar1 = new MyControlLibrary.ScrollBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 373);
            this.panel1.TabIndex = 0;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // scrollBar1
            // 
            this.scrollBar1.Active = true;
            this.scrollBar1.ActiveColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scrollBar1.BackColor = System.Drawing.SystemColors.Control;
            this.scrollBar1.HoverColor = System.Drawing.SystemColors.ControlDark;
            this.scrollBar1.Location = new System.Drawing.Point(218, 12);
            this.scrollBar1.MinSlideBarLenght = 50;
            this.scrollBar1.Name = "scrollBar1";
            this.scrollBar1.NeedSleep = false;
            this.scrollBar1.NormalColor = System.Drawing.SystemColors.ControlLight;
            this.scrollBar1.RelaPanel = this.panel1;
            this.scrollBar1.Size = new System.Drawing.Size(14, 373);
            this.scrollBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 397);
            this.Controls.Add(this.scrollBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MyControlLibrary.ScrollBar scrollBar1;
    }
}

