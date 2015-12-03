using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N4_ClubSocial.Modelo;

namespace N4_ClubSocial.GUI
{
    public partial class ControlAfiliacion : UserControl
    {
        #region Atributos de interfaz
        private Principal principal;
        #endregion

        public ControlAfiliacion(Principal principal)
        {
            InitializeComponent();
            ConfiguracionComponentes();

            this.principal = principal;
        }

        private void ConfiguracionComponentes()
        {
            // Personalización textos:
            gbxDatosPersonales.Text = Properties.Resources.DatosPersonales;
            lblNombre.Text = Properties.Resources.Nombre;
            lblCedula.Text = Properties.Resources.Cedula;
            btnAfiliar.Text = Properties.Resources.Afiliar;
        }

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
    }
}
