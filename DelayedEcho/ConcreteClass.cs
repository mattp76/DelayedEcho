using DelayedEcho.Interfaces;
using System;
using System.Threading.Tasks;

namespace DelayedEcho
{
    public class ConcreteClass : IConcreteClass
    {
        public event EventHandler<EchoEventArgs> EchoEvent;

        protected virtual void OnRaiseProgressEvent(EchoEventArgs e)
        {
            EchoEvent.Invoke(this, e);
        }

        public async Task EchoDelayed(string message, int delaySeconds)
        {
            await Task.Run(() =>
            {
                DelayedOperation(message, delaySeconds);
            });
        }

        public async Task DelayedOperation(string message, int delaySeconds)
        {
            TimeSpan interval = TimeSpan.FromSeconds(delaySeconds);
            Task task = Task.Delay(interval);

            try
            {
                await task;
                OnRaiseProgressEvent(new EchoEventArgs(DateTime.Now, message));
            }
            catch (TaskCanceledException)
            {
                
            }
        }
    }
}
