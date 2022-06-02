using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNasa
{
    public sealed class FotoSingleton
    {
        public FotoDia fotoSeleccionada { get; set; }
        private FotoSingleton() { } // constructor privado del singleton

        private static FotoSingleton instanciaUnica; // una instancia estatica de FotoSignleton

        public static FotoSingleton GetInstancia()
        {
            if (instanciaUnica == null)
            {
                instanciaUnica = new FotoSingleton();
            }
            return instanciaUnica;
        }

        public static implicit operator FotoSingleton(FotoDia v)
        {
            throw new NotImplementedException();
        }
    }
}
