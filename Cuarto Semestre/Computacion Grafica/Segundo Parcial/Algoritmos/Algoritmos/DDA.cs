using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Algoritmos;

namespace AlgoritmoDDABERSH8ctal
{
    public partial class DDA : Form
    {

        public DDA()
        {
            InitializeComponent();
            InicializarTabla();
        }
        private void InicializarTabla()
        {
            dataGridView1.Columns.Clear(); // Limpiar columnas previas

            dataGridView1.Columns.Add("Paso", "Paso");
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");

            dataGridView1.RowHeadersVisible = false; // Ocultar la columna vacía del lado izquierdo
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Que ocupen todo el ancho
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void dibujo(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Dibujar ejes
            DibujarEjes(g, bmp.Width, bmp.Height);

            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            float escala = 20.0f;

            // Traducir coordenadas al centro del bitmap
            List<DDA_Algoritmo.PuntoPaso> puntos = DDA_Algoritmo.CalcularLineaDDA(x1, y1, x2, y2, bmp, escala, Color.Blue, bmp.Width / 2, bmp.Height / 2);

            foreach (var punto in puntos)
            {
                dataGridView1.Rows.Add(punto.Paso, punto.X, punto.Y);
            }

            pictureBox1.Image = bmp;
        }

        private void DibujarEjes(Graphics g, int width, int height)
        {
            Pen ejePen = new Pen(Color.Gray, 1);
            g.DrawLine(ejePen, width / 2, 0, width / 2, height); // Eje Y
            g.DrawLine(ejePen, 0, height / 2, width, height / 2); // Eje X
        }

    }
    }
