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
    public partial class ControlConsumos : UserControl
    {
        public ControlConsumos()
        {
            InitializeComponent();
            ConfiguracionComponentes();
        }

        private void ConfiguracionComponentes()
        {
            gbxRegistroConsumos.Text = Properties.Resources.RegistroConsumos;
            lblCliente.Text = Properties.Resources.Cliente;
            lblConcepto.Text = Properties.Resources.Concepto;
            lblValor.Text = Properties.Resources.Valor;
            btnRegistrar.Text = Properties.Resources.Registrar;
        }
    }
}
