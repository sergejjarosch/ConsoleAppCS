namespace ConsoleApp1;

public class ObjekteUndKlassen
{
    public static void Main(string[] args)
    {
        Car ferarri = new Car("Ferarri F40", 450, 1995, 320);
        
        ferarri.
    }

}

class Car
{
    public string Name { get; set; }
    public int HorsePower { get; set; }
    public int BuildData { get; set; }
    public float MaxSpeed { get; set; }

    public Car(string name, int horsePower, int buildData, float maxSpeed)
    {
        Name = name;
        HorsePower = horsePower;
        BuildData = buildData;
        MaxSpeed = maxSpeed;
    }
    
}