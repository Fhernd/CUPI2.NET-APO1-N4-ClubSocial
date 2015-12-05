// ===++===z
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase de prueba: `ClubTest`
//
// Propósito: Probar el comportamiento y estado de objetos 
// de la clase `Club`.
//
// Original: N/D
//
============================================================*/

using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N4_ClubSocial.Modelo;
using N4_ClubSocial.Excepciones;

namespace N4_ClubSocialTest
{
    /// <summary>
    /// Clase que representa las pruebas para la clase `Club`.
    /// </summary>
    [TestClass]
    public class ClubTest
    {
        #region Atributos de prueba
        /// <summary>
        /// Socio del club.
        /// </summary>
        private Socio socio;
        /// <summary>
        /// Club de socios.
        /// </summary>
        private Club club;
        #endregion

        #region Configuración de escenarios de pruebas
        /// <summary>
        /// Configuración de escenario de pruebas no. 0.
        /// </summary>
        public void ConfiguracionPrueba0()
        {
            club = new Club();
            socio = new Socio("1", "nombre1");
        }

        /// <summary>
        /// Configuración de escenarios de prueba no. 1.
        /// </summary>
        public void ConfiguracionPrueba1()
        {
            club = new Club();
            socio = new Socio("2", "nombre2");
        }
        #endregion

        #region Métodos de prueba
        /// <summary>
        /// Prueba la afiliación y existencia de un socio.
        /// </summary>
        [TestMethod]
        public void AfiliarSocioExisteTest()
        {
            ConfiguracionPrueba0();

            try
            {
                Socio otroSocio = new Socio("3", "nombre3");
                club.AfiliarSocio(socio);
                club.AfiliarSocio(socio);

                Assert.Fail("El socio debe estar repetido.");
            }
            catch (SocioExisteException see)
            {

            }
        }

        /// <summary>
        /// Prueba la búsqueda de un socio.
        /// </summary>
        [TestMethod]
        public void BuscarSocioTest()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(new Socio("2", "nombre2"));
            }
            catch (SocioExisteException see)
            {
                Console.WriteLine(see.StackTrace);
            }

            Socio socio2 = club.BuscarSocio("2");

