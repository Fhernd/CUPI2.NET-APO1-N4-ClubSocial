using System;
using System.Collections;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial.Modelo
{
    public class Socio
    {
        #region Atributos
        /// <summary>
        /// Número de cédula del socio.
        /// </summary>
        private String cedula;
        /// <summary>
        /// Nombre del socio.
        /// </summary>
        private String nombre;
        /// <summary>
        /// Facturas del socio.
        /// </summary>
        private ArrayList facturas;
        /// <summary>
        /// Personas autorizadas por el socio.
        /// </summary>
        private ArrayList autorizados;
        #endregion 

        #region Propiedades
        /// <summary>
        /// Obtiene el número de cédula del socio.
        /// </summary>
        public String Cedula
        {
            get
            {
                return cedula;
            }
        }
        /// <summary>
        /// Obtiene el nombre del socio.
        /// </summary>
        public String Nombre
        {
            get
            {
                return nombre;
            }
        }
        /// <summary>
        /// Obtiene la lista de facturas del socio.
        /// </summary>
        public ArrayList Facturas
        {
            get
            {
                return facturas;
            }
        }
        /// <summary>
        /// Obtiene la lista de autorizados por el socio.
        /// </summary>
        public ArrayList Autorizados
        {
            get
            {
                return autorizados;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo socio.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        /// <param name="nombre">Nombre del socio.</param>
        public Socio(string cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            facturas = new ArrayList();
            autorizados = new ArrayList();
        }
        /// <summary>
        /// Crea un nuevo socio.
        /// </summary>
        /// <param name="cedula">Cédula del socio.</param>
        public Socio(string cedula)
        {
            this.cedula = cedula;
        }
        #endregion

        #region Métodos públicos
        /// <summary>
        /// Agrega un nuevo autorizado por el socio.
        /// </summary>
        /// <param name="nombreAutorizado">Nombre del autorizado.</param>
        /// <exception cref="AutoreferenciaSocioException">Ocurre cuando el socio es el mismo autorizado.</exception>
        /// <exception cref="AutorizadoExisteException">Ocurre cuando el autorizado ya existe.</exception>
        public void AgregarAutorizado(String nombreAutorizado)
        {
            // Verifica que el nombre del autorizado no sea el mismo del socio:
            if (nombre.Equals(nombreAutorizado))
            {
                throw new AutoreferenciaSocioException("Autorizado es el mismo Socio.");
            }

            // Si el nombre no existe entonces se agrega a la lista de autorizados:
            if (!ExisteAutorizado(nombreAutorizado))
            {
                autorizados.Add(nombreAutorizado);
            }
            else
            {
                throw new AutorizadoExisteException("Autorizado ya existe.");
            }
        }
        /// <summary>
        /// Eliminar un autorizado del socio.
        /// </summary>
        /// <param name="nombreAutorizado">Nombre del autorizado.</param>
        public void EliminarAutorizado(string nombreAutorizado)
        {
            bool encontrado = false;
            int numeroAutorizados = autorizados.Count;

            for (int numeroAutorizado = 0; numeroAutorizado < numeroAutorizados && !encontrado; ++numeroAutorizado)
            {
                string autorizado = (string)autorizados[numeroAutorizado];

                if (autorizado.Equals(nombreAutorizado))
                {
                    encontrado = true;
                    autorizados.RemoveAt(numeroAutorizado);
                }
            }
        }
        /// <summary>
        /// Paga la factura del socio o de uno de sus autorizados.
        /// </summary>
        /// <param name="numeroFactura">Número de la factura.</param>
        public void PagarFactura(int numeroFactura)
        {
            facturas.RemoveAt(numeroFactura);
        }
        /// <summary>
        /// Registra un consumo y genera una nueva factura.
        /// </summary>
        /// <param name="nombre">Nombre de la persona que efectúa el consumo.</param>
        /// <param name="concepto">Concepto del consumo.</param>
        /// <param name="valor">Valor del consumo.</param>
        public void RegistrarConsumo(string nombre, string concepto, decimal valor)
        {
            Factura nuevaFactura = new Factura(nombre, concepto, valor);

            facturas.Add(nuevaFactura);
        }
        #endregion

        #region Métodos privados
        /// <summary>
        /// Comprueba si el autorizado existe.
        /// </summary>
        /// <param name="nombreAutorizado">Nombre del autorizado.</param>
        /// <returns><i>true</i> si el autorizado existe, <i>false</i> en el caso contrario.</returns>
        private Boolean ExisteAutorizado(string nombreAutorizado)
        {
            bool encontrado = false;
            int numeroAutorizados = autorizados.Count;

            for (int numeroAutorizado = 0; numeroAutorizado < numeroAutorizados && !encontrado; ++numeroAutorizado)
            {
                String autorizado = (string)autorizados[numeroAutorizado];

                if (autorizado.Equals(nombreAutorizado))
                {
                    encontrado = true;
                }
            }

            return encontrado;
        }
        #endregion
    }
}