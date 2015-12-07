// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Controls(s): `ControlContabilidad`
//
// Propósito: Implementar y representar el control de 
// contabilidad.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelcalcular1
http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/panelcalcular2
//
============================================================*/

using System;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Control que representa la contabilidad del club.
    /// </summary>
    public partial class ControlContabilidad : UserControl
    {
        #region Atributos interfaz
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo control de contabilidad.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal de la aplicación.</param>
        public ControlContabilidad(Principal principal)
        {
            InitializeComponent();
            ConfiguracionComponentes();
            this.principal = principal;
        }
        #endregion

        #region Métodos auxiliares de interfaz
        /// <summary>
        /// Configura los componentes de la interfaz.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            gbxOpcion1.Text = Properties.Resources.Opcion1Titulo;
            btnOpcion1.Text = Properties.Resources.Opcion1;

            gbxOpcion2.Text = Properties.Resources.Opcion2Titulo;
            btnOpcion2.Text = Properties.Resources.Opcion2;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara el evento Click para la invocación del punto de extensión no. 1.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            principal.InvocarPuntoExtension1();
        }

        /// <summary>
        /// Dispara el evento Click para la invocación del punto de extensión no. 1.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            principal.InvocarPuntoExtension2();
        }
        #endregion
    }
}
