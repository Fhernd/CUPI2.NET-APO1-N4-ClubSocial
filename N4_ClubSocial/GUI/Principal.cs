using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N4_ClubSocial
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            ConfiguracionComponentes();
        }

        private void ConfiguracionComponentes()
        {
            this.Text = Properties.Resources.Nombre;

            tabOperaciones.TabPages[0].Text = Properties.Resources.Afiliar;
            tabOperaciones.TabPages[1].Text = Properties.Resources.Autorizados;
            tabOperaciones.TabPages[2].Text = Properties.Resources.Consumos;
            tabOperaciones.TabPages[3].Text = Properties.Resources.Facturas;
            tabOperaciones.TabPages[4].Text = Properties.Resources.Contabilidad;
        }
    }
}
