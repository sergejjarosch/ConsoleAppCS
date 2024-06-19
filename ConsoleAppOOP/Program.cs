namespace ConsoleAppOOP;

/*
 * Has a: ist eine Beziehung zwischen zwei Klassen, bei der eine Klasse eine Instanz einer anderen Klasse enthält.
 * Diese Beziehung wird auch als Kompositions- oder Aggregationsbeziehung bezeichnet. Es bedeutet,
 * dass ein Objekt einer Klasse ein Attribut oder eine Eigenschaft hat, das ein Objekt einer anderen Klasse ist.
 */

class Program
{
    static void Main(string[] args)
    {
        Performer worker1 = new Performer("Benjamin");
        Performer worker2 = new Performer("Angello");

        Task[] tasks =
        {
            new Task(worker1, "Design erstellen"),
            new Task(worker2, "Texte schreiben")
        };
        Board schedule = new Board(tasks);
        schedule.ShowAllTasks();
    }
}

class Performer
{
    public string Name;

    public Performer(string name)
    {
        Name = name;
    }
}

class Board
{
    public Task[] Tasks;

    public Board(Task[] tasks)
    {
        Tasks = tasks;
    }

    public void ShowAllTasks()
    {
        for (int i = 0; i < Tasks.Length; i++)
        {
            Tasks[i].ShowInfo();
        }
    }
}

class Task
{
    public Performer Worker;
    public string Description;

    public Task(Performer worker, string description)
    {
        Worker = worker;
        Description = description;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Verantwortlicher: {Worker.Name}\nAufgabe: {Description}\n");
    }
}