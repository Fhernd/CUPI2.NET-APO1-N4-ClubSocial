// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Control(es): `ControlConsumo`
//
// Propósito: Implementar y representar control de 
// consumos del club.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelregistroconsumos
//
============================================================*/

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Control que representa los consumos de los socios del club.
    /// </summary>
    public partial class ControlConsumos : UserControl
    {
        #region Atributos interfaz
        /// <summary>
        /// Control de busqueda de socio.
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
        /// Crea un nuevo control de consumos.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal de la aplicación.</param>
        public ControlConsumos(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            ConfiguracionComponentes();
        }
        #endregion

        #region Métodos auxiliares de interfaz
        /// <summary>
        /// Configuración de los componentes de interfaz.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            ctlBusquedaSocio = new ControlBusquedaSocio(principal, Operaciones.Consumos);
            ctlBusquedaSocio.Location = new Point(0, 0);
            this.Controls.Add(ctlBusquedaSocio);

            gbxRegistroConsumos.Text = Properties.Resources.RegistroConsumos;
            lblCliente.Text = Properties.Resources.Cliente;
            lblConcepto.Text = Properties.Resources.Concepto;
            lblValor.Text = Properties.Resources.Valor;
            btnRegistrar.Text = Properties.Resources.Registrar;
        }

        /// <summary>
        /// Cambia los autorizados para un socio dado.
        /// </summary>
        /// <param name="autorizados">Lista de autorizados.</param>
        /// <param name="cedula">Cédula del socio.</param>
        public void CambiarClientes(ArrayList autorizados, string cedula)
        {
            this.cedula = cedula;
            cbxClientes.Items.Clear();

            for(int numeroAutorizado = 0; numeroAutorizado < autorizados.Count; ++numeroAutorizado)
            {
                string nombre = (string) autorizados[numeroAutorizado];
                cbxClientes.Items.Add(nombre);
            }

            if (cbxClientes.Items.Count > 0)
            {
                cbxClientes.SelectedIndex = 0;
            }
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara el evento Click para registro de consumo.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(!txtConcepto.Equals(""))
            {
                decimal valor;
                if (Decimal.TryParse(txtValor.Text, out valor))
                {
                    principal.RegistrarConsumo(cedula, cbxClientes.Items[cbxClientes.SelectedIndex].ToString(), txtConcepto.Text, valor);
                    txtConcepto.Text = "";
                    txtValor.Text = "";
                }
                else
                {
                    MessageBox.Show(this, Properties.Resources.DebeValorSerNumerico, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarConcepto, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
