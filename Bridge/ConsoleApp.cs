namespace Bridge
{
    public class ConsoleApp : Component
    {

        public override void SendData()
        {
            Notification.Send();
        }
    }
}
