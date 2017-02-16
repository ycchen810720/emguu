using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace emgucvtest
{
    //Image to Mat :Mat img= new Mat(); img=image.Mat.Clone();
    //Mat to Image :Image<Gray, Byte> image= img.ToImage<Gray, Byte>();
    
    public partial class Form1 : Form
    {
        Boolean bload;
        Mat img = new Mat();
        Mat imgori = new Mat();
        Mat imgobj = new Mat();
        Mat imgtemplate = new Mat();
        public Form1()
        {
            InitializeComponent();
        }
        private double logKernelElementWeight(int radius, double standarddeviation)
        {
           Console.WriteLine((0.5*((radius * radius - 2 * standarddeviation * standarddeviation) / Math.Pow(standarddeviation, 4)) * Math.Exp(-((radius * radius) / (2 * standarddeviation * standarddeviation)))).ToString());
           return 0;
        }
        private int[] logKernel(double standarddeviation)
        {
            int[] kernel = new int[15] { (int)logKernelElementWeight(7, standarddeviation), (int)logKernelElementWeight(6, standarddeviation), (int)logKernelElementWeight(5, standarddeviation), (int)logKernelElementWeight(4, standarddeviation), (int)logKernelElementWeight(3, standarddeviation), (int)logKernelElementWeight(2, standarddeviation), (int)logKernelElementWeight(1, standarddeviation), (int)logKernelElementWeight(0, standarddeviation), (int)logKernelElementWeight(1, standarddeviation), (int)logKernelElementWeight(2, standarddeviation), (int)logKernelElementWeight(3, standarddeviation), (int)logKernelElementWeight(4, standarddeviation), (int)logKernelElementWeight(5, standarddeviation), (int)logKernelElementWeight(6, standarddeviation), (int)logKernelElementWeight(7, standarddeviation) };
            return kernel;
        }
        private void SetPixelValue(ref Mat m, int row, int col, Byte v)
        {
            Image<Gray, Byte> image = m.ToImage<Gray, Byte>();
            image.Data[row, col, 0] = v;
            m = image.Mat.Clone();
            image.Dispose();
        }
        private void SetPixelValue(ref Mat m, int row, int col, int component, Byte v)
        {
            Image<Bgr, Byte> image = m.ToImage<Bgr, Byte>();
            image.Data[row, col, component] = v;
            m = image.Mat.Clone();
            image.Dispose();
        }
        private Byte GetPixelValue(Mat m, int row, int col)
        {
            Image<Gray,byte> im= m.ToImage<Gray, Byte>();
            byte b=im.Data[row,col,0];
            im.Dispose();
            return b;
        }
        private Byte GetPixelValue(Mat m, int row, int col, int component)
        {
            Image<Bgr, Byte> im = m.ToImage<Bgr, Byte>();
            byte b = im.Data[row, col, component];
            im.Dispose();
            return b;
        }
        private double yenStandardDeviation(List<double> doubleList)
        {
            double average = doubleList.Average();
            double std = 0;
            for (int i = 0; i < doubleList.Count(); i++)
			{
                std += Math.Abs(doubleList[i] - average);
			}
            std /= doubleList.Count();
            return std;
        }
        //private double yenCorrelationCoefficient(Mat img1, Mat img2)
        //{
        //    double correlationcoefficient = 0d;
        //    double regionaverage = 0d;
        //    double templateaverage = 0d;
        //    double numerator = 0d;
        //    double denominatorL = 0d;
        //    double denominatorR = 0d;
        //    for (int row = 0; row < 0   ; row++)
        //    {
        //        for (int col = 0; col < 0; col++)
        //        {
        //            numerator += ((GetPixelValue(imgori, row, col) - regionaverage) * (GetPixelValue(imgtemplate, row, col) - templateaverage));
        //        }
        //    }
        //    return 0;
        //}
        private void OpenImage_Click(object sender, EventArgs e)
        {
            //#region open original image
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image Files (*.png;*.tif;*.jpg;*.bmp)|*.png;*.tif;*.jpg;*.bmp|All files (*.*)|*.*";
            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            //imgori = CvInvoke.Imread(openFileDialog1.FileName, LoadImageType.Unchanged);
            //#endregion
            //#region open object image
            //OpenFileDialog openFileDialog2 = new OpenFileDialog();
            //openFileDialog2.Filter = "Image Files (*.png;*.tif;*.jpg;*.bmp)|*.png;*.tif;*.jpg;*.bmp|All files (*.*)|*.*";
            //if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            //imgobj = CvInvoke.Imread(openFileDialog2.FileName, LoadImageType.Unchanged);
            //#endregion
            int[] ker=new int[15];
            ker = logKernel(2);
            for (int i = 0; i < 15; i++)
            {
             //   Console.WriteLine(ker[i].ToString());
            }
            pictureBox1.Image = imgori.Bitmap;
            bload = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(bload)
            {
                TbOrdRow.Text = e.Y.ToString();
                TbOrdCol.Text = e.X.ToString();
                if (img.NumberOfChannels == 3)
                {
                    TbBlue.Text = img.ToImage<Bgr, Byte>().Data[e.Y, e.X, 0].ToString();
                    TbGreen.Text = img.ToImage<Bgr, Byte>().Data[e.Y, e.X, 1].ToString();
                    TbRed.Text = img.ToImage<Bgr, Byte>().Data[e.Y, e.X, 2].ToString();
                }
                else if (img.NumberOfChannels == 1)
                {
                    TbGrayLevel.Text = img.ToImage<Gray, Byte>().Data[e.Y, e.X, 0].ToString();
                }
            }
        }
    }
}
