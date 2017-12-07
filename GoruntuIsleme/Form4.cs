using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form4 : Form
    {
        int width;
        int height;
        Bitmap bmp;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Form1.file);
            pictureBox1.Image = Image.FromFile(Form1.file);
            int width = bmp.Width;
            int height = bmp.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap rbmp = new Bitmap(Form1.file);
            for(int y = 0; y<rbmp.Width;y++)
            {
                for(int x = 0;x<rbmp.Height;x++)
                {
                    Color p = bmp.GetPixel(x,y);
                    rbmp.SetPixel(x, y, Color.FromArgb(p.R, 0, 0));
                }
            }

            pictureBox2.Image = rbmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap gbmp = new Bitmap(bmp);
            for (int y = 0; y < gbmp.Height; y++)
            {
                for (int x = 0; x < gbmp.Width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    gbmp.SetPixel(x, y, Color.FromArgb(0, p.G, 0));
                }
            }

            pictureBox2.Image = gbmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bbmp = new Bitmap(bmp);
            for (int y = 0; y < bbmp.Height; y++)
            {
                for (int x = 0; x < bbmp.Width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    bbmp.SetPixel(x, y, Color.FromArgb(0, 0, p.B));
                }
            }

            pictureBox2.Image = bbmp;
        }
    }
}
