using System;

namespace DelayedEcho
{
    public class EchoEventArgs : EventArgs
    {
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public EchoEventArgs(DateTime dateTime, string message)
        {
            DateTime = dateTime;
            Message = message;
        }
    }
}
