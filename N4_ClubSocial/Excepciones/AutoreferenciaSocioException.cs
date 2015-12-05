// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Excepción: `AutoreferenciaSocioException`
//
// Propósito: Implementar y representar la excepción de 
// autoreferencia de socio en el club.
//
// Original: N/D
//
============================================================*/

using System;

namespace N4_ClubSocial.Excepciones
{
    /// <summary>
    /// Clase que representa la excepción de autoferencia de socio.
    /// </summary>
    public class AutoreferenciaSocioException : Exception
    {
        #region Constructores
        /// <summary>
        /// Crea una nueva excepción de autoreferencia de socio.
        /// </summary>
        /// <param name="mensaje"></param>
        public AutoreferenciaSocioException(string mensaje) : base (mensaje)
        { }
        #endregion
    }
}