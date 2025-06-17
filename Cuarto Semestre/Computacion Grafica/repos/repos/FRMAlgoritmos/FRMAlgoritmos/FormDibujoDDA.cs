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
    public partial class FormDibujoDDA : Form
    {
        private System.Collections.Generic.List<Point> puntos;        
        //constructor 
        public FormDibujoDDA(System.Collections.Generic.List<Point> puntos)
        {
            InitializeComponent();
            this.puntos = puntos;            
            this.Text = "Gráfico del Algoritmo DDA";
            this.Size = new Size(800, 800);
        }
        //evento Paint que dibuja la cuadricula, numeracion
        private void pictureBoxDDA_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int tamanoCelda = 40; 
            int desplazamiento = 50;  
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
            // Dibujar la línea c
            if (puntos.Count > 0)
            {
                var puntoInicial = puntos[0];
                var puntoFinal = puntos[puntos.Count - 1];
                int xInicio = desplazamiento + puntoInicial.X * tamanoCelda + tamanoCelda / 2;
                int yInicio = desplazamiento + (15 - puntoInicial.Y) * tamanoCelda + tamanoCelda / 2;
                int xFin = desplazamiento + puntoFinal.X * tamanoCelda + tamanoCelda / 2;
                int yFin = desplazamiento + (15 - puntoFinal.Y) * tamanoCelda + tamanoCelda / 2;
                g.DrawLine(new Pen(Color.Blue, 2), xInicio, yInicio, xFin, yFin);
            }
        }
    }
}
