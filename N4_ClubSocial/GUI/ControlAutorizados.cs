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
    public partial class ControlAutorizados : UserControl
    {
        public ControlAutorizados()
        {
            InitializeComponent();
            ConfiguracionComponentes();
        }

        private void ConfiguracionComponentes()
        {
            gbxBusquedaSocio.Text = Properties.Resources.BusquedaDeSocio;
            lblCedulaSocio.Text = Properties.Resources.CedulaSocio;
            btnBuscarSocio.Text = Properties.Resources.Buscar;
            gbxAutorizados.Text = Properties.Resources.Autorizados;
            lblNombre.Text = Properties.Resources.Nombre;
            btnAgregarAutorizado.Text = Properties.Resources.AgregarAutorizado;
        }
    }
}
