
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>()
        {
            new Car() { VIN = "A1", Make = "BMW", Model = "750i", Year = 2005, StickerPrice = 17_899 },
            new Car() { VIN = "A2", Make = "BMW", Model = "535i", Year = 2015, StickerPrice = 23_480 },
            new Car() { VIN = "A3", Make = "BMW", Model = "320d", Year = 2000, StickerPrice = 13_324 },
            new Car() { VIN = "B2", Make = "Audi", Model = "A4", Year = 2010, StickerPrice = 12_499 },
            new Car() { VIN = "C3", Make = "Mercedes", Model = "C300", Year = 2015, StickerPrice = 25_000 },
            new Car() { VIN = "D4", Make = "Tesla", Model = "Model S", Year = 2018, StickerPrice = 45_000 },
            new Car() { VIN = "E5", Make = "Ford", Model = "Mustang", Year = 2012, StickerPrice = 18_750 },
            new Car() { VIN = "F6", Make = "Chevrolet", Model = "Camaro", Year = 2014, StickerPrice = 20_500 },
            new Car() { VIN = "G7", Make = "Honda", Model = "Civic", Year = 2019, StickerPrice = 19_300 },
            new Car() { VIN = "H8", Make = "Toyota", Model = "Corolla", Year = 2020, StickerPrice = 22_000 },
            new Car() { VIN = "I9", Make = "Nissan", Model = "Altima", Year = 2017, StickerPrice = 16_800 },
            new Car() { VIN = "J10", Make = "Hyundai", Model = "Elantra", Year = 2013, StickerPrice = 14_200 },
            new Car() { VIN = "K11", Make = "Mazda", Model = "3", Year = 2016, StickerPrice = 15_000 }
        };
        
        // LINQ query
        /*
        var bmws = from car in myCars
            where car.Make == "BMW"
            && car.Year == 2000
            select car;
        */
        /*
        var orderCars = from car in myCars
            orderby car.Year descending
            select car;
        */
        
        // LINQ method
        var bmws = myCars.Where(c => c.Make == "BMW" && c.Year == 2000);
        // sortieren
        var orderCars = myCars.OrderByDescending(c => c.StickerPrice);
        var firstCar = myCars.First(c => c.Make == "Audi"); // Not iterable
        var firstBMW = myCars.OrderByDescending(c => c.Year).First(p => p.Make == "BMW") ; // Not iterable
        
        // PrintMethod with LINQ 
        // Console.WriteLine(myCars.TrueForAll(p => p.Year > 1999));
        myCars.ForEach(c => Console.WriteLine($"{c.Make} {c.Model}"));
        
        
        // show Method -
        // Console.WriteLine($"{firstCar.Make} {firstCar.Model}");
        // Console.WriteLine($"{firstBMW.Make} {firstBMW.Model}");
        // 
        // foreach (var car in orderCars)
        // {
        //     Console.WriteLine($" {car.Year} | {car.Make} | {car.Model} | €{car.StickerPrice}");   
        // }
    }
}

class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double StickerPrice { get; set; }
}