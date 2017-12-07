using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoruntuIsleme
{
    public partial class Form1 : Form
    {
        public static String file = "";
        String file1;
        public Form1()
        {
            InitializeComponent();
        }
       
       
        private Bitmap griYap(Bitmap bmpgri)
        {
            for(int i=0; i<bmpgri.Height-1; i++){
                for (int j=0; j<bmpgri.Width-1; j++)
                {
                    int deger = (bmpgri.GetPixel(j,i).R + bmpgri.GetPixel(j,i).G + bmpgri.GetPixel(j,i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger,deger,deger);
                    bmpgri.SetPixel(j, i, renk);
                }
            }
            return bmpgri;
        }
        private void acMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "All Files|*.*";
            if (ac.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = ac.FileName;
            file1 = ac.FileName;
        }

        private void kaydetMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "jpeg (*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            if (DialogResult.OK == kaydet.ShowDialog())
            {
                this.pictureBox2.Image.Save(kaydet.FileName);
            }
        }

        private void griYapMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(image);
            pictureBox2.Image = gri;

        }

        private void histogramMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private Bitmap NegatifYap(Bitmap bmpngtf)
        {
            
            int width = bmpngtf.Width;
            int height = bmpngtf.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color p = bmpngtf.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;
                    bmpngtf.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmpngtf;

        }

        private void NegatifMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap negatif = NegatifYap(image);
            pictureBox2.Image = negatif;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void DondurMenuItem_Click(object sender, EventArgs e)
        {
            file = file1;
            Form2 dondur = new Form2();
            dondur.Show();
        }

        private void olceklendirMenuItem_Click(object sender, EventArgs e)
        {
            file = file1;
            Form3 olcek = new Form3();
            olcek.Show();
        }

        

        private void aynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap simg = new Bitmap(pictureBox1.Image);

            int width = simg.Width;
            int height = simg.Height;

            Bitmap mimg = new Bitmap(width * 2, height);

            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                {
                    Color p = simg.GetPixel(lx, y);

                    mimg.SetPixel(lx, y, p);
                    mimg.SetPixel(rx, y, p);
                }
            }

            pictureBox2.Width *= 2;
            pictureBox2.Image = mimg;
        }

        private void renkKanallariMenuItem_Click(object sender, EventArgs e)
        {
            file = file1;
            Form4 renk = new Form4();
            renk.Show();
        }
    }

    
}



