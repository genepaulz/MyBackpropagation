using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backprop;

namespace MyNeuralNetsApplication
{
    public partial class Form1 : Form
    {
        NeuralNet n;
        Bitmap image;
        bool flag;
        int a;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = new NeuralNet(121, 121, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool flag = true;

                try
                {
                    int b = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception x)
                {
                    flag = false;
                    MessageBox.Show(x.Message);
                }
                if (flag)
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    for (int y = 0; y < a; y++)
                    {
                        image = new Bitmap(@"C:\Users\L12X12W01\Desktop\MAchine learning LIB\MyNeuralNetsApplication\Samples\plus.png");
                        int count = 0;
                        for (int w = 0; w < image.Width; w++)
                        {
                            for (int h = 0; h < image.Height; h++)
                            {
                                Color pixel = image.GetPixel(w, h);
                                double grey = (pixel.R + pixel.G + pixel.B) / 3;
                                n.setInputs(count, grey);
                                count++;
                            }
                        }
                        n.setDesiredOutput(0, 0.0);
                        n.setDesiredOutput(1, 0.0);
                        n.learn();
                        image = new Bitmap(@"C:\Users\L12X12W01\Desktop\MAchine learning LIB\MyNeuralNetsApplication\Samples\minus.png");
                        count = 0;
                        for (int w = 0; w < image.Width; w++)
                        {
                            for (int h = 0; h < image.Height; h++)
                            {
                                Color pixel = image.GetPixel(w, h);
                                double grey = (pixel.R + pixel.G + pixel.B) / 3;
                                n.setInputs(count, grey);
                                count++;
                            }
                        }
                        n.setDesiredOutput(0, 0.0);
                        n.setDesiredOutput(1, 1.0);
                        n.learn();
                        image = new Bitmap(@"C:\Users\L12X12W01\Desktop\MAchine learning LIB\MyNeuralNetsApplication\Samples\times.png");
                        count = 0;
                        for (int w = 0; w < image.Width; w++)
                        {
                            for (int h = 0; h < image.Height; h++)
                            {
                                Color pixel = image.GetPixel(w, h);
                                double grey = (pixel.R + pixel.G + pixel.B) / 3;
                                n.setInputs(count, grey);
                                count++;
                            }
                        }
                        n.setDesiredOutput(0, 1.0);
                        n.setDesiredOutput(1, 0.0);
                        n.learn();
                        image = new Bitmap(@"C:\Users\L12X12W01\Desktop\MAchine learning LIB\MyNeuralNetsApplication\Samples\divide.png");
                        count = 0;
                        for (int w = 0; w < image.Width; w++)
                        {
                            for (int h = 0; h < image.Height; h++)
                            {
                                Color pixel = image.GetPixel(w, h);
                                double grey = (pixel.R + pixel.G + pixel.B) / 3;
                                n.setInputs(count, grey);
                                count++;
                            }
                        }
                        n.setDesiredOutput(0, 1.0);
                        n.setDesiredOutput(1, 1.0);
                        n.learn();
                    }
                }
                if (flag)
                {
                    MessageBox.Show("MANA SIYA STUDY!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            if (textBox2.Text != "" & textBox3.Text != "")
            {
               flag = true;                

                try
                {
                    int c = Convert.ToInt32(textBox2.Text);
                    int d = Convert.ToInt32(textBox3.Text);
                }
                catch(Exception x)
                {
                    flag = false;
                    MessageBox.Show(x.Message);
                }

                if (flag) { 
                 a = Convert.ToInt32(textBox2.Text);
                 b = Convert.ToInt32(textBox3.Text);
                }

                image = new Bitmap(openFileDialog1.FileName);
                int count = 0;
                for (int w = 0; w < image.Width; w++)
                {
                    for (int h = 0; h < image.Height; h++)
                    {
                        Color pixel = image.GetPixel(w, h);
                        double grey = (pixel.R + pixel.G + pixel.B) / 3;
                        n.setInputs(count, grey);
                        count++;
                    }
                }
                n.run();

                textBox6.Text = "";
                textBox7.Text = "";

                textBox6.Text += n.getOuputData(0);
                textBox7.Text += n.getOuputData(1);

                if (n.getOuputData(0) < 0.5 && n.getOuputData(1) < 0.5) 
                {   
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox5.Text += "addition";
                    int sum = a + b;
                    textBox4.Text +=sum;
                }

                if (n.getOuputData(0) < 0.5 && n.getOuputData(1) >= 0.5)
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox5.Text += "subtraction";
                    int diff = a - b;
                    textBox4.Text += diff;
                }

                if (n.getOuputData(0) >= 0.5 && n.getOuputData(1) < 0.5)
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox5.Text += "multiplication";
                    int product = a * b;
                    textBox4.Text += product;
                }

                if (n.getOuputData(0) >= 0.5 && n.getOuputData(1) >= 0.5)
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox5.Text += "division";
                    try
                    {
                        int quotient = a / b;
                        textBox4.Text += quotient;
                    }
                    catch (Exception x)
                    {
                        textBox4.Text = x.Message;
                    }
                    
                }

                pictureBox1.Image = image;
                label8.Text = openFileDialog1.SafeFileName;
            }
            else
            {
                MessageBox.Show("Please input a number!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            n.saveWeights(saveFileDialog1.FileName);
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            n.loadWeights(openFileDialog2.FileName);
        }

        

       
    }
}
