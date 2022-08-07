﻿using Modulo_UnidadDeportiva.Models;

namespace Modulo_UnidadDeportiva.Interfaces
{
    public interface IElementosDep
    {
        public List<Elemento> GetElementos( int SedeID, int DepID, DateTime fechaHora);
        public bool Prestar(List<int> elementos, int responsableID);  //Elemento no es un mapeo literal de la tabla.. (REVISAR)
    }
}
