using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HerramientaGestionesInternas
{
    public partial class PNR : UserControl
    {
        Panel _panelIndex;
        public PNR(Panel panelIndex)
        {
            _panelIndex = panelIndex;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            const string fic = @"C:\IISS\PNR.txt";
            var user = SystemInformation.UserName;
            string texto = txtANI.Text + '|' + txtAveriaAFranquear.Text + '|' + txtAveriaAIngresar.Text + '|' + txtMotivo.Text + '|' +
                txtTELReferencia.Text + '|' + txtHorarioVisita.Text + '|' +
                user + '|' + DateTime.Now.Day.ToString() + '/' + DateTime.Now.Month.ToString() + '/' + DateTime.Now.Year.ToString() + '|' +
                DateTime.Now.Hour.ToString() + ':' + DateTime.Now.Minute.ToString() + ':' + DateTime.Now.Second.ToString();
            StreamWriter sw = new StreamWriter(fic, true);
            sw.WriteLine(texto);
            sw.Close();
            txtANI.Text = "";
            txtAveriaAFranquear.Text = "";
            txtAveriaAIngresar.Text = "";
            txtMotivo.Text = "";
            txtTELReferencia.Text = "";
            txtHorarioVisita.Text = "";
            this._panelIndex.Controls.Clear();
            UserControl inicio = new Inicio();
            _panelIndex.Controls.Add(inicio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtANI.Text = "";
            txtAveriaAFranquear.Text = "";
            txtAveriaAIngresar.Text = "";
            txtMotivo.Text = "";
            txtTELReferencia.Text = "";
            txtHorarioVisita.Text = "";
            this._panelIndex.Controls.Clear();
            UserControl inicio = new Inicio();
            _panelIndex.Controls.Add(inicio);
        }
    }
}
