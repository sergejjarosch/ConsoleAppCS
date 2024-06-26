using System.Drawing;
using System.Xml.Schema;

namespace MSTutorialsBeginner;

public class Oop
{
    public static void Main(string[] args)
    {
        
    }
    
}

class car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public car() 
    {
        Make = "Others";
    }

    public car(string make, string model, int year, string color)
    {
        Make = make;
        Model = make;
        Year = year;
        Color = color;
    }
}

