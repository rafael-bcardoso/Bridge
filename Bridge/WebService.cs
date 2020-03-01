namespace Bridge
{
    public class WebService : Component
    {

        public override void SendData()
        {
            Notification.Send();
        }
    }
}
