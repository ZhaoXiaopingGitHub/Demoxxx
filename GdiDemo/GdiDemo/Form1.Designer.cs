namespace GdiDemo
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
            this.myGaugePlate1 = new WindowsFormsControlPro.MyGaugePlate();
            this.SuspendLayout();
            // 
            // myGaugePlate1
            // 
            this.myGaugePlate1.Circlecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.myGaugePlate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGaugePlate1.Location = new System.Drawing.Point(0, 0);
            this.myGaugePlate1.MyProperty = 0;
            this.myGaugePlate1.Name = "myGaugePlate1";
            this.myGaugePlate1.Pointcolor = System.Drawing.Color.SeaGreen;
            this.myGaugePlate1.Size = new System.Drawing.Size(701, 450);
            this.myGaugePlate1.TabIndex = 0;
            this.myGaugePlate1.Textscale = 0.8F;
            this.myGaugePlate1.Textshowscale = 0.85F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.myGaugePlate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlPro.MyGaugePlate myGaugePlate1;
    }
}

