
namespace SedentryAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationHelper.PushNotification("TestApplication", "Alert");
        }
    }
}
