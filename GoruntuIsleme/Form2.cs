using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form2 : Form
    {
        Image img;
        int angle;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(Form1.file);   
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            int newWidth = 0;
            int newHeight = 0;

            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            if(angle>0)
            {
                newWidth = (int)(bmp2.Width * Math.Cos(2 * Math.PI * angle / 360) + bmp2.Height * Math.Sin(2 * Math.PI * angle / 360));
                newHeight = (int)(bmp2.Height * Math.Cos(2 * Math.PI * angle / 360) + bmp2.Width * Math.Sin(2 * Math.PI * angle / 360));
            }
            else
            {
                newWidth = (int)(bmp2.Width * Math.Cos(-2 * Math.PI * angle / 360) + bmp2.Height * Math.Sin(-2 * Math.PI * angle / 360));
                newHeight = (int)(bmp2.Height * Math.Cos(-2 * Math.PI * angle / 360) + bmp2.Width * Math.Sin(-2 * Math.PI * angle / 360));
            }

            

            Bitmap bmp = new Bitmap(newWidth, newHeight);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform(newWidth / 2, newHeight / 2);
            gfx.RotateTransform(angle);
            gfx.TranslateTransform(-img.Width / 2, -img.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            gfx.DrawImage(img, 0, 0);
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.DrawImage(bmp, -bmp.Width / 2, -bmp.Height / 2);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            Invalidate();
            this.DoubleBuffered = true;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            angle = trackBar1.Value;
            Invalidate();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            angle = trackBar2.Value;
            Invalidate();
        }
    }
}
