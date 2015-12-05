// ===++===z
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase de prueba: `SocioTest`
//
// Propósito: Probar el comportamiento y estado de objetos 
// de la clase `Socio`.
//
// Original: N/D
//
============================================================*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N4_ClubSocial.Modelo;
using System.Collections;

namespace N4_ClubSocialTest
{
    /// <summary>
    /// Clase que presenta las pruebas de la clase `Socio`.
    /// </summary>
    [TestClass]
    public class SocioTest
    {
        #region Atributos
        /// <summary>
        /// Socio del club.
        /// </summary>
        private Socio socio;
        /// <summary>
        /// Factura del socio.
        /// </summary>
        private Factura factura;
        #endregion

        #region Configuración de escenarios de prueba
        /// <summary>
        /// Configuración de escenario de pruebas no. 0.
        /// </summary>
        public void ConfiguracionPrueba0()
        {
            socio = new Socio("1", "Nombre1");
        }

        /// <summary>
        /// Configuración de escenario de pruebas no. 1.
        /// </summary>
        public void ConfiguracionPrueba1()
        {
            socio = new Socio("2", "Nombre2");
        }
        #endregion

        #region Métodos de prueba
        /// <summary>
        /// Pureba la agregación de un autorizado.
        /// </summary>
        [TestMethod]
        public void AgregarAutorizadoTest()
        {
            ConfiguracionPrueba0();
            String nombre = "Nombre2";
            bool existe = false;

            try
            {
                socio.AgregarAutorizado(nombre);
                ArrayList autorizados = socio.Autorizados;

                for(int numeroAutorizado = 0; numeroAutorizado < autorizados.Count; ++numeroAutorizado)
                {
                    String autorizado = (string)autorizados[numeroAutorizado];

                    if(autorizado.Equals(nombre))
                    {
                        existe = true;
                        break;
                    }
                }

                Assert.AreEqual(true, existe);
            }
            catch(Exception e)
            {
                Assert.Fail(String.Format("Falla: {0}", e.Message));
            }
        }

        /// <summary>
        /// Pureba de la agregación de un autorizado con el mismo nombre del socio.
        /// </summary>
        [TestMethod]
        public void AgregarAutorizadoIgualSocioTest()
        {
            ConfiguracionPrueba1();
            String nombre = "Nombre2";

            try
            {
                socio.AgregarAutorizado(nombre);
                Assert.Fail("El socio es el mismo autorizado.");
            }
            catch(Exception e)
            {
                Assert.IsTrue(true, "Control de duplicados correcta.");
            }
        }

        /// <summary>
        /// Prueba la eliminación de un autorizado.
        /// </summary>
        [TestMethod]
        public void EliminarAutorizadoTest()
        {
            ConfiguracionPrueba0();
            String nombre = "Nombre2";

            try
            {
                socio.AgregarAutorizado(nombre);
                ArrayList autorizadosAntes = socio.Autorizados;

                Assert.AreEqual(1, autorizadosAntes.Count);

                socio.EliminarAutorizado(nombre);

                ArrayList autorizadosDespues = socio.Autorizados;

                Assert.AreEqual(0, autorizadosDespues.Count);
            }
            catch(Exception e)
            {
                Assert.Fail(String.Format("Falla: {0}", e.Message));
            }
        }

        /// <summary>
        /// Prueba el registro de facturas.
        /// </summary>
        [TestMethod]
        public void RegistroFacturasTest()
        {
            ConfiguracionPrueba1();
            string nombre = "Nombre";
            string concepto = "Concepto";
            decimal valor = 1.0M;
            socio.RegistrarConsumo(nombre, concepto, valor);
            ArrayList facturas = socio.Facturas;

            Assert.AreEqual(1, facturas.Count);
        }

        /// <summary>
        /// Prueba la eliminación de facturas.
        /// </summary>
        [TestMethod]
        public void EliminarFacturasTest()
        {
            ConfiguracionPrueba1();
            string nombre = "Nombre";
            string concepto = "Concepto";
            decimal valor = 1.0M;
            socio.RegistrarConsumo(nombre, concepto, valor);
            ArrayList facturas = socio.Facturas;

            Assert.AreEqual(1, facturas.Count);

            socio.PagarFactura(0);
            ArrayList nuevasFacturas = socio.Facturas;
            Assert.AreEqual(0, nuevasFacturas.Count);
        }

        /// <summary>
        /// Prueba la agregación de facturas.
        /// </summary>
        [TestMethod]
        public void AgregacionFacturasTest()
        {
            ConfiguracionPrueba1();
            string nombre = "Nombre";
            string concepto = "Concepto";
            decimal valor = 1.0M;
            bool existe = false;

            socio.RegistrarConsumo(nombre, concepto, valor);
            ArrayList facturas = socio.Facturas;

            for (int numeroFactura = 0; numeroFactura < facturas.Count; ++numeroFactura)
            {
                factura = (Factura)facturas[numeroFactura];

                if (factura.Concepto.Equals(concepto))
                {
                    existe = true;
                    break;
                }
            }

            Assert.AreEqual(true, existe);
        }
        #endregion
    }
}
