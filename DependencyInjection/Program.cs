

var notificationService = new NotificationService();
notificationService.Notify();


class NotificationService
{
    public void Notify()
    {
        var emailService = new EmailService();
        emailService.SendMessage("Nachricht");
    }

    public void NotifyAll()
    {
        var emailService = new EmailService();
        emailService.SendMessage("Nachricht");
    }
}

class EmailService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("E-Mail: " + message);
    }
}

class TelegramService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Telegram: " + message);
    }
}