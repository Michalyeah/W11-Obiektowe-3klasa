while (true)
{
    string Czynnosc = Console.ReadLine();

    

    if (Czynnosc.Contains("TEXT:") == true)
    {
        string text = Czynnosc.Substring(5);
        Console.WriteLine(Czynnosc);
    }
    
    if (Czynnosc == "CLEAR")
    {
        Console.Clear();
    }
    
    if (Czynnosc.Contains("SETPOS:") == true)
    {
        int Przecinek = Czynnosc.IndexOf(",");
        int SetposX = int.Parse(Czynnosc.Substring(7,Przecinek-7));
        int SetposY = int.Parse(Czynnosc.Substring(Przecinek+1));
        Console.SetCursorPosition(SetposX, SetposY);
    }

   


}