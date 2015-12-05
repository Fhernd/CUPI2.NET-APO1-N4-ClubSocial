// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Principal`
//
// Propósito: Implementar y representar formulario principal 
// de la aplicación.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-3/tienda-de-libros/visualizacion-codigo/libro
//
============================================================*/

using System;
using System.Collections;
using System.Windows.Forms;
using N4_ClubSocial.GUI;
using N4_ClubSocial.Modelo;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial
{
    /// <summary>
    /// Representa el formulario principal de la aplicación.
    /// </summary>
    public partial class Principal : Form
    {
        #region Atributos
        /// <summary>
        /// Club de socios.
        /// </summary>
        private Club club;
        #endregion

        #region Atributos interfaz
        /// <summary>
        /// Control de afiliación de socios.
        /// </summary>
        private ControlAfiliacion ctlAfiliacion;
        /// <summary>
        /// Control de autorizados de un socio.
        /// </summary>
        private ControlAutorizados ctlAutorizados;
        /// <summary>
        /// Control de consumos de socios y autorizados.
        /// </summary>
        private ControlConsumos ctlConsumos;
        /// <summary>
        /// Control de facturas.
        /// </summary>
        private ControlFacturas ctlFacturas;
        /// <summary>
        /// Control de contabilidad del club.
        /// </summary>
        private ControlContabilidad ctlContabilidad;
        #endregion
        /// <summary>
        /// Crea el formulario principal de la aplicaciíon.
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            ConfiguracionComponentes();

            club = new Club();
        }

        #region Métodos auxiliares privados de interfaz
        /// <summary>
        /// Configura los componentes integrales de la interfaz de usuario.
        /// </summary>
        private void ConfiguracionComponentes()
        {
            this.Text = Properties.Resources.NombreAplicacion;
            this.Icon = Properties.Resources.icono;

            tabOperaciones.TabPages[0].Text = Properties.Resources.AfiliarPestaña;
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
        #endregion

        #region Métodos de lógica negocio
        /// <summary>
        /// Actualiza las facturas respecto al número de cédula de un socio.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        private void ActualizarFacturas(string cedula)
        {
            ctlFacturas.CambiarFacturas(club.ObtenerFacturasSocio(cedula), cedula);
        }

        /// <summary>
        /// Afilia un nuevo socio al club.
        /// </summary>
        /// <param name="socio">Nuevo socio del club.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio ya existe en el club.</exception>
        public void Afiliar(Socio socio)
        {
            try
            {
                club.AfiliarSocio(socio);
                MessageBox.Show(this, Properties.Resources.UsuarioRegistrado, Properties.Resources.Satisfactorio, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SocioExisteException ex)
            {
                MessageBox.Show(this, ex.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Busca un socio en club.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <param name="operacion">Indica la operación que se ha llevar a cabo -Autorización, Consumo o Facturación-</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio ya existe en el club.</exception>
        public void BuscarSocio(string cedula, Operaciones operacion)
        {
            int cedulaEntero;

            if (cedula.Equals(""))
            {
                MessageBox.Show(this, Properties.Resources.DebeIngresarCedula, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Int32.TryParse(cedula, out cedulaEntero))
            {
                switch (operacion)
                {
                    case Operaciones.Autorizados:
                        try
                        {
                            ArrayList autorizados = club.ObtenerAutorizadosSocio(cedula);

                            // Actualiza la interfaz:
                            ctlAutorizados.CambiarAutorizados(autorizados, cedula);
                        }
                        catch (SocioExisteException see)
                        {
                            MessageBox.Show(this, see.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Operaciones.Consumos:
                        try
                        {
                            ArrayList autorizados = club.ObtenerAutorizadosSocio(cedula);

                            // Actualización interfaz:
                            ctlConsumos.CambiarClientes(autorizados, cedula);
                        }
                        catch (SocioExisteException see)
                        {
                            MessageBox.Show(this, see.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case Operaciones.Facturas:
                        // Actualización interfaz:
                        ctlFacturas.CambiarFacturas(club.ObtenerFacturasSocio(cedula), cedula);
                        break;
                }
            }
            else
            {
                MessageBox.Show(this, Properties.Resources.DebeCedulaSerNumerico, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Agrega un autorizado para un socio del club.
        /// </summary>
        /// <param name="cedulaSocio">Número de cédula del socio.</param>
        /// <param name="nombreAutorizado">Nombre del cliente a autorizar.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        /// <exception cref="AutorizadoExisteException">Ocurre cuando el cliente autorizado ya existe para el socio especificado.</exception>
        public void AgregarAutorizado(string cedulaSocio, string nombreAutorizado)
        {
            try
            {
                // Agregación del autorizado:
                Socio socio = new Socio(cedulaSocio);
                club.AgregarAutorizadoSocio(socio, nombreAutorizado);
                ArrayList autorizados = club.ObtenerAutorizadosSocio(socio.Cedula);
                ctlAutorizados.CambiarAutorizados(autorizados);
            }
            catch (SocioExisteException see)
            {
                MessageBox.Show(this, see.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (AutorizadoExisteException aee)
            {
                MessageBox.Show(this, aee.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Registra un consumo para un socio/autorizado.
        /// </summary>
        /// <param name="cedula">Número de cédula del socio.</param>
        /// <param name="nombreCliente">Nombre del autorizado.</param>
        /// <param name="concepto">Concepto del consumo.</param>
        /// <param name="valor">Valor del consumo.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        public void RegistrarConsumo(string cedula, string nombreCliente, string concepto, decimal valor)
        {
            try
            {
                club.RegistrarConsumo(cedula, nombreCliente, concepto, valor);
            }
            catch (SocioExisteException see)
            {
                MessageBox.Show(this, see.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Paga la factura de un consumo.
        /// </summary>
        /// <param name="cedula">Número de cédula del socio.</param>
        /// <param name="numeroFactura">Número de factura.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        public void PagarFactura(string cedula, int numeroFactura)
        {
            try
            {
                club.PagarFactura(cedula, numeroFactura);

                ActualizarFacturas(cedula);
            }
            catch(SocioExisteException see)
            {
                MessageBox.Show(this, see.Message, Properties.Resources.Advertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Puntos de extensión
        /// <summary>
        /// Punto de extensión número 1.
        /// </summary>
        public void InvocarPuntoExtension1()
        {
            MessageBox.Show(this, club.MetodoExtension1(), Properties.Resources.Opcion1, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// punto de extensión número 2.
        /// </summary>
        public void InvocarPuntoExtension2()
        {
            MessageBox.Show(this, club.MetodoExtension2(), Properties.Resources.Opcion2, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion  
    }
}
