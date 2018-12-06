using System.IO;
using NUnit.Framework;

namespace Documento.Prueba.Tests
{
    /// <summary>
    /// Esta clase se encarga de asegurar que los archivos existan antes de ejecutar cualquier Test. de lo contrario los tests siempre fallarian.
    /// </summary>
    [TestFixture()]
    public class SetupTests
    {
        string[] _registrados;
        string[] _contenido;
        string _ficherosPath;
        

        [SetUp]
        public void SetUp()
        {
            _ficherosPath = ConfiguracionInicial.FicherosPath;
            _registrados = System.IO.File.ReadAllLines(_ficherosPath + _registrados);
            _contenido = File.ReadAllLines(_ficherosPath + _contenido);
        }

        [TearDown]
        public void TearDown()
        {
            _ficherosPath = null;
            _registrados = null;
            _contenido = null;
        }
    }
}
