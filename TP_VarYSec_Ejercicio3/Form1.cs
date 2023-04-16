using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio3
{
    public partial class fRevoque : Form
    {
        public fRevoque()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bRevoque_Click(object sender, EventArgs e)
        {
            double mtsCubicos = (Convert.ToDouble(tAlto.Text) * Convert.ToDouble(tAncho.Text)) * 0.5;
            MessageBox.Show("Se necesitan " + mtsCubicos + " metros cubicos de arena");
        }
    }
}
