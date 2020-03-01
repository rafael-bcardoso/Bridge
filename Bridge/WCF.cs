namespace Bridge
{
    public class WCF : Component
    {
        
        public override void SendData()
        {
            Notification.Send();
        }
    }
}
