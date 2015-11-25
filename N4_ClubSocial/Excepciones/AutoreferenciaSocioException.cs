using System;

namespace N4_ClubSocial.Excepciones
{
    public class AutoreferenciaSocioException : Exception
    {
        #region Constructores
        public AutoreferenciaSocioException(string mensaje) : base (mensaje)
        { }
        #endregion
    }
}