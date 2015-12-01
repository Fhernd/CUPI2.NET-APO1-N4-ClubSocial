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
    public partial class ControlConsumos : UserControl
    {
        #region Atributos interfaz
        private ControlBusquedaSocio ctlBusquedaSocio;
        private Principal principal;
        #endregion

        public ControlConsumos(Principal principal)
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

            gbxRegistroConsumos.Text = Properties.Resources.RegistroConsumos;
            lblCliente.Text = Properties.Resources.Cliente;
            lblConcepto.Text = Properties.Resources.Concepto;
            lblValor.Text = Properties.Resources.Valor;
            btnRegistrar.Text = Properties.Resources.Registrar;
        }
    }
}
