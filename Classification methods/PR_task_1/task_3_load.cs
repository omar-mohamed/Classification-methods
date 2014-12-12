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
    public partial class task_3_load : Form
    {

        public struct CLASS
        {
            public double[] sigma;
            public double[] meu;
        };

        public struct CLASS1
        {
            public double r, g, b;
        };
        int classIndex = 0;
        int num_clicks_sofar = 0;

        Bitmap loadedBitmap;
        double num_of_classes = 4;
        double num_of_clicks = 0;
        CLASS[] classes;
        CLASS1[] likelihoods;
        double[,] lambda;
        double[] risk;
        Point[] points;
        double[] posteriors;
        Bitmap bmplc;
        public task_3_load()
        {
            InitializeComponent();
        }

        private void task_3_load_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("something went wrong !!");
                Application.Restart();
            }

            loadedBitmap = (Bitmap)Bitmap.FromFile(textBox1.Text);
            pictureBox1.Image = loadedBitmap;
        }


        public double normalfn(double x, double segma, double meu)
        {
            return (Math.Pow(Math.E, -0.5f * ((x - meu) / segma) * ((x - meu) / segma))) / (Math.Sqrt(2 * Math.PI) * segma);

        }
        private void classify_button_Click(object sender, EventArgs e)
        {

            double Xr, Xg, Xb;

            Random rand1 = new Random();
            bmplc = new Bitmap(loadedBitmap.Width, loadedBitmap.Height);

            Color[] clr = new Color[(int)num_of_classes];
            for (int i = 0; i < num_of_classes; i++)
                clr[i] = Color.FromArgb(rand1.Next(1, 255), rand1.Next(1, 255), rand1.Next(1, 255));
            for (int i = 0; i < num_of_classes + 1; i++)
            {
                for (int j = 0; j < num_of_classes; j++)
                {
                    if (j == i)
                        lambda[i, j] = 0;
                    else
                        lambda[i, j] = 1;
                }
            }
            for (int y = 0; y < loadedBitmap.Height; y++)
            {
                for (int x = 0; x < loadedBitmap.Width; x++)
                {
                    Xr = loadedBitmap.GetPixel(x, y).R;
                    Xg = loadedBitmap.GetPixel(x, y).G;
                    Xb = loadedBitmap.GetPixel(x, y).B;
                    for (int i = 0; i < num_of_classes; i++)
                    {
                        likelihoods[i].r = normalfn(Xr, classes[i].sigma[0], classes[i].meu[0]);//(1.0 / (classes[i].sigma[0] * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((classes[i].meu[0] - Xr) / classes[i].sigma[0], 2))));
                        likelihoods[i].g = normalfn(Xg, classes[i].sigma[1], classes[i].meu[1]);//(1.0 / (classes[i].sigma[1] * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((classes[i].meu[1] - Xg) / classes[i].sigma[1], 2))));
                        likelihoods[i].b = normalfn(Xb, classes[i].sigma[2], classes[i].meu[2]);//(1.0 / (classes[i].sigma[2] * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((classes[i].meu[2] - Xb) / classes[i].sigma[2], 2))));
                    }

                    //double max = 0.0f;
                    int clas = 0;
                    for (int i = 0; i < num_of_classes; i++)
                    {
                        posteriors[i] = likelihoods[i].r * likelihoods[i].g * likelihoods[i].b;
                        //if (max < priors[i])
                        //{
                        //    clas = i;
                        //    max = priors[i];
                        //}
                    }
                    double sum, min = 1111111111111;
                    for (int i = 0; i < num_of_classes + 1; i++)
                    {
                        sum = 0.0f;
                        for (int j = 0; j < num_of_classes; j++)
                        {
                            sum += lambda[i, j] * posteriors[j];
                        }
                        risk[i] = sum;
                    }
                    for (int i = 0; i < num_of_classes + 1; i++)
                    {
                        if (min > risk[i])
                        {
                            clas = i;
                            min = risk[i];
                        }
                    }
                    if (clas == num_of_classes)
                        bmplc.SetPixel(x, y, Color.Black);
                    else
                        bmplc.SetPixel(x, y, clr[clas]);

                }
            }
            pictureBox1.Image = bmplc;
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int currX = e.X;
            int currY = e.Y;
            points[num_clicks_sofar].X = currX;
            points[num_clicks_sofar].Y = currY;
            classes[classIndex].meu[0] += loadedBitmap.GetPixel(currX, currY).R;
            classes[classIndex].meu[1] += loadedBitmap.GetPixel(currX, currY).G;
            classes[classIndex].meu[2] += loadedBitmap.GetPixel(currX, currY).B;
            num_clicks_sofar++;
            if (num_clicks_sofar == num_of_clicks)
            {
                classes[classIndex].meu[0] /= num_clicks_sofar;
                classes[classIndex].meu[1] /= num_clicks_sofar;
                classes[classIndex].meu[2] /= num_clicks_sofar;
                classes[classIndex].sigma[0] = 10;
                classes[classIndex].sigma[1] = 10;
                classes[classIndex].sigma[2] = 10;
                for (int i = 0; i < num_clicks_sofar; i++)
                {
                    classes[classIndex].sigma[0] += (classes[classIndex].meu[0] - loadedBitmap.GetPixel(points[i].X, points[i].Y).R) * (classes[classIndex].meu[0] - loadedBitmap.GetPixel(points[i].X, points[i].Y).R);
                    classes[classIndex].sigma[1] += (classes[classIndex].meu[1] - loadedBitmap.GetPixel(points[i].X, points[i].Y).G) * (classes[classIndex].meu[1] - loadedBitmap.GetPixel(points[i].X, points[i].Y).G);
                    classes[classIndex].sigma[2] += (classes[classIndex].meu[2] - loadedBitmap.GetPixel(points[i].X, points[i].Y).B) * (classes[classIndex].meu[2] - loadedBitmap.GetPixel(points[i].X, points[i].Y).B);
                }
                classes[classIndex].sigma[0] /= num_of_clicks;
                classes[classIndex].sigma[1] /= num_of_clicks;
                classes[classIndex].sigma[2] /= num_of_clicks;
                classes[classIndex].sigma[0] = Math.Sqrt(classes[classIndex].sigma[0]);
                classes[classIndex].sigma[1] = Math.Sqrt(classes[classIndex].sigma[1]);
                classes[classIndex].sigma[2] = Math.Sqrt(classes[classIndex].sigma[2]);
                num_clicks_sofar = 0;
                classIndex++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classIndex = 0;
            num_clicks_sofar = 0;

            num_of_classes = Convert.ToDouble(num_classes.Text);
            num_of_clicks = Convert.ToDouble(num_clicks.Text);
            points = new Point[(int)num_of_clicks];
            posteriors = new double[(int)num_of_classes];
            classes = new CLASS[(int)num_of_classes];
            likelihoods = new CLASS1[(int)num_of_classes];
            lambda = new double[(int)num_of_classes + 1, (int)num_of_classes];
            risk = new double[(int)num_of_classes + 1];
            for (int i = 0; i < num_of_classes; i++)
            {//{
                //    CLASS temp=new CLASS();
                //    temp.
                classes[i].sigma = new double[3];
                classes[i].meu = new double[3];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
