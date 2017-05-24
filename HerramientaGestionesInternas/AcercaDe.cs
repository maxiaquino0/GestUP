using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerramientaGestionesInternas
{
    public partial class AcercaDe : UserControl
    {
        Panel _panelIndex;
        public AcercaDe(Panel panelIndex)
        {
            _panelIndex = panelIndex;
            InitializeComponent();
        }
    }
}
