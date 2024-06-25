

// ## Use of tertiary operators and an array ##

/*
Console.WriteLine("Wähle eine Tür: 1, 2, oder 3?");
string[] variants = {"gewonnen!!!", "verloren" };

string userValue = Console.ReadLine();

string message = userValue == "1"  ? variants[0].ToUpper() : variants[1];
Console.WriteLine($"Du hast die: {userValue} gewählt und du hast {message}");
*/

// ## Format Stings ##

//string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);
//string myString = string.Format("Percentage: {0:P0}", .01); //  P0 P1 P2 <- Stellen nach dem Komma
/*
string textPath = "/Users/sergejjarosch/Desktop/C#/projects/ConsoleApp1/MSTutorialsBeginner/text.txt";
string text = File.ReadAllText(textPath);
text = text.Replace(" ", "--");
Console.WriteLine(text);
*/

// ## Date Time ##
/* 
DateTime myValue = DateTime.Now;
Console.WriteLine(myValue.ToString());              // 25.06.2024 14:52:46
Console.WriteLine(myValue.ToShortDateString());     //25.06.2024
Console.WriteLine(myValue.ToShortTimeString());     // 14:53
Console.WriteLine(myValue.ToLongDateString());      //Tuesday, 25. June 2024
Console.WriteLine(myValue.ToLongTimeString());      // 14:54:15

Console.WriteLine(myValue.AddDays(3).ToLongDateString());   // Friday, 28. June 2024
Console.WriteLine(myValue.AddDays(-30).ToLongDateString()); // Sunday, 26. May 2024
Console.WriteLine(myValue.AddHours(7).ToLongTimeString());  // 21:58:28
Console.WriteLine(myValue.Month);                           // 6


DateTime  myBirthDay = new DateTime(1991, 03, 09);
Console.WriteLine(myBirthDay.ToShortDateString());      //09.03.1991

DateTime myBirthdayParse = DateTime.Parse("09/03/1991");
Console.WriteLine(myBirthdayParse.ToShortDateString()); //09.03.1991

TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
Console.WriteLine(myAge.TotalDays); // 12162,630647571714
*/

