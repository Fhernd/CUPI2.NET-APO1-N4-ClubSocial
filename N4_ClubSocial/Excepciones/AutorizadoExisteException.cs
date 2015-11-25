using System;

namespace N4_ClubSocial.Excepciones
{
    public class AutorizadoExisteException : Exception
    {
        #region Constructores
        public AutorizadoExisteException(string mensaje) : base(mensaje)
        { }
        #endregion
    }
}