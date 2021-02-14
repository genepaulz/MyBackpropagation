using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace MyBack
{
    public partial class Form1 : Form
    {
        private int picCount = 0;
        private NeuralNet n;
        private Bitmap[] trainingSet;
        public Form1()
        {
            InitializeComponent();            
        }        
        private void saveWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void loadWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            n.loadWeights(openFileDialog1.FileName);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            openFileDialog3.ShowDialog();            
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            n.saveWeights(saveFileDialog1.FileName);
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            int x = 13, y = 50;
            trainingSet = new Bitmap[openFileDialog2.FileNames.Length];
            foreach (String file in openFileDialog2.FileNames)
            {
                System.Windows.Forms.PictureBox a = new PictureBox();
                a.Image = Image.FromFile(file);
                a.Height = 50;
                a.Width = 50;
                a.SizeMode = PictureBoxSizeMode.StretchImage;                
                a.Location = new System.Drawing.Point(x, y * picCount);
                a.Visible = true;
                panel1.Controls.Add(a);


                Bitmap image = new Bitmap(file);
                Rectangle destRect = new Rectangle(0, 0, 64, 64);
                Bitmap destImage = new Bitmap(64, 64);

                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                trainingSet[picCount] = destImage;
                picCount++;                
            }
        }
        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap image = new Bitmap(openFileDialog3.FileName);
            Rectangle destRect = new Rectangle(0, 0, 64, 64);
            Bitmap destImage = new Bitmap(64, 64);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            Bitmap test = destImage;
            int count = 0;
            for (int i = 0; i < test.Width; i++)
            {
                for (int j = 0; j < test.Height; j++)
                {
                    Color pixel = test.GetPixel(i, j);
                    double grey = (pixel.R + pixel.G + pixel.B) / 3;
                    n.setInputs(count, grey);
                    count++;
                }
            }
            n.run();
            MessageBox.Show("" + n.getOuputData(0) /*+ "\n" + n.getOuputData(1) + "\n" + n.getOuputData(2) + "\n" + n.getOuputData(3) + "\n" + n.getOuputData(4) + "\n"
                 + n.getOuputData(5) + "\n" + n.getOuputData(6) + "\n" + n.getOuputData(7)*/);
        }

        private void ballsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = new NeuralNet(4096, 2048, 1);
        }

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void learnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int y = 0; y < 100; y++)
            for(int x = 0; x < trainingSet.Length; x++) 
            { 
                int count = 0;
                for (int w = 0; w < trainingSet[x].Width; w++)
                {
                    for (int h = 0; h < trainingSet[x].Height; h++)
                    {
                        Color pixel = trainingSet[x].GetPixel(w, h);
                        double grey = (pixel.R + pixel.G + pixel.B) / 3;
                        n.setInputs(count, grey);
                        count++;
                    }
                }
                n.setDesiredOutput(0, 0.0);
               /* n.setDesiredOutput(1, 0.0);
                n.setDesiredOutput(2, 0.0);
                n.setDesiredOutput(3, 0.0);
                n.setDesiredOutput(4, 0.0);
                n.setDesiredOutput(5, 0.0);
                n.setDesiredOutput(6, 0.0);
                n.setDesiredOutput(7, 0.0);*/
            }
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = new NeuralNet(1, 1, 1);
            panel1.Controls.Clear();
            trainingSet = new Bitmap[1];
        }
    }
}
