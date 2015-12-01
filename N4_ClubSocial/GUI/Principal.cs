using System;
using System.Collections;
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
        private ControlConsumos ctlConsumos;
        private ControlFacturas ctlFacturas;
        private ControlContabilidad ctlContabilidad;
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

            ctlAutorizados = new ControlAutorizados(this);
            ctlAutorizados.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[1].Controls.Add(ctlAutorizados);

            ctlConsumos = new ControlConsumos(this);
            ctlConsumos.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[2].Controls.Add(ctlConsumos);

            ctlFacturas = new ControlFacturas(this);
            ctlFacturas.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[3].Controls.Add(ctlFacturas);

            ctlContabilidad = new ControlContabilidad(this);
            ctlContabilidad.Dock = DockStyle.Fill;
            tabOperaciones.TabPages[4].Controls.Add(ctlContabilidad);
        }

        public void Afiliar(Socio socio)
        {
            try
            {
                club.AfiliarSocio(socio);
                MessageBox.Show(this, Properties.Resources.UsuarioRegistrado, Properties.Resources.Satisfactorio, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SocioExisteException ex)
            {
                MessageBox.Show(this, ex.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BuscarSocioAutorizado(string cedula)
        {
            int cedulaEntero;

            if(cedula.Equals(""))
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarCedula, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Int32.TryParse(cedula, out cedulaEntero))
            {
                try
                {
                    ArrayList autorizados = club.ObtenerAutorizadosSocio(cedula);


                    // Actualiza la interfaz:
                    ctlAutorizados.CambiarAutorizados(autorizados);
                }
                catch(SocioExisteException see)
                {
                    MessageBox.Show(this, see.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
