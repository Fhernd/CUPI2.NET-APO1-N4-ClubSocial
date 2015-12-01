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
    public partial class ControlFacturas : UserControl
    {
        public ControlFacturas()
        {
            InitializeComponent();
            ConfiguracionComponentes();
        } 

        private void ConfiguracionComponentes()
        {
            gbxFacturas.Text = Properties.Resources.Facturas;
            btnPagarFactura.Text = Properties.Resources.PagarFactura;
        }
    }
}
