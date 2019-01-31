using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace SedentryAlert
{
    public static class NotificationHelper
    {
        public static void PushNotification(string applicationName, string text)
        {
            Windows.Data.Xml.Dom.XmlDocument doc = new Windows.Data.Xml.Dom.XmlDocument();
            doc.LoadXml($"<toast><visual><binding template=\"ToastImageAndText01\"><text id = \"1\" >{text}</text></binding></visual></toast>");
            var toast = new ToastNotification(doc);
            ToastNotificationManager.CreateToastNotifier(applicationName).Show(toast);
        }
    }
}