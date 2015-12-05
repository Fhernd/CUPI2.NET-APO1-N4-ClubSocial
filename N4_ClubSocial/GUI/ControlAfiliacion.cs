// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Control(es): `ControlAfiliacion`
//
// Propósito: Implementar y representar control de 
// afiliación de socios al club.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/paneldatospersonales
//
============================================================*/

using System;
using System.Windows.Forms;
using N4_ClubSocial.Modelo;

namespace N4_ClubSocial.GUI
{
    /// <summary>
    /// Clase que representa el control de afiliación de socios al club.
    /// </summary>
    public partial class ControlAfiliacion : UserControl
    {
        #region Atributos de interfaz
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo control de afiliación.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal de la aplicación.</param>
        public ControlAfiliacion(Principal principal)
        {
            InitializeComponent();
            ConfiguracionComponentes();

            this.principal = principal;
        }
        #endregion

        #region Métodos auxiliares de interfaz
        /// <summary>
        /// Configuración de componentes de interfaz.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            // Personalización textos:
            gbxDatosPersonales.Text = Properties.Resources.DatosPersonales;
            lblNombre.Text = Properties.Resources.Nombre;
            lblCedula.Text = Properties.Resources.Cedula;
            btnAfiliar.Text = Properties.Resources.Afiliar;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Dispara evento Click para afiliar a un nuevo socio al club.
        /// </summary>
        /// <param name="sender">Generador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnAfiliar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarNombre, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCedula.Text.Length == 0)
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarCedula, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obtiene el valor del campo de cédula:
                string cedulaTexto = txtCedula.Text;
                int cedula;
                if (Int32.TryParse(cedulaTexto, out cedula))
                {
                    Socio socio = new Socio(cedula.ToString(), txtNombre.Text);

                    principal.Afiliar(socio);

                    txtCedula.Text = "";
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show(this, Properties.Resources.DebeCedulaSerNumerico, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}
