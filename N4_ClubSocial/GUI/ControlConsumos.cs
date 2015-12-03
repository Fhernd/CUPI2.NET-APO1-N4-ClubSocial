using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    public partial class ControlConsumos : UserControl
    {
        #region Atributos interfaz
        private ControlBusquedaSocio ctlBusquedaSocio;
        private Principal principal;
        private String cedula;
        #endregion

        public ControlConsumos(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            ConfiguracionComponentes();
        }

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
    }
}
