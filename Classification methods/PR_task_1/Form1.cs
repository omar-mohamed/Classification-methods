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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();

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
            catch(InvalidOperationException)
            {
                MessageBox.Show("something went wrong !!");
                Application.Restart();
            }

            Bitmap loadedBitmap = (Bitmap)Bitmap.FromFile(textBox1.Text);
            pictureBox1.Image = loadedBitmap;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            int c1rsigmax = Convert.ToInt32(c1rsigma.Text);
            int c1rmeux = Convert.ToInt32(c1rmeu.Text);
            int c1gsigmax = Convert.ToInt32(c1gsigma.Text);
            int c1gmeux = Convert.ToInt32(c1gmeu.Text);
            int c1bsigmax = Convert.ToInt32(c1bsigma.Text);
            int c1bmeux = Convert.ToInt32(c1bmeu.Text);

            int c2rsigmax = Convert.ToInt32(c2rsigma.Text);
            int c2rmeux = Convert.ToInt32(c2rmeu.Text);
            int c2gsigmax = Convert.ToInt32(c2gsigma.Text);
            int c2gmeux = Convert.ToInt32(c2gmeu.Text);
            int c2bsigmax = Convert.ToInt32(c2bsigma.Text);
            int c2bmeux = Convert.ToInt32(c2bmeu.Text);

            int c3rsigmax = Convert.ToInt32(c3rsigma.Text);
            int c3rmeux = Convert.ToInt32(c3rmeu.Text);
            int c3gsigmax = Convert.ToInt32(c3gsigma.Text);
            int c3gmeux = Convert.ToInt32(c3gmeu.Text);
            int c3bsigmax = Convert.ToInt32(c3bsigma.Text);
            int c3bmeux = Convert.ToInt32(c3bmeu.Text);

            int c4rsigmax = Convert.ToInt32(c4rsigma.Text);
            int c4rmeux = Convert.ToInt32(c4rmeu.Text);
            int c4gsigmax = Convert.ToInt32(c4gsigma.Text);
            int c4gmeux = Convert.ToInt32(c4gmeu.Text);
            int c4bsigmax = Convert.ToInt32(c4bsigma.Text);
            int c4bmeux = Convert.ToInt32(c4bmeu.Text);

            int width = 860, height = 350;
            Bitmap bmp = new Bitmap(width, height);
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                double r1, r2;
                for (int x = 0; x < 214; x++)
                {
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int r = (int) normalfn(r1, r2, c1rsigmax, c1rmeux);
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int g = (int) normalfn(r1, r2, c1gsigmax, c1gmeux);
                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c1bsigmax, c1bmeux);


                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
                for (int x = 214; x < 429; x++)
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
                    int g = (int)normalfn(r1, r2, c2gsigmax, c2gmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c2bsigmax, c2bmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

                for (int x = 429; x < 645; x++)
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
                    int g = (int)normalfn(r1, r2, c3gsigmax, c3gmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c3bsigmax, c3bmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                for (int x = 644; x < 860; x++)
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
                    int g = (int)normalfn(r1, r2, c4gsigmax, c4gmeux);

                    r1 = rand.NextDouble();
                    r2 = rand.NextDouble();
                    //r1 = Math.Abs(r1);
                    //r2 = Math.Abs(r2);
                    int b = (int)normalfn(r1, r2, c4bsigmax, c4bmeux);



                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = bmp;
        
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void task_2_generate_Click(object sender, EventArgs e)
        {
            task_2_generate w = new task_2_generate();
            w.Show();
        }

        private void task_2_load_Click(object sender, EventArgs e)
        {
            task_2_load v = new task_2_load();
            v.Show();
        }

        private void Task_3__Click(object sender, EventArgs e)
        {
            task_3_load v = new task_3_load();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task_3_generate v = new task_3_generate();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task_5 v= new task_5();
            v.Show();
        }


    }
}
