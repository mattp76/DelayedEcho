using System;

namespace DelayedEcho
{
    public class EchoEventArgs : EventArgs
    {
        public string DateTime { get; set; }
        public string Message { get; set; }
        public EchoEventArgs(string dateTime, string message)
        {
            DateTime = dateTime;
            Message = message;
        }
    }
}
