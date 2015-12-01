using System;
using System.Collections;
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
        #region Atributos interfaz
        private ControlBusquedaSocio ctlBusquedaSocio;
        private Principal principal;
        #endregion

        public ControlAutorizados(Principal principal)
        {
            InitializeComponent();
            ConfiguracionComponentes();
            this.principal = principal;
        }

        private void ConfiguracionComponentes()
        {
            ctlBusquedaSocio = new ControlBusquedaSocio(principal);
            ctlBusquedaSocio.Location = new Point(0, 0);
            this.Controls.Add(ctlBusquedaSocio);

            gbxAutorizados.Text = Properties.Resources.Autorizados;
            lblNombre.Text = Properties.Resources.Nombre;
            btnAgregarAutorizado.Text = Properties.Resources.AgregarAutorizado;
        }

        public void CambiarAutorizados(ArrayList autorizados)
        {
            lbxAutorizados.Items.Clear();
            lbxAutorizados.DataSource = autorizados;
        }
    }
}
