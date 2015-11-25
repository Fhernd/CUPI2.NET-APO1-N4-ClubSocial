using System;

namespace N4_ClubSocial.Modelo
{
    public class Factura
    {
        #region Atributos
        private String concepto;
        private Decimal valor;
        private String nombre;
        #endregion

        #region Propiedades
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
        public Factura(string nombre, string concepto, decimal valor)
        {
            this.nombre = nombre;
            this.concepto = concepto;
            this.valor = valor;
        }
        #endregion

        #region Métodos
        public override String ToString()
        {
            string factura = String.Format("Concepto: {0}\tValor: {1:C}\tNombre: {2}", this.concepto, this.valor, this.nombre);
            return factura;
        }
        #endregion
    }
}