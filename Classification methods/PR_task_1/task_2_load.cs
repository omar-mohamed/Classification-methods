using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Configuration;
using System.Drawing.Imaging;

namespace PR_task_1
{
    public partial class task_2_load : Form
    {
        Bitmap loadedBitmap;
        int num_of_classes = 4;
        int c1rsigmax;
        int c1rmeux;
        int c2rsigmax;
        int c2rmeux;
        int c3rsigmax;
        int c3rmeux;
        int c4rsigmax;
        int c4rmeux;
        int count = 0;
        Point[] points= new Point[4];
        Bitmap bmplc;
        public task_2_load()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                // ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
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
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int currX = e.X;
            int currY = e.Y;
            points[count].X = currX;
            points[count].Y = currY;
            count++;
            Color muc1 = loadedBitmap.GetPixel(points[0].X, points[0].Y);
            Color muc2 = loadedBitmap.GetPixel(points[1].X, points[1].Y);
            Color muc3 = loadedBitmap.GetPixel(points[2].X, points[2].Y);
            Color muc4 = loadedBitmap.GetPixel(points[3].X, points[3].Y);
            
            c1rmeux = muc1.B;
            c2rmeux = muc2.B;
            c3rmeux = muc3.B;
            c4rmeux = muc4.B;
            c1rmeux = Math.Abs(c1rmeux);
            c2rmeux = Math.Abs(c2rmeux);
            c3rmeux = Math.Abs(c3rmeux);
            c4rmeux = Math.Abs(c4rmeux);
            if (c1rmeux > 255)
                c1rmeux = 255;
            if (c2rmeux > 255)
                c2rmeux = 255;
            if (c3rmeux > 255)
                c3rmeux = 255;
            if (c4rmeux > 255)
                c4rmeux = 255;
            c1mu.Text = c1rmeux.ToString();
            c2mu.Text = c2rmeux.ToString();
            c3mu.Text = c3rmeux.ToString();
            c4mu.Text = c4rmeux.ToString();

        }

        private void generate_button_Click(object sender, EventArgs e)
        {

            c1rsigmax = Convert.ToInt32(c1rsigma.Text);
            c2rsigmax = Convert.ToInt32(c2rsigma.Text);
            c3rsigmax = Convert.ToInt32(c3rsigma.Text);
            c4rsigmax = Convert.ToInt32(c4rsigma.Text);

            double X;
            double XlikelihoodC1;
            double XlikelihoodC2;
            double XlikelihoodC3;
            double XlikelihoodC4;
            double posteriorc1;
            double posteriorc2;
            double posteriorc3;
            double posteriorc4;
            Random rand1 = new Random();
            bmplc = new Bitmap(loadedBitmap.Width , loadedBitmap.Height);

            Color[] clr = new Color[num_of_classes];
            for (int i = 0; i < num_of_classes; i++)
                clr[i] = Color.FromArgb(rand1.Next(1, 255), rand1.Next(1, 255), rand1.Next(1,255));

            for (int y = 0; y < loadedBitmap.Height; y++)
            {
                for (int x = 0; x < loadedBitmap.Width ; x++)
                {
                    X = loadedBitmap.GetPixel(x, y).B;
                    XlikelihoodC1 = (1 / (c1rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c1rmeux) / c1rsigmax, 2))));
                    XlikelihoodC2 = (1 / (c2rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c2rmeux) / c2rsigmax, 2))));
                    XlikelihoodC3 = (1 / (c3rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c3rmeux) / c3rsigmax, 2))));
                    XlikelihoodC4 = (1 / (c4rsigmax * Math.Sqrt(2 * Math.PI))) * Math.Exp((-1 * 0.5 * (Math.Pow((X - c4rmeux) / c4rsigmax, 2))));

                    posteriorc1 = XlikelihoodC1;
                    posteriorc2 = XlikelihoodC2;
                    posteriorc3 = XlikelihoodC3;
                    posteriorc4 = XlikelihoodC4;

                    if (posteriorc1 >= posteriorc2 && posteriorc1 > posteriorc3 && posteriorc1 > posteriorc4)
                        bmplc.SetPixel(x, y, clr[0]);
                    else if (posteriorc2 > posteriorc1 && posteriorc2 >= posteriorc3 && posteriorc2 >= posteriorc4)
                        bmplc.SetPixel(x, y, clr[1]);
                    else if (posteriorc3 >= posteriorc1 && posteriorc3 > posteriorc2 && posteriorc3 >= posteriorc4)
                        bmplc.SetPixel(x, y, clr[2]);
                    else if (posteriorc4 >= posteriorc1 && posteriorc4 > posteriorc2 && posteriorc4 > posteriorc3)
                        bmplc.SetPixel(x, y, clr[3]);
                }
            }
            pictureBox1.Image = bmplc;
            bmplc.Save("d:\\Loadedclassifiedimage.png");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}
