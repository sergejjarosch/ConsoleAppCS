

using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Car car1 = new Car();
        car1.Make = "Oldsmobile";
        car1.Model = "Cutlas Suprime";
        car1.VIN = "A1";

        Car car2 = new Car();
        car2.Make = "Geo";
        car2.Model = "Prism";
        car2.VIN = "B2";
        */
        /*
        Book b1 = new Book();
        b1.Author = "Robert Tabor";
        b1.Title = "Microsoft .NET XML WEB Services";
        b1.ISBN = "0-000-00000-0";
        */

        // ArayList are dynamically sized,
        //cool features sorting, remove items...
        /*
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(car1);
        myArrayList.Add(car2);
        myArrayList.Add(b1);
        myArrayList.Remove(b1);

        foreach (var item in myArrayList)
        {
            Console.WriteLine(item.Make);
        }
        */

        //List<T> 
        /*
        List<Car> myList = new List<Car>();
        myList.Add(car1);
        myList.Add(car2);
        // myList.Add(b1);

        foreach (var car in myList)
        {
            Console.WriteLine(car.Model);
        }
        */

        /*
        // Dictionary < tKey, TValue >
        Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

        myDictionary.Add(car1.VIN, car1);
        myDictionary.Add(car2.VIN, car2);

        Console.WriteLine(myDictionary["B2"].Make);
        */

        // Object initializer
        // No need for a Constructor
        // Car car1 = new Car() { Make = "BMW", Model = "750i", VIN = "C3" };
        // Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

        // Collection initializer

        List<Car> myList = new List<Car>()
        {
            new Car { Make = "Oldsmobile", Model = "Cutlas Suprime", VIN = "E5" },
            new Car { Make = "Nissan", Model = "Altima", VIN = "F6" }
        };

        
        
    }
}

class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
}