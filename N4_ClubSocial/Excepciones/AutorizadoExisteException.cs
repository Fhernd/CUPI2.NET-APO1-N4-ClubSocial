// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Excepción: `AutorizadoExsiteException`
//
// Propósito: Implementar y representar la excepción de 
// existencia de autorizado para un socio.
//
// Original: N/D
//
============================================================*/

using System;

namespace N4_ClubSocial.Excepciones
{
    /// <summary>
    /// Clase que representa la excepción de existencia de autorizado.
    /// </summary>
    public class AutorizadoExisteException : Exception
    {
        #region Constructores
        /// <summary>
        /// Crea una nueva exepción de existencia de autorizado.
        /// </summary>
        /// <param name="mensaje">Mensaje de excepción.</param>
        public AutorizadoExisteException(string mensaje) : base(mensaje)
        { }
        #endregion
    }
}