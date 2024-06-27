class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string content =
                File.ReadAllText(
                    @"/Users/sergejjarosch/Desktop/C#/projects/ConsoleApp1/MSTBeginnerHandlingExceptions/Example.txt");
            Console.WriteLine(content);

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Ein problem ist aufgetretten!");
            Console.WriteLine("Überprüfen Sie bitte ob Dateiname korekt geschrieben ist." +
                              "Zum Beispiel: Example.txt");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Ein problem ist aufgetretten!");
            Console.WriteLine("Überprüfen Sie ob der Pfad Korrekt ist.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Da ist ein Problem!!!");
            Console.WriteLine(ex.Message);

        }
        finally
        {
            // Code to finalize
            //Setting objects to null
            // Closing database connections
            Console.WriteLine("Programm wird beendet...");
        }
        Console.ReadLine();


    }

}