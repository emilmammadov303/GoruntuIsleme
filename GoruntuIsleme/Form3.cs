using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form3 : Form
    {
        Image target_image;
        int width;
        int height;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            target_image = Image.FromFile(Form1.file);
            width = target_image.Width;
            height = target_image.Height;
            pictureBox1.Image = target_image;
            pictureBox1.Width = width*2;
            pictureBox1.Height = height*2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        { 

            if (trackBar1.Value >= 50)
            {
                width = (width + (target_image.Width * trackBar1.Value)) / 50;
            }
            else
            {
                width = (target_image.Width * trackBar1.Value) / 50;
            }

            pictureBox1.Image = ResizeNow(width, height);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            
            if (trackBar2.Value >= 50)
            {
                height = (height + (target_image.Height * trackBar2.Value)) / 50;
            }
            else
            {
                height = (target_image.Height * trackBar2.Value) / 50;
            }


            pictureBox1.Image = ResizeNow(width, height);
        }

        private Bitmap ResizeNow(int target_width, int target_height)
        {
            Rectangle dest_rect = new Rectangle(0, 0, target_width, target_height);
            Bitmap destImage = new Bitmap(target_width, target_height);
            destImage.SetResolution(target_image.HorizontalResolution, target_image.VerticalResolution);
            using (var g = Graphics.FromImage(destImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapmode = new ImageAttributes())
                {
                    wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(target_image, dest_rect, 0, 0, target_image.Width, target_image.Height, GraphicsUnit.Pixel, wrapmode);
                }
            }
            return destImage;
        }
    }
}
