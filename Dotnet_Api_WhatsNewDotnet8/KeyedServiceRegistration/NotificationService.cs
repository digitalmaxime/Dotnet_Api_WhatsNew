namespace KeyedServiceRegistration;

public interface INotificationService
{
    public string SendNotification(string msg);
}

public class MailNotificationService : INotificationService
{
    public string SendNotification(string msg)
    {
        Console.WriteLine("Mail notification - " + msg);
        return "Mail";
    }
}

public class PhoneNotificationService : INotificationService
{
    public string SendNotification(string msg)
    {
        Console.WriteLine("Phone notification - " + msg);
        return "Phone";
    }
}

public class PushNotificationService : INotificationService
{
    public string SendNotification(string msg)
    {
        Console.WriteLine("Push notification - " + msg);
        return "Push";
    }
}

