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
    public partial class ControlContabilidad : UserControl
    {
        public ControlContabilidad()
        {
            InitializeComponent();
            ConfiguracionComponentes();
        }

        private void ConfiguracionComponentes()
        {
            gbxOpcion1.Text = Properties.Resources.Opcion1;
            btnOpcion1.Text = Properties.Resources.Opcion1;

            gbxOpcion2.Text = Properties.Resources.Opcion2;
            btnOpcion2.Text = Properties.Resources.Opcion2;
        }
    }
}
