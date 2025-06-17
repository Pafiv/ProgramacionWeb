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
    public partial class Bresenham : Form
    {
        public Bresenham()
        {
            InitializeComponent();
        }     
        //boton calcular
        private void Calcular_Click_1(object sender, EventArgs e)
        {
            calcularPuntos();
        }
        //boton reset
        private void Reset_Click_1(object sender, EventArgs e)
        {
            Xi.Clear();
            Xf.Clear();
            Yi.Clear();
            Yf.Clear();
            Tabla.DataSource = null;
        }
        //boton salir
        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo para calcular los puntos de la recta
        private void calcularPuntos()
        {
            try
            {
                // Obtener valores ingresados
                int x0 = int.Parse(Xi.Text);
                int y0 = int.Parse(Yi.Text);
                int x1 = int.Parse(Xf.Text);
                int y1 = int.Parse(Yf.Text);
                // Inicializar tabla
                var table = new DataTable();
                table.Columns.Add("k", typeof(int));
                table.Columns.Add("Xk", typeof(string));
                table.Columns.Add("Yk", typeof(string));
                table.Columns.Add("p", typeof(string));
                table.Columns.Add("p_k < 0 (S/N)", typeof(string));
                // Cálculo de diferencias
                int dx = Math.Abs(x1 - x0);
                int dy = Math.Abs(y1 - y0);

                int sx = (x0 < x1) ? 1 : -1;
                int sy = (y0 < y1) ? 1 : -1;

                bool intercambio = dy > dx;
                if (intercambio)
                {
                    // Intercambiar dx y dy
                    int temp = dx;
                    dx = dy;
                    dy = temp;
                }
                // Coordenadas iniciales y parametro inicial
                int p = 2 * dy - dx;               
                int x = x0;
                int y = y0;
                var puntos = new System.Collections.Generic.List<Point>();
                for (int k = 0; k <= dx; k++)
                {                    
                    // Procedimiento de cálculo para p
                    string pFormula = (k == 0) ? $"{2 * dy} - {dx} = {p}" :
                                       (p < 0) ? $"{p} + {2 * dy} = {p + 2 * dy}" :
                                                 $"{p} + {2 * dy} - {2 * dx} = {p + 2 * dy - 2 * dx}";
                    // Procedimiento para Xk y Yk
                    string xkFormula = (k == 0) ? x.ToString() : $"{x - sx} + {sx} = {x}";
                    string ykFormula = (k == 0) ? y.ToString() :
                                       (p < 0) ? y.ToString() : $"{y - sy} + {sy} = {y}";
                    // Determinar S o N
                    string decision = (p < 0) ? "S" : "N";                    
                    table.Rows.Add(k, xkFormula, ykFormula, pFormula, decision);                    
                    puntos.Add(new Point(x, y));
                    // Actualizar parámetros
                    if (p >= 0)
                    {
                        if (intercambio)
                            x += sx;
                        else
                            y += sy;

                        p -= 2 * dx;
                    }
                    if (intercambio)
                        y += sy;
                    else
                        x += sx;
                    p += 2 * dy;
                }                
                Tabla.DataSource = table;                
                var formDibujoBre = new FormDibujoBre(puntos,new Point(x0,y0), new Point(x1, y1));
                formDibujoBre.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
