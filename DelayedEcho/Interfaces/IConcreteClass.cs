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
        void EchoDelayed(string message, int delaySeconds);
        void DelayedOperation(string message, int delaySeconds);
    }
}
