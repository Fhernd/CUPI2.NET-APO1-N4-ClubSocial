// ===++===
//
//	OrtizOL - xCSw
//
//  Proyecto: Cupi2.NET
//
// ===--===
/*============================================================
//
// Excepción: `SocioExisteException`
//
// Propósito: Implementar y representar la excepción de 
// existencia de socio en el club.
//
// Original: N/D
//
============================================================*/

using System;

namespace N4_ClubSocial.Excepciones
{
    /// <summary>
    /// Clase que representa la excepción de existencia de socio.
    /// </summary>
    public class SocioExisteException : Exception
    {
        #region Constructores
        /// <summary>
        /// Crea una nueva excepción de existencia de socio.
        /// </summary>
        /// <param name="mensaje">Mensaje de excepción.</param>
        public SocioExisteException(string mensaje) : base(mensaje)
        { }
        #endregion
    }
}