using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using System.Diagnostics;
using System.Drawing.Imaging;


namespace lable
{
    public partial class Form1 : Form
    {
        //文件名
        private string curFileName;
        //图像对象
        private Bitmap curBitmap;
       // private HiperfTimer myTimer;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndlg = new OpenFileDialog();
            opndlg.Filter = "所有图像文件|*.bmp;*.pcx;*.png;*.jpg;*.gif";
            opndlg.Title = "打开图像文件";
            if (opndlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opndlg.FileName;
                try
                {
                    textBoxX1.Text = curFileName;
                    curBitmap = (Bitmap)Image.FromFile(curFileName);
                    pcB_img.Image = curBitmap;
                    //OpenCvSharp.Extensions.BitmapConverter.ToBitmap(curBitmap);
                    Mat image_mat =OpenCvSharp.Extensions.BitmapConverter.ToMat(curBitmap); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Invalidate();
        }

        private void but_open_file_Click(object sender, EventArgs e)
        {

        }

    }
}
