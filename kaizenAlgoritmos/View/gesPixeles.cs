using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaizenAlgoritmos.View
{
    public partial class gesPixeles : Form
    {
        private Image miImagen;
        private Bitmap miBitmap;
        private Color miColor;

        private int width;
        private int height;
        
        private int alfa;
        private int red;
        private int green;
        private int blue;

        public gesPixeles()
        {
            InitializeComponent();
            width = 382;
            height = 405;
            miBitmap = new Bitmap(width, height);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random miRand = new Random();
            int w;
            int h;

            for (w=0; w < width; w++)
                for (h=0; h < height; h++)
                {
                    alfa = miRand.Next(0, 255);
                    red = miRand.Next(0, 255);
                    green = miRand.Next(0, 255);
                    blue = miRand.Next(0, 255); 
                    miColor = Color.FromArgb(alfa, red, green, blue);
                    miBitmap.SetPixel(w, h, miColor);
                }
            dibujar();
        }


        private void btnArcoIris_Click(object sender, EventArgs e)
        {
            int w;
            int h;

            alfa = 200;
            for (w = 0; w < width; w++)
            {
                red = 255;
                green = 255;
                blue = 255;
                for (h = 0; h < height; h++)
                {
                    miColor = Color.FromArgb(alfa, red, green, blue);
                    if (blue > 0) blue--;
                    else
                        if (green > 0) green--;
                        else
                            if (red > 0) red--;
                            else break;
                    miBitmap.SetPixel(w, h, miColor);
                }
                dibujar();
            }
        }


        private void dibujar()
        {
            pictureBox1.Image = miBitmap;
        }
    }
}
