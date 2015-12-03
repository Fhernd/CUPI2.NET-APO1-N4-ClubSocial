using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using N4_ClubSocial.Modelo;

namespace N4_ClubSocial.GUI
{
    public partial class ControlFacturas : UserControl
    {
        #region Atributos interfaz
        private ControlBusquedaSocio ctlBusquedaSocio;
        private Principal principal;
        private String cedula;
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

        public void CambiarFacturas(ArrayList facturas, string cedula)
        {
            this.cedula = cedula;

            if (lstFacturas.Items.Count > 0)
            {
                lstFacturas.Items.Clear();
            }

            for(int numeroFactura = 0; numeroFactura < facturas.Count; ++numeroFactura)
            {
                Factura factura = (Factura)facturas[numeroFactura];

                string formatoFactura = String.Format("{0}\t{1:C}\t({2})", factura.Concepto, factura.Valor, factura.Nombre);

                lstFacturas.Items.Add(formatoFactura);
            }
        }

        private void btnPagarFactura_Click(object sender, EventArgs e)
        {
            if (lstFacturas.Items.Count > 0)
            {
                if (cedula.Length > 0)
                {
                    principal.PagarFactura(cedula, lstFacturas.SelectedIndex);
                }
                else
                {
                    MessageBox.Show(this, Properties.Resources.DebeIngresarCedula, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(this, Properties.Resources.NoHayFacturasPorPagar, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
