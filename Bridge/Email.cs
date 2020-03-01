using System;

namespace Bridge
{
    public class Email : INotification
    {
        public override void Send()
        {
            Console.WriteLine("Send email");
        }
    }
}
