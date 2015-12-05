// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Control(s): `ControlFacturas`
//
// Propósito: Implementar y representar el control para 
// facturación.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelfacturas
//
============================================================*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using N4_ClubSocial.Modelo;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Control que representa la facturación del club.
    /// </summary>
    public partial class ControlFacturas : UserControl
    {
        #region Atributos interfaz
        /// <summary>
        /// Control de búsqueda de socio.
        /// </summary>
        private ControlBusquedaSocio ctlBusquedaSocio;
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        /// <summary>
        /// Cédula del socio actual.
        /// </summary>
        private String cedula;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo control de facturación.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal de la aplicación.</param>
        public ControlFacturas(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            ConfiguracionComponentes();
        }
        #endregion

        #region Métodos auxiliares de interfaz
        /// <summary>
        /// Configura los componentes de la interfaz.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            ctlBusquedaSocio = new ControlBusquedaSocio(principal, Operaciones.Facturas);
            ctlBusquedaSocio.Location = new Point(0, 0);
            this.Controls.Add(ctlBusquedaSocio);

            gbxFacturas.Text = Properties.Resources.Facturas;
            btnPagarFactura.Text = Properties.Resources.PagarFactura;
        }
        
        /// <summary>
        /// Cambia las facturas respecto al número de cédula de un socio.
        /// </summary>
        /// <param name="facturas">Lista de facturas a mostrar.</param>
        /// <param name="cedula">Cédula del socio.</param>
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
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara el evento Click para el botón de pago de factura.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
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
        #endregion
    }
}
