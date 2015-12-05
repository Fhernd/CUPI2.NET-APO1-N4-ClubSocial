// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Clase(s): `Factura`
//
// Propósito: Implementar y representar la entidad `Factura`
// del dominio.
//
// Original: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-4/club/visualizacion-codigo/factura
//
============================================================*/

using System;

namespace N4_ClubSocial.Modelo
{
    /// <summary>
    /// Clase que representa la entidad `Factura`.
    /// </summary>
    public class Factura
    {
        #region Atributos
        /// <summary>
        /// Concepto de la factura.
        /// </summary>
        private String concepto;
        /// <summary>
        /// Valor de la factura.
        /// </summary>
        private Decimal valor;
        /// <summary>
        /// Nombre de la factura.
        /// </summary>
        private String nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene y establece el concepto de la factura.
        /// </summary>
        public String Concepto
        {
            get
            {
                return concepto;
            }
            set
            {
                concepto = value;
            }
        }
        /// <summary>
        /// Obtiene y establece el valor de la factura.
        /// </summary>
        public Decimal Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        /// <summary>
        /// Obtiene y establece el nombre del cliente de la factura.
        /// </summary>
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva factura.
        /// </summary>
        /// <param name="nombre">Nombre el cliente de la factura.</param>
        /// <param name="concepto">Concepto de la factura.</param>
        /// <param name="valor">Valor de la factura.</param>
        public Factura(string nombre, string concepto, decimal valor)
        {
            this.nombre = nombre;
            this.concepto = concepto;
            this.valor = valor;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Representación textual de la factura.
        /// </summary>
        /// <returns>Cadena de caracteres que representa a una Factura.</returns>
        public override String ToString()
        {
            string factura = String.Format("Concepto: {0}\tValor: {1:C}\tNombre: {2}", this.concepto, this.valor, this.nombre);
            return factura;
        }
        #endregion
    }
}