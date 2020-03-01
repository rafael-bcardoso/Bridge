using System;

namespace Bridge
{
    public class SMS : INotification
    {
        public override void Send()
        {
            Console.WriteLine("Send SMS");
        }
    }
}
