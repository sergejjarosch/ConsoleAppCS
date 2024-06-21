// See https://aka.ms/new-console-template for more information

// Dieses Programm dient als Projekt zu Übung in C#
// hier wird eine Reihe der grundlegenden Bestandteile von C# Behandelt

/*
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine(decimalNotation + "\n" +
                    binaryNotation + "\n" +
                    hexadecimalNotation);
*/
/*
 Console.WriteLine("Wie alst bist du?");
   int age = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Dein alter ist:" + age);

   if (age >= 18)
   {
       Console.WriteLine("Du bist Volljährig");
   }
   else
   {
       Console.WriteLine("Du bist noch NICHT volljährig");
   }

 */
// Convert To...
/*
int age;
string input = "12";
age = Convert.ToUInt16(input);
Console.WriteLine(age);

float result;
int x =5, y =2;
result = Convert.ToSingle(x) / y;
Console.WriteLine(result);
*/
// Console Write...

//  ->  Console.WriteLine();
//  ->  Console.ReadKey();

// string name;
// name = Console.ReadLine();
// Console.WriteLine(name);

// Dekriment kann direct in den Klamern der while struktur sein (age --)


// Console.WriteLine("Wie oft soll ich es ausgeben?");
// int age = Convert.ToInt32(Console.ReadLine());
// 
// while (age-- > 0)
// {
//     Console.WriteLine(age + "*");
// }

// ---> continue; = eine Iteration wird ausgelassen, und vortgesetzt
// ---> break; = die Ausführung wird unterbrochen und beendet.

// Random ---
//Random rand = new Random();
//
//for (int i = 0; i < 10; i++)
//{
//    int value = rand.Next(1, 11);
//    Console.WriteLine(value);
//}


//--- List
//List<int> numbers = new List<int>();
//numbers.Add(12); // Wird am ende der Liste Hinzugefügt.
//numbers.Add(1); 
//numbers.Add(5); 
//numbers.Add(9); 
//numbers.Add(19);
//
//// IOterabel in for schleife
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//
//
//// IOterabel in foreach schleife
//
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//--- Dictionary 
// < key , Value> durch den Key kann das Value gesucht und aufgerufen werden
// Key kann auch eine Zahl sein

//Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
//countriesCapitals.Add("Deutschland", "Berlin");
//countriesCapitals.Add("Österreich", "Wien");


/*
Dictionary<string, string> countriesCapitals = new Dictionary<string, string>
{
    { "Deutschland", "Berlin" },
    { "Österreich", "Wien" },
    { "Schweiz", "Bern" }
};

//Console.WriteLine(countriesCapitals["Deutschland"]);
////Eingabe Überprüffen
//if (countriesCapitals.ContainsKey("Österreich"))
//{
//    Console.WriteLine(countriesCapitals["Österreich"]);
//}

foreach (var item in countriesCapitals)
{
    Console.WriteLine($"Land - {item.Key} Hauptstadt - {item.Value}");
}
*/

//Tärnerer Operator

/*
int zahlA;
int zahlB;

Console.WriteLine("Zum vergleichen, gib zahl A ein:");
zahlA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Zum vergleichen, gib zahl A ein:");
zahlB = Convert.ToInt32(Console.ReadLine());


string kleiner = $"Die {zahlA} ist kleiner als {zahlB}";
string groesser = $"Die {zahlA} ist Größer als {zahlB}";

string vergleich = zahlA < zahlB ? kleiner : groesser;
ausgabe(vergleich);

void ausgabe(string eingabe)
{
    Console.WriteLine(eingabe);
}
*/

