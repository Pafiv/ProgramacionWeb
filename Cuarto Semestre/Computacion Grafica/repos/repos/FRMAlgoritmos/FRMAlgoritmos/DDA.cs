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
    public partial class DDA : Form
    {       
        //constructor
        public DDA()
        {
            InitializeComponent();
        }        
        //boton para calcular
        private void Calcular_Click(object sender, EventArgs e)
        {
            calcularPuntos();
        }
        //boton para salir
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton para resetear
        private void Reset_Click(object sender, EventArgs e)
        {
            Xi.Clear();
            Xf.Clear();
            Yi.Clear();
            Yf.Clear();
            Tabla.DataSource = null;
        }
        //metodo para redondear los numeros
        private double RedondearMayor(double valor)
        {
            // Multiplicamos por 10 para trabajar con un solo decimal
            double factor = 10.0;
            double resultado = Math.Ceiling(valor * factor) / factor;            
            if (resultado - Math.Floor(resultado) < 0.05)
            {
                return Math.Floor(valor * factor) / factor;
            }
            return resultado;
        }
        //metodo para calcular los puntos necesarios
        private void calcularPuntos()
        {
            try
            {
                // Obtener valores ingresados
                int x0 = int.Parse(Xi.Text);
                int y0 = int.Parse(Yi.Text);
                int x1 = int.Parse(Xf.Text);
                int y1 = int.Parse(Yf.Text);
                // Configurar tabla
                var table = new DataTable();
                table.Columns.Add("k", typeof(int));
                table.Columns.Add("Xk", typeof(string));
                table.Columns.Add("Redondeo en X", typeof(int));
                table.Columns.Add("Yk", typeof(string));
                table.Columns.Add("Redondeo en Y", typeof(int));
                double dx = x1 - x0;
                double dy = y1 - y0;
                double m = (dx != 0) ? dy / dx : 0; 
                double steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
                // Ajustar incrementos y redondearlos hacia el próximo decimal mayor
                double xIncrement = (m <= 1) ? 1 : RedondearMayor(1 / m);
                double yIncrement = (m > 1) ? 1 : RedondearMayor(m);
                if (dx < 0) xIncrement = -xIncrement;
                if (dy < 0) yIncrement = -yIncrement;
                double x = x0;
                double y = y0;
                // Lista de puntos para el gráfico
                var puntos = new System.Collections.Generic.List<Point>();                
                for (int k = 0; k <= steps; k++)
                {
                    // Para k=0 usar los valores iniciales directamente
                    string xkFormula = (k == 0) ? $"{x0}" : $"{x:F2} + {xIncrement:F2}";
                    string ykFormula = (k == 0) ? $"{y0}" : $"{y:F2} + {yIncrement:F2}";
                    // Calcular siguiente valor y redondearlo correctamente
                    double xNext = (k == 0) ? x : x + xIncrement;
                    double yNext = (k == 0) ? y : y + yIncrement;                    
                    table.Rows.Add(
                        k,
                        xkFormula + (k == 0 ? "" : " = " + Math.Round(xNext, 2).ToString("F2")),
                        (int)Math.Round(xNext),
                        ykFormula + (k == 0 ? "" : " = " + Math.Round(yNext, 2).ToString("F2")),
                        (int)Math.Round(yNext)
                    );
                    puntos.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                    x = xNext;
                    y = yNext;
                }
                // Asignar tabla al DataGridView
                Tabla.DataSource = table;
                // Mostrar el gráfico
                var formDibujoDDA = new FormDibujoDDA(puntos);
                formDibujoDDA.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
