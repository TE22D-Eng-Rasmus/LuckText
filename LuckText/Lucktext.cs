Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

Console.WriteLine("Vad är din favoritmat?");
string mat = Console.ReadLine();

Console.WriteLine("Hur gammal är du");
string ålder = Console.ReadLine();

Console.WriteLine($" Hej {namn} en fågel viskade att du gillar {mat} och att du är {ålder} år gammal. ");

Console.WriteLine("Tryck ENTER för att stänga");
Console.ReadLine();