// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Control(es): `ControlAutorizados`
//
// Propósito: Implementar y representar control de 
// autorizados del club.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelautorizados
//
============================================================*/

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Clase que representa el control de autorizados del club.
    /// </summary>
    public partial class ControlAutorizados : UserControl
    {
        #region Atributos interfaz
        /// <summary>
        /// Control de búsqueda de socios.
        /// </summary>
        private ControlBusquedaSocio ctlBusquedaSocio;
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        /// <summary>
        /// Cédula del socio.
        /// </summary>
        private String cedula;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo control de autorizados.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal de la aplicación.</param>
        public ControlAutorizados(Principal principal)
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
            ctlBusquedaSocio = new ControlBusquedaSocio(principal, Operaciones.Autorizados);
            ctlBusquedaSocio.Location = new Point(0, 0);
            this.Controls.Add(ctlBusquedaSocio);

            gbxAutorizados.Text = Properties.Resources.Autorizados;
            lblNombre.Text = Properties.Resources.Nombre;
            btnAgregarAutorizado.Text = Properties.Resources.AgregarAutorizado;
        }

        /// <summary>
        /// Cambia los autorizados de un socio.
        /// </summary>
        /// <param name="autorizados">Lista de autorizados.</param>
        public void CambiarAutorizados(ArrayList autorizados)
        {
            lbxAutorizados.DataSource = autorizados;
        }

        /// <summary>
        /// Cambia los autorizados de un socio dado.
        /// </summary>
        /// <param name="autorizados">Lista de autorizados.</param>
        /// <param name="cedula">Cédula del socio.</param>
        public void CambiarAutorizados(ArrayList autorizados, string cedula)
        {
            this.cedula = cedula;
            lbxAutorizados.DataSource = autorizados;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara evento Click para agregar un nuevo autorizado.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnAgregarAutorizado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                if (cedula.Length > 0)
                {
                    principal.AgregarAutorizado(cedula, txtNombre.Text);

                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show(this, Properties.Resources.DebeBuscarSocio, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarNombre, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
