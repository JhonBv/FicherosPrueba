using Castle.Windsor;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Documento.Prueba
{
    /// <summary>
    /// Esta clase es la configuracion de Castle Windsor para resolucion de servicios
    /// tambien conocido como Inyeccion de dependencias.
    /// </summary>
    public class ResolucionServicios : IServiceProvider
    {
        private static WindsorContainer container;

        public ResolucionServicios(IServiceCollection services)
        {
            container = new WindsorContainer();
            RegisterComponents(container, services);
        }


        public object GetService(Type serviceType)
        {
            return container.Resolve(serviceType);
        }
    }
}
