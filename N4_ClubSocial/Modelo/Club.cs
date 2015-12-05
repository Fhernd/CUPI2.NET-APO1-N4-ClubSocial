// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Club`
//
// Propósito: Implementar y representar la entidad `Club`
// del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/club
//
============================================================*/

using System;
using System.Collections;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial.Modelo
{
    /// <summary>
    /// Clase que representa la entidad `Club`.
    /// </summary>
    public class Club
    {
        #region Atributos
        /// <summary>
        /// Socios del club.
        /// </summary>
        private ArrayList socios;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo club.
        /// </summary>
        public Club()
        {
            socios = new ArrayList();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Afilia un socio al club.
        /// </summary>
        /// <param name="socio">Socio a afiliar.</param>
        public void AfiliarSocio(Socio socio)
        {
            // Revisa que no existe un socio con la misma cédula:
            Socio socioEncontrado = BuscarSocio(socio.Cedula);

            if (socioEncontrado == null)
            {
                // Crea una nueva instancia de Socio:
                Socio nuevoSocio = new Socio(socio.Cedula, socio.Nombre);

                // Se agrega el nuevo socio al club:
                socios.Add(nuevoSocio);
            }
            else
            {
                throw new SocioExisteException("El socio ya existe.");
            }
        }

        /// <summary>
        /// Busca un socio a partir de su número de cédula.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <returns>El socio buscado o <i>null</i> en caso de la cédula no exista.</returns>
        public Socio BuscarSocio(String cedula)
        {
            Socio socio = null;
            bool encontrado = false;
            int numeroSocios = socios.Count;
            
            for (int numeroSocio = 0; numeroSocio < numeroSocios && !encontrado; ++numeroSocio)
            {
                Socio otroSocio = (Socio)socios[numeroSocio];

                if (otroSocio.Cedula.Equals(cedula))
                {
                    socio = otroSocio;
                    encontrado = true;
                }
            }

            return socio;
        }
        /// <summary>
        /// Obtiene la lista de autorizados de un socio.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <returns>Lista de las personas autorizadas para este cliente.</returns>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        public ArrayList ObtenerAutorizadosSocio(string cedula)
        {
            Socio socio = BuscarSocio(cedula);
            ArrayList autorizados = new ArrayList();

            if (socio == null)
            {
                throw new SocioExisteException("El socio con esa cédula no existe.");
            }
            else
            {
                autorizados.Add(socio.Nombre);
                autorizados.AddRange(socio.Autorizados);
            }

            return autorizados;
        }

        /// <summary>
        /// Agrega a un autorizado para un socio.
        /// </summary>
        /// <param name="socioAutorizado">Socio que autoriza.</param>
        /// <param name="nombreAutorizado">Nombre del autorizado.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        /// <exception cref="AutorizadoExisteException">Ocurre cuando el autorizado ya existe para el socio dado.</exception>
        public void AgregarAutorizadoSocio(Socio socioAutorizado, string nombreAutorizado)
        {
            Socio socio = BuscarSocio(socioAutorizado.Cedula);

            if (socio == null)
            {
                throw new SocioExisteException("El socio con esa cédula no existe.");
            }
            else
            {
                try
                {
                    socio.AgregarAutorizado(nombreAutorizado);
                }
                catch(AutorizadoExisteException aee)
                {
                    throw aee;
                }
            }
        }

        /// <summary>
        /// Registra un nuevo concusmo para un socio o un autorizado.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <param name="nombreCliente">Nombre del autorizado.</param>
        /// <param name="concepto">Concepto del consumo</param>
        /// <param name="valor">Valor del consumo.</param>
        /// <exception cref="SocioExisteException">Ocurre cuando el socio no existe en el club.</exception>
        public void RegistrarConsumo(string cedula, string nombreCliente, string concepto, decimal valor)
        {
            Socio socio = BuscarSocio(cedula);

            if (socio == null)
            {
                throw new SocioExisteException("El socio con esa cédula existe.");
            }
            else
            {
                socio.RegistrarConsumo(nombreCliente, concepto, valor);
            }
        }

        /// <summary>
        /// Obtiene las facturas de un socio.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <returns>Lista de facturas del socio.</returns>
        public ArrayList ObtenerFacturasSocio(string cedula)
        {
            ArrayList facturas = new ArrayList();
            Socio socio = BuscarSocio(cedula);

            if (socio == null)
            {
                throw new SocioExisteException("El socio con esa cédula no existe.");
            }
            else
            {
                facturas.AddRange(socio.Facturas);
            }

            return facturas;
        }

        /// <summary>
        /// Paga la factura de un socio.
        /// </summary>
        /// <param name="cedula">Número de cédula de un socio.</param>
        /// <param name="numeroFactura">Número de la factura a pagar.</param>
        /// <exception cref="SocioExisteException">Occurre cuando el socio no existe en el club.</exception>
        public void PagarFactura(string cedula, int numeroFactura)
        {
            Socio socio = BuscarSocio(cedula);

            if (socio == null)
            {
                throw new SocioExisteException("El socio con esa cédula no existe.");
            }
            else
            {
                socio.PagarFactura(numeroFactura);
            }
        }
        #endregion

        #region Puntos de extensión
        /// <summary>
        /// Punto de extensión número 1.
        /// </summary>
        /// <returns>Respuesta del punto de extensión número 1.</returns>
        public String MetodoExtension1()
        {
            return "Respuesta 1";
        }

        /// <summary>
        /// Punto de extensión número 2.
        /// </summary>
        /// <returns>Respuesta del punto de extensión número 2.</returns>
        public String MetodoExtension2()
        {
            return "Respuesta 2";
        }
        #endregion
    }
}