

// ## Use of tertiary operators and an array  

Console.WriteLine("Wähle eine Tür: 1, 2, oder 3?");
string[] variants = {"gewonnen!!!", "verloren" };

string userValue = Console.ReadLine();

string message = (userValue == "1" ) ? variants[0].ToUpper() : variants[1];
Console.WriteLine($"Du hast die: {userValue} gewählt und du hast {message}");