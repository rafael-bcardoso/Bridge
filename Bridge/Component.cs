namespace Bridge
{
    public abstract class Component
    {
        public abstract void SendData();
        public INotification Notification { get; set; }
    }
}
