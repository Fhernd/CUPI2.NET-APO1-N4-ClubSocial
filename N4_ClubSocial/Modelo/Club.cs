using System;
using System.Collections;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocial.Modelo
{
    public class Club
    {
        #region Atributos
        private ArrayList socios;
        #endregion

        #region Constructores
        public Club()
        {
            socios = new ArrayList();
        }
        #endregion

        #region Métodos
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

        #region Métodos de extensión
        public String MetodoExtension1()
        {
            return "Respuesta 1";
        }

        public String MetodoExtension2()
        {
            return "Respuesta 2";
        }
        #endregion
    }
}