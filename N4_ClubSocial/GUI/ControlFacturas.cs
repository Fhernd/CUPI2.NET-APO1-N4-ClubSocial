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
    public partial class ControlFacturas : UserControl
    {
        #region Atributos interfaz
        private ControlBusquedaSocio ctlBusquedaSocio;
        private Principal principal;
        #endregion
        public ControlFacturas(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            ConfiguracionComponentes();
        } 

        private void ConfiguracionComponentes()
        {
            ctlBusquedaSocio = new ControlBusquedaSocio(principal, Operaciones.Facturas);
            ctlBusquedaSocio.Location = new Point(0, 0);
            this.Controls.Add(ctlBusquedaSocio);

            gbxFacturas.Text = Properties.Resources.Facturas;
            btnPagarFactura.Text = Properties.Resources.PagarFactura;
        }
    }
}
