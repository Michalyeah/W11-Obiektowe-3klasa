


try
{
    Wiek wiek = new Wiek();

    Console.WriteLine("Podaj wiek:");
    int podajwiek = Convert.ToInt32(Console.ReadLine());

    wiek.SprawdzWiek(podajwiek);
}
catch (MojWlasnyWyjatek ex)
{
    Console.WriteLine( ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Ale wpisz istoto/sztuczno istoto cyfre lub liczbe a nie psujesz i znaki (nie cyfry) wpisujesz(rzymskie liczby nie będą brane pod uwage[i mean nie będą przerabiane przez kod aby zrozumieć że to liczba{i mean ja nie filozof mówie że nie działa to nie działa ENTER}]), ablo jeśli nie wpisałeś wpisz istoto/sztuczno istoto a nie marnujesz czas");
}

class MojWlasnyWyjatek : ApplicationException
{
    public MojWlasnyWyjatek(string text) : base(text)
    {

    }
}
class Wiek
{
    int wiek = 0;

    public void SprawdzWiek(int wiek)
    {
        this.wiek = wiek;

        if (this.wiek < 18)

            throw (new MojWlasnyWyjatek("Jesteś niepełnoletni, zostaw tą flaszke i fajki"));
        else
            Console.WriteLine("No jestes pełnoletni");
    }
}