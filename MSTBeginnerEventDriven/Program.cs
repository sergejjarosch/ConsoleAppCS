// See https://aka.ms/new-console-template for more information
using System.Timers;
using Timer = System.Timers.Timer;


class Program
{
    public static void Main(string[] args)
    {
        Timer myTimer = new Timer(2000);
        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer.Elapsed += MyTimer_Elapsed1;
        
        
        myTimer.Start();
        Console.WriteLine("Press enter to remove the red event.");
        Console.ReadLine();

        myTimer.Elapsed -= MyTimer_Elapsed1;
        Console.ReadLine();

    }

    private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Elapsed: {e.SignalTime}");
    }
    
    private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Elapsed: {e.SignalTime}");
    }

}