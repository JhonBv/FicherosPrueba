using Documento.Prueba.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Documento.Prueba.Interfaces
{
    public interface IFicheroRepositorio
    {
        void CrearFichero(FicheroModel fichero);
        void AlmacenarFichero();

        void RemoverFichero(string ficheroNombre);
    }
}
