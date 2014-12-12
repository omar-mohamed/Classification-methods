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
    public partial class task_2_generate : Form
    {
        int c1rsigmax;
        int c1rmeux;
        int c2rsigmax;
        int c2rmeux;
        int c3rsigmax;
        int c3rmeux;
        int c4rsigmax;
        int c4rmeux;

        int width = 860, height = 350;
        Bitmap bmpg;
        Bitmap bmpc;
        Random rand = new Random();

        public task_2_generate()
        {
            InitializeComponent();
        }

        private void task_2_generate_Load(object sender, EventArgs e)
        {

        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            c1rsigmax = Convert.ToInt32(c1rsigma.Text);
            c1rmeux = Convert.ToInt32(c1rmeu.Text);

            c2rsigmax = Convert.ToInt32(c2rsigma.Text);
            c2rmeux = Convert.ToInt32(c2rmeu.Text);

            c3rsigmax = Convert.ToInt32(c3rsigma.Text);
            c3rmeux = Convert.ToInt32(c3rmeu.Text);

            c4rsigmax = Convert.ToInt32(c4rsigma.Text);
            c4rmeux = Convert.ToInt32(c4rmeu.Text);

            bmpg = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                double r1, r2;
                for (int x = 0; x < 215; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int r = (int)normalfn(r1, r2, c1rsigmax, c1rmeux);
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int g = (int)normalfn(r1, r2, c1rsigmax, c1rmeux);
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c1rsigmax, c1rmeux);


                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(((r + g + b) / 3), ((r + g + b) / 3), ((r + g + b) / 3)));

                }
                for (int x = 215; x < 430; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int r = (int)normalfn(r1, r2, c2rsigmax, c2rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int g = (int)normalfn(r1, r2, c2rsigmax, c2rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c2rsigmax, c2rmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(((r + g + b) / 3), ((r + g + b) / 3), ((r + g + b) / 3)));
                }

                for (int x = 430; x < 645; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int r = (int)normalfn(r1, r2, c3rsigmax, c3rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int g = (int)normalfn(r1, r2, c3rsigmax, c3rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c3rsigmax, c3rmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(((r + g + b) / 3), ((r + g + b) / 3), ((r + g + b) / 3)));
                }
                for (int x = 645; x < 860; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int r = (int)normalfn(r1, r2, c4rsigmax, c4rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int g = (int)normalfn(r1, r2, c4rsigmax, c4rmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c4rsigmax, c4rmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmpg.SetPixel(x, y, Color.FromArgb(((r + g + b) / 3), ((r + g + b) / 3), ((r + g + b) / 3)));
                }
            }
            pictureBox1.Image = bmpg;
            bmpg.Save("d:\\grayscaleimage.png");

        }
        public double normalfn(double r1, double r2, double segma, double meu)
        {

            double z, u, r;
            u = 2 * Math.PI * (r2);
            z = Math.Sqrt(-2 * Math.Log((r1))) * Math.Sin(u);
            r = (z * segma) + meu;
            r = Math.Abs(r);
            return r;

        }

        private void classify_button_Click(object sender, EventArgs e)
        {

            int num_of_classes = 4;
            float prior1 = 0.25f;
            float prior2 = 0.25f;
            float prior3 = 0.25f;
            float prior4 = 0.25f;

            double X;
            double XlikelihoodC1;
            double XlikelihoodC2;
            double XlikelihoodC3;
            double XlikelihoodC4;
            double evidence;
            double posteriorc1;
            double posteriorc2;
            double posteriorc3;
            double posteriorc4;

            Random rand1 = new Random();
            bmpc = new Bitmap(width, height);

            Color[] clr = new Color[num_of_classes];
            for (int i = 0; i < num_of_classes; i++)
                clr[i] = Color.FromArgb(rand1.Next(1, 255), rand1.Next(1, 255), rand1.Next(1,255));

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                   X = bmpg.GetPixel(x,y).R;
                   XlikelihoodC1 = (1 / (c1rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c1rmeux) / c1rsigmax, 2))));
                   XlikelihoodC2 = (1 / (c2rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c2rmeux) / c2rsigmax, 2))));
                   XlikelihoodC3 = (1 / (c3rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c3rmeux) / c3rsigmax, 2))));
                   XlikelihoodC4 = (1 / (c4rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c4rmeux) / c4rsigmax, 2))));

                   evidence = (XlikelihoodC1 * prior1) + (XlikelihoodC2 * prior2) + (XlikelihoodC3 * prior3) + (XlikelihoodC4 * prior4);

                   posteriorc1 = (XlikelihoodC1 * prior1) / evidence;
                   posteriorc2 = (XlikelihoodC2 * prior2) / evidence;
                   posteriorc3 = (XlikelihoodC3 * prior3) / evidence;
                   posteriorc4 = (XlikelihoodC4 * prior4) / evidence;

                   if (posteriorc1 >= posteriorc2 && posteriorc1 > posteriorc3 && posteriorc1 > posteriorc4)
                       bmpc.SetPixel(x, y, clr[0]);
                   else if (posteriorc2 > posteriorc1 && posteriorc2 >= posteriorc3 && posteriorc2 >= posteriorc4)
                       bmpc.SetPixel(x, y, clr[1]);
                   else if (posteriorc3 >= posteriorc1 && posteriorc3 > posteriorc2 && posteriorc3 >= posteriorc4)
                       bmpc.SetPixel(x, y, clr[2]);
                   else if (posteriorc4 >= posteriorc1 && posteriorc4 > posteriorc2 && posteriorc4 > posteriorc3)
                       bmpc.SetPixel(x, y, clr[3]);
                }
            }
            pictureBox1.Image = bmpc;
            bmpc.Save("d:\\classifiedimage.png");
            
        }
        public void classifier()
        {
 
        }
        
    }
}
