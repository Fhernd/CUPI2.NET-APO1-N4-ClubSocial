using System;
using System.Collections;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial.Modelo
{
    public class Socio
    {
        #region Atributos
        private String cedula;
        private String nombre;
        private ArrayList facturas;
        private ArrayList autorizados;
        #region 

        #region Propiedades
        public String Cedula
        {
            get
            {
                return cedula;
            }
        }
        public String Nombre
        {
            get
            {
                return nombre;
            }
        }
        public ArrayList Facturas
        {
            get
            {
                return facturas;
            }
        }
        public ArrayList Autorizados
        {
            get
            {
                return autorizados;
            }
        }
        #endregion

        #region Constructores
        public Socio(string cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            facturas = new ArrayList();
            autorizados = new ArrayList();
        }
        #endregion

        #region Métodos públicos
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

        public void PagarFactura(int numeroFactura)
        {
            facturas.RemoveAt(numeroFactura);
        }

        public void RegistrarConsumo(string nombre, string concepto, decimal valor)
        {
            Factura nuevaFactura = new Factura(nombre, concepto, valor);

            facturas.Add(nuevaFactura);
        }
        #endregion

        #region Métodos privados
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