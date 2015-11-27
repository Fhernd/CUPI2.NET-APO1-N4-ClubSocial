using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    public partial class ControlAfiliacion : UserControl
    {
        public ControlAfiliacion()
        {
            InitializeComponent();
            ConfiguracionComponentes();
        }

        private void ConfiguracionComponentes()
        {
            // Personalización textos:
            gbxDatosPersonales.Text = Properties.Resources.DatosPersonales;
            lblNombre.Text = Properties.Resources.Nombre;
            lblCedula.Text = Properties.Resources.Cedula;
            btnAfiliar.Text = Properties.Resources.Afiliar;
        }
    }
}
