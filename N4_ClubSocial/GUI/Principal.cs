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
using N4_ClubSocial.GUI;
using N4_ClubSocial.Modelo;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial
{
    public partial class Principal : Form
    {
        #region Atributos
        private Club club;
        #endregion

        #region Atributos interfaz
        private ControlAfiliacion ctlAfiliacion;
        private ControlAutorizados ctlAutorizados;
        #endregion
        public Principal()
        {
            InitializeComponent();

            ConfiguracionComponentes();

            club = new Club();
        }

        private void ConfiguracionComponentes()
        {
            this.Text = Properties.Resources.Nombre;

            tabOperaciones.TabPages[0].Text = Properties.Resources.Afiliar;
            tabOperaciones.TabPages[1].Text = Properties.Resources.Autorizados;
            tabOperaciones.TabPages[2].Text = Properties.Resources.Consumos;
            tabOperaciones.TabPages[3].Text = Properties.Resources.Facturas;
            tabOperaciones.TabPages[4].Text = Properties.Resources.Contabilidad;

            ctlAfiliacion = new ControlAfiliacion(this);
            ctlAfiliacion.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[0].Controls.Add(ctlAfiliacion);
            ctlAutorizados = new ControlAutorizados();
            ctlAutorizados.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[1].Controls.Add(ctlAutorizados);
        }

        public void Afiliar(Socio socio)
        {
            try
            {
                club.AfiliarSocio(socio);
            }
            catch(SocioExisteException ex)
            {
                MessageBox.Show(this, ex.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
