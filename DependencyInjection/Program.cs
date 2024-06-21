

IMessageService emailService = new EmailService();

var notificationService = new NotificationService(emailService);


notificationService.Notify();


class NotificationService
{
    private readonly IMessageService _messageService;

    public NotificationService(IMessageService messageService)
    {
        _messageService = messageService;
    }
    
    public void Notify()
    {
        _messageService.SendMessage("Nachricht");
    }
    public void NotifyAll()
    {
        _messageService.SendMessage("Nachricht");
    }
}

interface IMessageService
{
    void SendMessage(string message);
}

class EmailService : IMessageService
{
    private readonly ILogger _logger;
    public EmailService(ILogger logger)
    {
        _logger = logger;
    }
    public void SendMessage(string message)
    {
        Console.WriteLine("E-Mail: " + message);
        
        _logger.Log("Nachricht wurde erfolgreich gesendet");
    }
}

class TelegramService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Telegram: " + message);
    }
}

interface ILogger
{
    void Log(string message);
}

interface IDatabase
{
    void Safe();
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class PostgresDatabsase : IDatabase
{
    public void Safe()
    {
        Console.WriteLine("Daten wurden gespeichert");
    }
}