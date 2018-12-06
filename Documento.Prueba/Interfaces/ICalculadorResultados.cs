using System;
using Documento.Prueba.Modelos;

namespace Documento.Prueba.Interfaces
{
    public interface ICalculadorResultados
    {
        string CargarFicheros(FicheroModel registrados, FicheroModel contenido);
    }
}
