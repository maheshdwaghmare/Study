using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace DepedencyInjection
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer container = new UnityContainer();
        public static void Register<I, T>() where T : I
        {   
            container.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        public static void Register<T>()
        {
            container.RegisterType<T>();
        }

        //public static void InjectStub<I>(I instance)
        //{
        //    container.RegisterInstance(instance, new ContainerControlledLifetimeManager());
        //}
        public static T Retrieve<T>()
        {
            return container.Resolve<T>();
        }

        public static void AddExtension<T>() where T : UnityContainerExtension
        {
            container.AddNewExtension<T>();
        }
    }
}
