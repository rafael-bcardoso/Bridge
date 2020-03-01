namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            Component webService = new WebService();

            webService.Notification = new SMS();
            webService.SendData();

            webService.Notification = new Email();
            webService.SendData();

            webService.Notification = new MessageWhatsApp();
            webService.SendData();


            Component console = new ConsoleApp();

            console.Notification = new SMS();
            console.SendData();

        }
    }
}
