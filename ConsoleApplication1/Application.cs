using ConsoleApplication1.Interfaces;
using System;
using static ConsoleApplication1.Program;

namespace ConsoleApplication1
{
    public class Application : IApplication
    {
        private readonly IEchoAppService _service;
        public Application(IEchoAppService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.WriteToTheApp();
        }
    }
}
