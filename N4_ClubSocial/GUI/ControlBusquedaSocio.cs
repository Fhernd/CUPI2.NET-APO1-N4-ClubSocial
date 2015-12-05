// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Control(es): `ControlBusquedaSocio`
//
// Propósito: Implementar y representar el control de 
// búsqueda de un socio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelbusquedasocio
//
============================================================*/

using System;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Control que representa los componentes de búsqueda de un socio.
    /// </summary>
    public partial class ControlBusquedaSocio: UserControl
    {
        #region Atributos interfaz
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        /// <summary>
        /// Operación de este control.
        /// </summary>
        private Operaciones operacion;
        #endregion

        #region Constructores
        public ControlBusquedaSocio(Principal principal, Operaciones operacion)
        {
            InitializeComponent();
            ConfiguracionComponentes();
            this.principal = principal;
            this.operacion = operacion;
        }
        #endregion

        #region Métodos auxiliares de interfaz
        /// <summary>
        /// Configuración de los controles de interfaz.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            gbxBusquedaSocio.Text = Properties.Resources.BusquedaDeSocio;
            lblCedulaSocio.Text = Properties.Resources.CedulaSocio;
            btnBuscarSocio.Text = Properties.Resources.Buscar;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara evento Click para búsqueda de socio.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            principal.BuscarSocio(txtCedulaSocio.Text, operacion);
        }
        #endregion
    }
}
