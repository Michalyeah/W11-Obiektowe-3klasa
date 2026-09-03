
//Wyświetlanie komunikatu
Console.Write("K" + "\r\n");
Console.Write("A" + Environment.NewLine);
Console.Write("W" + Convert.ToChar(13) + Convert.ToChar(10));
Console.WriteLine("A");
Console.WriteLine("Hello, World!");

//Pobieranie danych z konsoli

int t = Console.Read();
string text= Console.ReadLine();
Console.WriteLine(text);


ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine("KLINKAJ ENETROWIEC");
while (Console.ReadKey().Key != ConsoleKey.Enter) { } ;
Console.WriteLine("Kliknięto Enter");

//Kolory

Console.ForegroundColor = ConsoleColor.Magenta;//Kolor tekstu
Console.BackgroundColor = ConsoleColor.Cyan;//Kolor tła
Console.WriteLine("kOLOR");

Console.ResetColor();//Resecik koloru

//Zarządzanie oknem i buforem

Console.Clear();// Czyszczenie konsoli
Console.Title = "KoNsOlA AdMiNiStRaCyJnA"; //Nazwa konsoli

//Console.SetWindowSize(128, 128); // Rozmiar okna konsoli wyrażony w liczbie znaków
//Console.SetBufferSize(128, 128); //Rozmiar buffora konsoli, czyli obszar po którym można przewijać ekran


//Dźwieki
Console.Beep();
Console.Beep(100, 1000);

//Kontrola Kursora
Console.CursorVisible = true; //Pokaż/ukryj kursor
Console.SetCursorPosition(0, 0); // Ustawienie położenia kursor



