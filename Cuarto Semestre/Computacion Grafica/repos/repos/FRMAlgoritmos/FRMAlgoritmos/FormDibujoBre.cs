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
    public partial class FormDibujoBre : Form
    {
        private System.Collections.Generic.List<Point> puntos;
        private Point puntoInicial;
        private Point puntoFinal;
        public FormDibujoBre(System.Collections.Generic.List<Point> puntos, Point puntoInicial, Point puntoFinal)
        {
            InitializeComponent();
            this.puntos = puntos;
            this.puntoInicial = puntoInicial;
            this.puntoFinal = puntoFinal;
            this.Text = "Gráfico de Bresenham";
            this.Size = new Size(800, 800);
        }
        //evento Paint donde se dibuja la cuadricula, numeracion de los ejes, puntos y la recta
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int tamanoCelda = 40; // Tamaño de cada celda
            int desplazamiento = 50;  // Desplazamiento para los bordes
            // Dibujar la cuadrícula
            for (int i = 0; i <= 15; i++)
            {
                g.DrawLine(Pens.Gray, desplazamiento, desplazamiento + i * tamanoCelda, desplazamiento + 15 * tamanoCelda, desplazamiento + i * tamanoCelda);
                g.DrawLine(Pens.Gray, desplazamiento + i * tamanoCelda, desplazamiento, desplazamiento + i * tamanoCelda, desplazamiento + 15 * tamanoCelda);
            }
            // Dibujar numeración
            for (int i = 0; i <= 15; i++)
            {
                g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, desplazamiento - 20, desplazamiento + (15 - i) * tamanoCelda - 5);
                g.DrawString(i.ToString(), new Font("Arial", 8), Brushes.Black, desplazamiento + i * tamanoCelda - 5, desplazamiento + 15 * tamanoCelda + 5);
            }
            // Dibujar los puntos
            foreach (var punto in puntos)
            {
                int x = desplazamiento + punto.X * tamanoCelda;
                int y = desplazamiento + (15 - punto.Y) * tamanoCelda; // Invertir el eje Y

                g.FillRectangle(Brushes.LightBlue, x, y, tamanoCelda, tamanoCelda);
            }            
            // Dibujar la línea 
            int xInicio = desplazamiento + puntoInicial.X * tamanoCelda + tamanoCelda / 2;
            int yInicio = desplazamiento + (15 - puntoInicial.Y) * tamanoCelda + tamanoCelda / 2;
            int xFin = desplazamiento + puntoFinal.X * tamanoCelda + tamanoCelda / 2;
            int yFin = desplazamiento + (15 - puntoFinal.Y) * tamanoCelda + tamanoCelda / 2;

            g.DrawLine(new Pen(Color.Blue, 2), xInicio, yInicio, xFin, yFin);
        }
    }
}
