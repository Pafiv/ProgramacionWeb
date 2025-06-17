using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Breseham : Form
    {
        public Breseham()
        {
            InitializeComponent();
            InicializarTabla();
        }
        private void InicializarTabla()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Paso", "Paso");
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Leer entradas
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);

            float escala = 20.0f;
            int origenX = bmp.Width / 2;
            int origenY = bmp.Height / 2;

            // Dibujar fondo
            DDA_Algoritmo.DibujarEjesYCuadricula(bmp, escala, Color.Black, Color.LightGray);

            // Ejecutar Bresenham
            List<Bresenham_Algoritmo.PuntoPaso> puntos = Bresenham_Algoritmo.CalcularLineaBresenham(
                x1, y1, x2, y2, bmp, escala, Color.Red, origenX, origenY);

            // Mostrar pasos
            foreach (var punto in puntos)
            {
                dataGridView1.Rows.Add(punto.Paso, punto.X, punto.Y);
            }

            pictureBox1.Image = bmp;
        }
    }
}
