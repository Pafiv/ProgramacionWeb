using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMAlgoritmos
{
    public partial class PuntoMedio : Form
    {
        public PuntoMedio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores de los TextBox
                int factorEscala = 12;
                int xc = int.Parse(txtCentroX.Text)*factorEscala;
                int yc = int.Parse(txtCentroY.Text) * factorEscala;
                int r = int.Parse(txtRadio.Text) * factorEscala;

                // Crear un bitmap para dibujar
                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    DrawCircle(g, xc, yc, r);
                }
                picCanvas.Image = bmp; 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCentroX.Clear();
            txtCentroY.Clear();
            txtRadio.Clear();
            picCanvas.Image = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DrawCircle(Graphics g, int xc, int yc, int r)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            PlotPoints(g, xc, yc, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 3;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 5;
                }
                PlotPoints(g, xc, yc, x, y);
            }
        }
        private void PlotPoints(Graphics g, int xc, int yc, int x, int y)
        {
            // Dibujar los puntos en los ocho octantes
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
            if (x >= 0 && x < picCanvas.Width && y >= 0 && y < picCanvas.Height)
            {
                g.FillRectangle(Brushes.Black, x, y, 1, 1);
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
