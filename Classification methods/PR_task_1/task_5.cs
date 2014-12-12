using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PR_task_1
{
    public partial class task_5 : Form
    {
        public task_5()
        {
            InitializeComponent();
        }
        public struct CLASS
        {
            public double[] sigma;
            public double[] meu;
        };

        public struct CLASS1
        {
            public double r, g, b;
        };

        CLASS[] classes;
        double num_of_classes = 4;
        int num_of_clicks = 0;
        int classIndex = 0;
        int num_clicks_sofar = 0;

        CLASS1[,] points;
        Random rand;
        int width = 860, height = 350;
        Bitmap bmpg;
        private void generate_button_Click(object sender, EventArgs e)
        {
            classes = new CLASS[4];
            rand = new Random();
            for (int i = 0; i < num_of_classes; i++)
            {
                classes[i].meu = new double[3];
                classes[i].sigma = new double[3];
            }
            classes[0].meu[0] = Convert.ToDouble(c1rmeu.Text);
            classes[0].meu[1] = Convert.ToDouble(c1gmeu.Text);
            classes[0].meu[2] = Convert.ToDouble(c1bmeu.Text);
            classes[0].sigma[0] = Convert.ToDouble(c1rsigma.Text);
            classes[0].sigma[1] = Convert.ToDouble(c1gsigma.Text);
            classes[0].sigma[2] = Convert.ToDouble(c1bsigma.Text);
            classes[1].meu[0] = Convert.ToDouble(c2rmeu.Text);
            classes[1].meu[1] = Convert.ToDouble(c2gmeu.Text);
            classes[1].meu[2] = Convert.ToDouble(c2bmeu.Text);
            classes[1].sigma[0] = Convert.ToDouble(c2rsigma.Text);
            classes[1].sigma[1] = Convert.ToDouble(c2gsigma.Text);
            classes[1].sigma[2] = Convert.ToDouble(c2bsigma.Text);
            classes[2].meu[0] = Convert.ToDouble(c3rmeu.Text);
            classes[2].meu[1] = Convert.ToDouble(c3gmeu.Text);
            classes[2].meu[2] = Convert.ToDouble(c3bmeu.Text);
            classes[2].sigma[0] = Convert.ToDouble(c3rsigma.Text);
            classes[2].sigma[1] = Convert.ToDouble(c3gsigma.Text);
            classes[2].sigma[2] = Convert.ToDouble(c3bsigma.Text);
            classes[3].meu[0] = Convert.ToDouble(c4rmeu.Text);
            classes[3].meu[1] = Convert.ToDouble(c4gmeu.Text);
            classes[3].meu[2] = Convert.ToDouble(c4bmeu.Text);
            classes[3].sigma[0] = Convert.ToDouble(c4rsigma.Text);
            classes[3].sigma[1] = Convert.ToDouble(c4gsigma.Text);
            classes[3].sigma[2] = Convert.ToDouble(c4bsigma.Text);

            bmpg = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                double r1, r2;
                for (int x = 0; x < 215; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();


                    int r = (int)task_3_generate.normalfn(r1, r2, classes[0].sigma[0], classes[0].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)task_3_generate.normalfn(r1, r2, classes[0].sigma[1], classes[0].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)task_3_generate.normalfn(r1, r2, classes[0].sigma[2], classes[0].meu[2]);


                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(r, g, b));


                }
                for (int x = 215; x < 430; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int r = (int)task_3_generate.normalfn(r1, r2, classes[1].sigma[0], classes[1].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)task_3_generate.normalfn(r1, r2, classes[1].sigma[1], classes[1].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)task_3_generate.normalfn(r1, r2, classes[1].sigma[2], classes[1].meu[2]);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

                for (int x = 430; x < 645; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();


                    int r = (int)task_3_generate.normalfn(r1, r2, classes[2].sigma[0], classes[2].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)task_3_generate.normalfn(r1, r2, classes[2].sigma[1], classes[2].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)task_3_generate.normalfn(r1, r2, classes[2].sigma[2], classes[2].meu[2]);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                for (int x = 645; x < 860; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();


                    int r = (int)task_3_generate.normalfn(r1, r2, classes[3].sigma[0], classes[3].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();


                    int g = (int)task_3_generate.normalfn(r1, r2, classes[3].sigma[1], classes[3].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)task_3_generate.normalfn(r1, r2, classes[3].sigma[2], classes[3].meu[2]);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = bmpg;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clicks_button_Click(object sender, EventArgs e)
        {
            classIndex = 0;
            num_clicks_sofar = 0;

            num_of_clicks = Convert.ToInt32(textBox1.Text);
            points = new CLASS1[(int)num_of_classes, num_of_clicks];

        }

        private void task_5_Load(object sender, EventArgs e)
        {

        }

        private void classify_button_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble( textBox2.Text);
            Bitmap bmplc = new Bitmap(bmpg.Width, bmpg.Height);
            
            Color[] clr = new Color[(int)num_of_classes];

            double n = num_of_classes * num_of_clicks;
            clr[0] = Color.Black;
            clr[1] = Color.Blue;
            clr[2] = Color.Red;
            clr[3] = Color.Green;

            /*for (int i = 0; i < num_of_classes; i++)
                clr[i] = Color.FromArgb(rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255));*/
            for (int y = 0; y < bmpg.Height; y++)
            {
                for (int x = 0; x < bmpg.Width; x++)
                {
                    double Xr = bmpg.GetPixel(x, y).R;
                    double Xg = bmpg.GetPixel(x, y).G;
                    double Xb = bmpg.GetPixel(x, y).B;
                    double[] Pi = new double[(int)num_of_classes];
                    for(int k=0;k<num_of_classes; k++)
                    {
                        double Ki=0.0;
                        for(int i=0;i<num_of_clicks; i++)
                        {
                            if (points[k, i].r - Xr < height / 2 && 
                                points[k, i].g - Xg < height / 2 && 
                                points[k, i].b - Xb < height / 2) 
                                Ki++;
                        }
                        Pi[k] = Ki / n;
                        Pi[k] /= Math.Pow(height, 3.0);
                    }
                    double max = double.MinValue; 
                    int index=-1;
                    for (int k = 0; k < num_of_classes; k++)
                    {
                        if (max < Pi[k])
                        {
                            index = k;
                            max = Pi[k];
                        }
                    }
                    if (index == -1)
                        bmplc.SetPixel(x, y, Color.Black);
                    else
                        bmplc.SetPixel(x, y, clr[index]);
                    bmplc.SetPixel(x, y, clr[index]);
                }
            }
            pictureBox1.Image = bmplc;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            points[classIndex, num_clicks_sofar].r = bmpg.GetPixel(me.X, me.Y).R;
            points[classIndex, num_clicks_sofar].g = bmpg.GetPixel(me.X, me.Y).G;
            points[classIndex, num_clicks_sofar].b = bmpg.GetPixel(me.X, me.Y).B;
            
            num_clicks_sofar++;
            if (num_clicks_sofar == num_of_clicks)
            {
                num_clicks_sofar = 0;
                classIndex++;
            }
        }

        private void c1bsigma_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
