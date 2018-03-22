using Autofac;
using ConsoleApplication1.Interfaces;
using ConsoleApplication1.Services;
using DelayedEcho;
using DelayedEcho.Interfaces;

namespace ConsoleApplication1.IoC
{
    public static class EchoAppRegistration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<EchoAppService>().As<IEchoAppService>();
            builder.RegisterType<ConcreteClass>().As<IConcreteClass>();

            return builder.Build();
        }
    }
}
