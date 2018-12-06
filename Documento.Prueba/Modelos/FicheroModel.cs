using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Documento.Prueba.Modelos
{
    /// <summary>
    /// Modelo para crear un Fichero. La propiedad FicheroExtension es utilizada para especificar que el fichero debe ser un "txt".
    /// </summary>
    public class FicheroModel
    {
        public string FicheroNombre { get; set; }
        public string FicheroExtension { get; set; }
    }
}
