using System;

namespace Delegates
{
    internal class Program
    {
        // Define the delegate type
        public delegate void NotificationHandler(string message);

        // Email Notifier class
        public class EmailNotifier
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        // SMS Notifier class
        public class SMSNotifier
        {
            public void SendSms(string message)
            {
                Console.WriteLine($"SMS sent: {message}");
            }
        }

        // Push Notifier class
        public class PushNotifier
        {
            public void SendPush(string message)
            {
                Console.WriteLine($"Push sent: {message}");
            }
        }

        // Notifications Manager class
        public class NotificationsManager
        {
            // Delegate to hold notification methods
            public NotificationHandler Notify;

            // Add a notification method to the delegate
            public void AddNotificationMethod(NotificationHandler handler)
            {
                Notify += handler;
            }

            // Remove a notification method from the delegate
            public void RemoveNotificationMethod(NotificationHandler handler)
            {
                Notify -= handler;
            }

            // Send notification through the added methods
            public void SendNotification(string message)
            {
                Notify?.Invoke(message);
            }
        }

        // Display menu options
        public static void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add Email Notification");
            Console.WriteLine("2. Add SMS Notification");
            Console.WriteLine("3. Add Push Notification");
            Console.WriteLine("4. Remove Email Notification");
            Console.WriteLine("5. Remove SMS Notification");
            Console.WriteLine("6. Remove Push Notification");
            Console.WriteLine("7. Send Notification");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Select an option: ");
        }

        static void Main(string[] args)
        {
            var emailNotifier = new EmailNotifier();
            var smsNotifier = new SMSNotifier();
            var pushNotifier = new PushNotifier();

            var notificationManager = new NotificationsManager();

            while (true)
            {
                try
                {
                    ShowMenu();
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("Email notification added.");
                            break;
                        case "2":
                            notificationManager.AddNotificationMethod(smsNotifier.SendSms);
                            Console.WriteLine("SMS notification added.");
                            break;
                        case "3":
                            notificationManager.AddNotificationMethod(pushNotifier.SendPush);
                            Console.WriteLine("Push notification added.");
                            break;
                        case "4":
                            notificationManager.RemoveNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("Email notification removed.");
                            break;
                        case "5":
                            notificationManager.RemoveNotificationMethod(smsNotifier.SendSms);
                            Console.WriteLine("SMS notification removed.");
                            break;
                        case "6":
                            notificationManager.RemoveNotificationMethod(pushNotifier.SendPush);
                            Console.WriteLine("Push notification removed.");
                            break;
                        case "7":
                            Console.Write("Enter message to send: ");
                            var message = Console.ReadLine();
                            notificationManager.SendNotification(message);
                            break;
                        case "8":
                            return;
                        default:
                            Console.WriteLine("Try again.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occurred: {e.Message}");
                }
            }
        }
    }
}