            Assert.AreEqual(socio.Nombre, socio2.Nombre);
        }

        /// <summary>
        /// Prueba la obtención de autorizados de un socio.
        /// </summary>
        [TestMethod]
        public void ObtenerAutorizadosSocio1Test()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(socio);

                club.AgregarAutorizadoSocio(socio, "nombreAutorizado1");
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado2");
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado3");

                ArrayList autorizados = club.ObtenerAutorizadosSocio(socio.Cedula);

                if (autorizados.Count < 4)
                {
                    Assert.Fail("No agregó a todos los autorizados.");
                }

                for (int numeroAutorizado = 1; numeroAutorizado < autorizados.Count; ++numeroAutorizado)
                {
                    String nombreAutorizado = (String)autorizados[numeroAutorizado];
                    Assert.AreEqual(nombreAutorizado, String.Format("nombreAutorizado{0}", numeroAutorizado));
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Prueba la obtención de autorizados de un socio.
        /// </summary>
        [TestMethod]
        public void ObtenerAutorizadosSocio2Test()
        {
            ConfiguracionPrueba1();

            // Al intentar agregar un nuevo autorizado a un socio inexistente:
            try
            {
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado1");

                Assert.Fail("Debería lanzar la excepción de no encontrar el socio.");
            }
            catch (SocioExisteException see)
            {
                // Aquí se debe tratar la excepción...
            }
        }

        /// <summary>
        /// Prueba la agrega de un autorizado.
        /// </summary>
        [TestMethod]
        public void AgregarAutorizado1Test()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(socio);

                int numeroAutorizadosAntes = club.ObtenerAutorizadosSocio(socio.Cedula).Count;
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado");
                int numeroAutorizadosDespues = club.ObtenerAutorizadosSocio(socio.Cedula).Count;

                Assert.AreEqual(numeroAutorizadosAntes + 1, numeroAutorizadosDespues, "La cantidad de autorizados debe haber incrementado.");
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Prueba la agregación de un autorizado.
        /// </summary>
        [TestMethod]
        public void AgregarAutorizado2Test()
        {
            ConfiguracionPrueba1();

            // Cuando el socio no existe...
            try
            {
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado");
                Assert.Fail("El socio no existe en el club.");
            }
            catch (Exception e)
            {
                // Debe lanzar la excepción...
            }

            try
            {
                club.AfiliarSocio(socio);
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado");
            }
            catch(AutorizadoExisteException aee)
            {
                Assert.Fail(String.Format("Debería poder agregar el socio: {0}", aee.Message));
            }

            // Cuando intenta agregar a un autorizado con el mismo nombre del socio...
            try
            {
                club.AgregarAutorizadoSocio(socio, socio.Nombre);
                Assert.Fail("Debería lanzar excepción de no poder agregar un autorizado con el mismo nombre de socio.");
            }
            catch(Exception aee)
            {
                // Debe lanzar la excepción...
            }

            // Cuando intenta agregar a un autorizado que ya existía...
            try
            {
                club.AgregarAutorizadoSocio(socio, "nombreAutorizado");
                Assert.Fail("Debería lanzar excepción de no poder agregar un autorizado ya existente en la lista.");
            }
            catch(AutorizadoExisteException aee)
            {
                // Debe lanzar la excepción...
            }
        }

        /// <summary>
        /// Prueba el registro de un consumo.
        /// </summary>
        [TestMethod]
        public void RegistrarConsumo1Test()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(socio);
                club.AgregarAutorizadoSocio(socio, "A");
            }
            catch(Exception e)
            {
                Assert.Fail(String.Format("Debería poder agregar el socio: {0}", e.Message));
            }

            try
            {
                int numeroFacturasAntes = club.ObtenerFacturasSocio(socio.Cedula).Count;
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto", 1000);
                int numeroFacturasDespues = club.ObtenerFacturasSocio(socio.Cedula).Count;

                Assert.AreEqual(numeroFacturasAntes + 1, numeroFacturasDespues, "El número de facturas debió incrementar en una unidad.");
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Prueba el registro de un consumo.
        /// </summary>
        [TestMethod]
        public void RegistrarConsumo2Test()
        {
            ConfiguracionPrueba1();

            // Cuando el socio no existe...
            try
            {
                club.RegistrarConsumo(socio.Cedula, "nombreAutorizado", "Concepto", 1000);
                Assert.Fail("El socio no existe en el club.");
            }
            catch(Exception e)
            {
                // Debe lanzar la excepción...
            }
        }

        /// <summary>
        /// Prueba la obtención de facturas.
        /// </summary>
        [TestMethod]
        public void ObtenerFacturas1Test()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(socio);
                club.AgregarAutorizadoSocio(socio, "A");

                club.RegistrarConsumo(socio.Cedula, "A", "Concepto1", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto2", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto3", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto4", 1000);

                ArrayList facturas = club.ObtenerFacturasSocio(socio.Cedula);

                for(int numeroFactura = 0; numeroFactura < facturas.Count; ++numeroFactura)
                {
                    Factura factura = (Factura)facturas[numeroFactura];

                    Assert.AreEqual("A", factura.Nombre, "El nombre del cliente de la factura no es correcto.");
                    Assert.AreEqual(String.Format("Concepto{0}", (numeroFactura + 1)), factura.Concepto, "El concepto de la factura no es correcto.");
                    Assert.AreEqual((double)1000, (double)factura.Valor, 0.01, "El valor de la factura no es correcto.");
                }
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Prueba la obtención de facturas.
        /// </summary>
        [TestMethod]
        public void ObtenerFacturas2Test()
        {
            ConfiguracionPrueba1();

            // Cuando el socio no existe...
            try
            {
                club.ObtenerFacturasSocio(socio.Cedula);
                Assert.Fail("El socio no existe en el club.");
            }
            catch(Exception e)
            {
                // Debe lanzar la excepción...
            }
        }

        /// <summary>
        /// Prueba el pago de una factura.
        /// </summary>
        [TestMethod]
        public void PagarFacturaSocio1Test()
        {
            ConfiguracionPrueba1();

            try
            {
                club.AfiliarSocio(socio);
                club.AgregarAutorizadoSocio(socio, "A");

                club.RegistrarConsumo(socio.Cedula, "A", "Concepto1", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto2", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto3", 1000);
                club.RegistrarConsumo(socio.Cedula, "A", "Concepto4", 1000);

                int facturasSinPagarAntes = club.ObtenerFacturasSocio(socio.Cedula).Count;
                club.PagarFactura(socio.Cedula, 0);
                int facturasSinPagarDespues = club.ObtenerFacturasSocio(socio.Cedula).Count;

                Assert.AreEqual(facturasSinPagarAntes - 1, facturasSinPagarDespues, "El número de facturas debió disminuir.");
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Prueba el pago de una factura.
        /// </summary>
        [TestMethod]
        public void PagarFacturaSocio2Test()
        {
            // Cuando el socio no existe...
            try
            {
                club.PagarFactura(socio.Cedula, 0);
                Assert.Fail("El socio no eiste en el club.");
            }
            catch(Exception e)
            {
                // Debe lanzar la excepción...
            }
        }
        #endregion
    }
}
