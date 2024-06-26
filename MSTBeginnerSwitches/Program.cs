class Program
{
    public static void Main(string[] args)
    {
        List<Todo> todos = new List<Todo>()
        {
            new Todo { Description = "Task 1 To do somthing...", EstimateHour = 6, Status = Status.InProgress}
        };
        Array status = Enum.GetValues(typeof(Status));

        Console.WriteLine(status.GetValue(3));
        Console.WriteLine(todos[0].Status);

        trennLinie();

    }

    public static void trennLinie()
    {
        ConsoleColor standartColor = Console.ForegroundColor;
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < 70; i++)
        {
            Console.Write("~");
        }
        Console.ForegroundColor = standartColor;

    }

}

class Todo
{
    public string Description { get; set; }
    public int EstimateHour { get; set; }
    public Status Status { get; set; }
}

class Woche
{
    private Wochentage ersterTag = Wochentage.Montag;
}

enum Status
{
    NotStarted,
    InProgress,
    OnHold,
    completed,
    Deleted
}

enum Wochentage
{
    Montag,
    Dienstag,
    Mittwoch,
    Donnerstag,
    Fraeitag,
    Samstag,
    Sonntag
}