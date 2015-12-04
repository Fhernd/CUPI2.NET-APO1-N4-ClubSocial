using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N4_ClubSocial.Modelo;
using System.Collections;

namespace N4_ClubSocialTest
{
    [TestClass]
    public class SocioTest
    {
        #region Atributos
        private Socio socio;
        private Factura factura;
        #endregion

        #region Configuración de escenarios de prueba
        public void ConfiguracionPrueba0()
        {
            socio = new Socio("1", "Nombre1");
        }

        public void ConfiguracionPrueba1()
        {
            socio = new Socio("2", "Nombre2");
        }
        #endregion

        #region Métodos de prueba
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
