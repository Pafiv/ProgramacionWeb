using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoDDABERSH8ctal;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void algotirmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algoritmo1 algoritmo1 = new Algoritmo1();
            algoritmo1.Show();
            
        }

        private void algoritmoRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDA dDA = new DDA();
            dDA.Show();

        }

        private void algoritmoDeBresehamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breseham breseham = new Breseham();
            breseham.Show();
        }
    }
}
