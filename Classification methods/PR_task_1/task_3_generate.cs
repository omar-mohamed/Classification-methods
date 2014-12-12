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
    public partial class task_3_generate : Form
    {
        public task_3_generate()
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
        double[] posterior;

        Random rand = new Random();
        int width = 860, height = 350;
        Bitmap bmpg;
        Bitmap bmpc;

        private void generate_button_Click(object sender, EventArgs e)
        {
            classes = new CLASS[4];
            for (int i = 0; i < 4; i++)
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


                    int r = (int)normalfn(r1, r2, classes[0].sigma[0], classes[0].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)normalfn(r1, r2, classes[0].sigma[1], classes[0].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)normalfn(r1, r2, classes[0].sigma[2], classes[0].meu[2]);


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

                    int r = (int)normalfn(r1, r2, classes[1].sigma[0], classes[1].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)normalfn(r1, r2, classes[1].sigma[1], classes[1].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)normalfn(r1, r2, classes[1].sigma[2], classes[1].meu[2]);



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


                    int r = (int)normalfn(r1, r2, classes[2].sigma[0], classes[2].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int g = (int)normalfn(r1, r2, classes[2].sigma[1], classes[2].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)normalfn(r1, r2, classes[2].sigma[2], classes[2].meu[2]);



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


                    int r = (int)normalfn(r1, r2, classes[3].sigma[0], classes[3].meu[0]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();


                    int g = (int)normalfn(r1, r2, classes[3].sigma[1], classes[3].meu[1]);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();

                    int b = (int)normalfn(r1, r2, classes[3].sigma[2], classes[3].meu[2]);



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
        public static double normalfn(double r1, double r2, double segma, double meu)
        {
            double z, u, r;
            u = 2 * Math.PI * (r2);
            z = Math.Sqrt(-2 * Math.Log((r1))) * Math.Sin(u);
            r = (z * segma) + meu;
            r = Math.Abs(r);
            return r;

        }
        public double normalfn1(double x, double segma, double meu)
        {
            return (Math.Pow(Math.E, -0.5f * ((x - meu) / segma) * ((x - meu) / segma))) / (Math.Sqrt(2 * Math.PI) * segma);

        }

        private void classify_button_Click(object sender, EventArgs e)
        {
            int num_of_classes = 4;
            double[] X = new double[3];
            double evidence;
            double[] likelihoods = new double[4];
            Random rand1 = new Random();
            bmpc = new Bitmap(width, height);

            Color[] clr = new Color[num_of_classes];
            for (int i = 0; i < num_of_classes; i++)
                clr[i] = Color.FromArgb(rand1.Next(1, 255), rand1.Next(1, 255), rand1.Next(1, 255));
            int when = num_of_classes - 1;
            double[,] lambda = new double[num_of_classes + 1, num_of_classes];
            double[] risk = new double[num_of_classes + 1];
            for (int i = 0; i < num_of_classes + 1; i++)
            {
                for (int j = 0; j < num_of_classes; j++)
                {
                    if (j == i)
                        lambda[i, j] = 0;
                    else
                        lambda[i, j] = 1;
                }
                when--;
            }
            lambda[4, 3] = 2;
            lambda[4, 2] = 2;
            lambda[4, 1] = 2;
            double class1_count = 0;
            double class2_count = 0;
            double class3_count = 0;
            double class4_count = 0;
            double rejected = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    X[0] = bmpg.GetPixel(x, y).R;
                    X[1] = bmpg.GetPixel(x, y).G;
                    X[2] = bmpg.GetPixel(x, y).B;
                    for (int i = 0; i < num_of_classes; i++)
                    {
                        likelihoods[i] = 1;
                        for (int j = 0; j < 3; j++)
                            likelihoods[i] *= normalfn1(X[j], classes[i].sigma[j], classes[i].meu[j]);
                    }

                    posterior = new double[4];

                    evidence = (likelihoods[0] + likelihoods[1] + likelihoods[2] + likelihoods[3]) * 0.25f;

                    for (int i = 0; i < 4; i++)
                        posterior[i] = (likelihoods[i] * 0.25f) / evidence;

                    double sum, min = 1111111111111;
                    int clas = 0;
                    for (int i = 0; i < num_of_classes + 1; i++)
                    {
                        sum = 0.0f;
                        for (int j = 0; j < num_of_classes; j++)
                        {
                            sum += lambda[i, j] * posterior[j];
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
                        bmpg.SetPixel(x, y, Color.Black);
                    else
                        bmpg.SetPixel(x, y, clr[clas]);

                    if (clas == 0 && x>=0 && x<215 )
                        class1_count++;
                    else if (clas == 1&& x>=215 && x<430)
                        class2_count++;
                    else if (clas == 2 && x>=430 && x<645)
                        class3_count++;
                    else if (clas == 3 && x >645 && x<860)
                        class4_count++;
                    else
                        rejected++;
                }

            }
            C1acc.Text = Convert.ToString((Math.Round(Math.Min(class1_count, 75270.0f) / Math.Max(class1_count, 75270.0f), 4) * 100));
            C1acc.Text += "%";
            C2acc.Text = Convert.ToString(Math.Round(Math.Min(class2_count, 75270.0f) / Math.Max(class2_count, 75270.0f), 4) * 100);
            C2acc.Text += "%";
            C3acc.Text = Convert.ToString(Math.Round(Math.Min(class3_count, 75270.0f) / Math.Max(class3_count, 75270.0f), 4) * 100);
            C3acc.Text += "%";
            C4acc.Text = Convert.ToString(Math.Round(Math.Min(class4_count, 75270.0f) / Math.Max(class4_count, 75270.0f), 4) * 100);
            C4acc.Text += "%";
            Rejacc.Text = Convert.ToString(rejected);
            double all = ((Math.Min(class1_count, 75270.0f) / Math.Max(class1_count, 75270.0f)) + (Math.Min(class2_count, 75270.0f) / Math.Max(class2_count, 75270.0f)) + (Math.Min(class3_count, 75270.0f) / Math.Max(class3_count, 75270.0f)) + (Math.Min(class4_count, 75270.0f) / Math.Max(class4_count, 75270.0f))) / 4.0f;
            OVRacc.Text = Convert.ToString(Math.Round(all, 4) * 100);
            OVRacc.Text += "%";
            pictureBox1.Image = bmpg;

        }

        private void windows_generated_Load(object sender, EventArgs e)
        {

        }

    }
}
