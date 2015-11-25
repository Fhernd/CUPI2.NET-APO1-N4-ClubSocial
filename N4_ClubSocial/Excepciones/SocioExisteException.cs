using System;

namespace N4_ClubSocial.Excepciones
{
    public class SocioExisteException : Exception
    {
        #region Constructores
        public SocioExisteException(string mensaje) : base(mensaje)
        { }
        #endregion
    }
}