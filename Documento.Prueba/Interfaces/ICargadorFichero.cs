using Documento.Prueba.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Documento.Prueba.Interfaces
{
    public interface ICargadorFichero
    {
        void CargarFichero(FicheroModel fichero);
        void AlmacenarFichero(FicheroModel fichero, string path);

    }
}
