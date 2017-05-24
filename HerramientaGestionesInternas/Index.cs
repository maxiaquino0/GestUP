using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerramientaGestionesInternas
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Index_Load(object sender, EventArgs e)
        {
            UserControl inicio = new Inicio();
            panelIndex.Controls.Add(inicio);
            
        }

        private void urgenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Controls.Clear();
            UserControl urgencia = new Urgencia(panelIndex);
            panelIndex.Controls.Add(urgencia);
        }

        private void pNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Controls.Clear();
            UserControl pnr = new PNR(panelIndex);
            panelIndex.Controls.Add(pnr);
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Controls.Clear();
            UserControl acercaDe = new AcercaDe(panelIndex);
            panelIndex.Controls.Add(acercaDe);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Controls.Clear();
            UserControl inicio = new Inicio();
            panelIndex.Controls.Add(inicio);
        }
    }
}
