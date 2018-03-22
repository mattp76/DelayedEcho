using Autofac;
using ConsoleApplication1.Interfaces;
using ConsoleApplication1.IoC;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = EchoAppRegistration.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}

