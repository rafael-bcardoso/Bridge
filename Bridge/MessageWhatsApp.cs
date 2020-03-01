using System;

namespace Bridge
{
    public class MessageWhatsApp : INotification
    {
        public override void Send()
        {
            Console.WriteLine("Send message by WhatsApp");
        }
    }
}
