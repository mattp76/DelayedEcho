using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayedEcho.Interfaces
{
    public interface IConcreteClass
    {
        event EventHandler<EchoEventArgs> EchoEvent;
        Task EchoDelayed(string message, int delaySeconds);
        Task DelayedOperation(string message, int delaySeconds);
    }
}
