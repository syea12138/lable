namespace lable
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
            this.pcB_img = new System.Windows.Forms.PictureBox();
            this.but_opencv_img = new DevComponents.DotNetBar.ButtonX();
            this.but_open_file = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pcB_img
            // 
            this.pcB_img.Location = new System.Drawing.Point(133, 49);
            this.pcB_img.Name = "pcB_img";
            this.pcB_img.Size = new System.Drawing.Size(439, 327);
            this.pcB_img.TabIndex = 0;
            this.pcB_img.TabStop = false;
            // 
            // but_opencv_img
            // 
            this.but_opencv_img.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_opencv_img.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_opencv_img.Location = new System.Drawing.Point(12, 65);
            this.but_opencv_img.Name = "but_opencv_img";
            this.but_opencv_img.Size = new System.Drawing.Size(91, 31);
            this.but_opencv_img.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_opencv_img.TabIndex = 1;
            this.but_opencv_img.Text = "打开图片";
            this.but_opencv_img.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // but_open_file
            // 
            this.but_open_file.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_open_file.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_open_file.Location = new System.Drawing.Point(12, 120);
            this.but_open_file.Name = "but_open_file";
            this.but_open_file.Size = new System.Drawing.Size(91, 31);
            this.but_open_file.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_open_file.TabIndex = 2;
            this.but_open_file.Text = "打开文件夹";
            this.but_open_file.Click += new System.EventHandler(this.but_open_file_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(598, 49);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(323, 150);
            this.textBoxX1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.but_open_file);
            this.Controls.Add(this.but_opencv_img);
            this.Controls.Add(this.pcB_img);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcB_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcB_img;
        private DevComponents.DotNetBar.ButtonX but_opencv_img;
        private DevComponents.DotNetBar.ButtonX but_open_file;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}

