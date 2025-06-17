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
    public partial class Algoritmos : Form
    {
        public Algoritmos()
        {
            InitializeComponent();
        }
        //boton del menustrip para el algoritmo DDA
        private void algoritmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDA formDDA = new DDA();
            formDDA.MdiParent = this;
            formDDA.Show();            
        }
        //boton del menustrip para el algoritmo Bresenham
        private void algoritmoBreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bresenham formBre = new Bresenham();
            formBre.MdiParent = this;
            formBre.Show();
        }

        private void algoritmoCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoMedio formPuntoMedio = new PuntoMedio();
            formPuntoMedio.MdiParent = this;
            formPuntoMedio.Show();
        }
    }
}
