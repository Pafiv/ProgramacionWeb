using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoDDABERSH8ctal
{
    public partial class Algoritmo1 : Form
    {
        int x, y, p;

        

        public Algoritmo1()
        {
            InitializeComponent();
        }

        private void Algoritmo1_Load(object sender, EventArgs e)
        {

        }

        private void CirculoMedio(Graphics g,int xc,int yc,int r){
            this.x = xc;
            this.y = yc;
            this.p = r;

            int x = 0;
            int y = r;
            int p = 1 - r;

            PlotPoint(g, xc, yc, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                PlotPoint(g, xc, yc, x, y);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(radio.Text, out int r))
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.White);

                int xc = pictureBox1.Width / 2;
                int yc = pictureBox1.Height / 2;

                CirculoMedio(g, xc, yc, r);

                pictureBox1.Image = bmp;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para el radio.");
            }
        }
        private void PlotPoint(Graphics g, int xc, int yc, int x, int y)
        {
            DrawPixel(g, xc + x, yc + y);
            DrawPixel(g, xc - x, yc + y);
            DrawPixel(g, xc + x, yc - y);
            DrawPixel(g, xc - x, yc - y);
            DrawPixel(g, xc + y, yc + x);
            DrawPixel(g, xc - y, yc + x);
            DrawPixel(g, xc + y, yc - x);
            DrawPixel(g, xc - y, yc - x);
        }
        private void DrawPixel(Graphics g, int x, int y)
        {
            g.FillRectangle(Brushes.Black, x, y, 1, 1); // Dibuja un píxel negro
        }
    }
}
