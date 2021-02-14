using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
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
        private DateTime start;
        private int dimensions = 16;
        private string basketball = "";
        private string baseball = "";
        private string billiards = "";
        private string football = "";
        private string volleyball = "";
        private string soccerball = "";
        private string rugby = "";
        private void timer1_tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - start;
            label1.Text = duration.ToString();
        }
        private void testSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }
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
                Rectangle destRect = new Rectangle(0, 0, dimensions, dimensions);
                Bitmap destImage = new Bitmap(dimensions, dimensions);

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
            pictureBox1.Image = image;
            Rectangle destRect = new Rectangle(0, 0, dimensions, dimensions);
            Bitmap destImage = new Bitmap(dimensions, dimensions);

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
            /*MessageBox.Show("" + n.getOuputData(0) + "\n" + n.getOuputData(1) + "\n" + n.getOuputData(2) + "\n" + n.getOuputData(3) + "\n" + n.getOuputData(4) + "\n"
                 + n.getOuputData(5) + "\n" + n.getOuputData(6) + "\n" + n.getOuputData(7));*/
            
        }

        private void createNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = new NeuralNet(256, 256, 3);
        }        

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
        private void neuralNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = null;
        }
        private void trainingSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            trainingSet = null;
            picCount = 0;
        }

        private void basketballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(1, 0.0);
                    n.setDesiredOutput(2, 1.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            basketball += duration;
        }

        private void baseballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(1, 1.0);
                    n.setDesiredOutput(2, 0.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            baseball += duration;
        }

        private void billiardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(1, 1.0);
                    n.setDesiredOutput(2, 1.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            billiards += duration;
        }

        private void footballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(0, 1.0);
                    n.setDesiredOutput(1, 0.0);
                    n.setDesiredOutput(2, 0.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            football += duration;
        }

        private void soccerballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(0, 1.0);
                    n.setDesiredOutput(1, 0.0);
                    n.setDesiredOutput(2, 1.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            soccerball += duration;
        }

        private void volleyballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(0, 1.0);
                    n.setDesiredOutput(1, 1.0);
                    n.setDesiredOutput(2, 0.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            volleyball += duration;
        }

        private void rugbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            for (int y = 0; y < 10000; y++)
                for (int x = 0; x < trainingSet.Length; x++)
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
                    n.setDesiredOutput(0, 1.0);
                    n.setDesiredOutput(1, 1.0);
                    n.setDesiredOutput(2, 1.0);
                    n.learn();
                }
            TimeSpan duration = DateTime.Now - start;
            MessageBox.Show("Done!\n" + duration);
            rugby += duration;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            n.run();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            label1.Text = Math.Round(n.getOuputData(0), 4).ToString();
            label2.Text = Math.Round(n.getOuputData(1), 4).ToString();
            label3.Text = Math.Round(n.getOuputData(2), 4).ToString();
            

            if (
                n.getOuputData(0) < 0.5
                &&
                n.getOuputData(1) < 0.5
                &&
                n.getOuputData(2) > 0.5                
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a basketball");
            else if (
                n.getOuputData(0) < 0.5
                &&
                n.getOuputData(1) > 0.5
                &&
                n.getOuputData(2) < 0.5
                                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a baseball");
            else if (
                n.getOuputData(0) < 0.5
                &&
                n.getOuputData(1) > 0.5
                &&
                n.getOuputData(2) > 0.5
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a billiard ball");
            else if (
                n.getOuputData(0) > 0.5
                &&
                n.getOuputData(1) < 0.5
                &&
                n.getOuputData(2) < 0.5
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a football");
            else if (
                n.getOuputData(0) > 0.5
                &&
                n.getOuputData(1) < 0.5
                &&
                n.getOuputData(2) > 0.5
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a volleyball");
            else if (
                n.getOuputData(0) > 0.5
                &&
                n.getOuputData(1) > 0.5
                &&
                n.getOuputData(2) < 0.5
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a soccerball");
            else if (
                n.getOuputData(0) > 0.5
                &&
                n.getOuputData(1) > 0.5
                &&
                n.getOuputData(2) > 0.5
                )
                MessageBox.Show("The NeuralNetwork thinks this photo is of a rugby ball");
            else
            {
                MessageBox.Show("The NeuralNetwork thinks this photo is not of any ball");
            }
        }

        private void testResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basketball Training time: " + basketball + "\n"
                + "Baseball Training time: " + baseball + "\n"
                + "Billiards Training time: " + billiards + "\n"
                + "Football Training time: " + football + "\n"
                + "Volleyball Training time: " + volleyball + "\n"
                + "Soccerball Training time: " + soccerball + "\n"
                + "Rugby Training time: " + rugby + "\n"
                /*+ "Total Training time: " + basketball+baseball+billiards+football+volleyball+soccerball+rugby + "\n"*/
                );
        }

    }
}
