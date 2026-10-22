Console.WriteLine("Podaj liczbe: ");
int a= Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj dzielnik: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = 0;
try
{
    c = a / b;
    Console.WriteLine($"Wynik: {c}");

    string text = "AHOJ";

    for(int i = 0; i <= text.Length; i++)
    {
        char znak = text[i];
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ale wypad mi z tym zerem");
   // Console.WriteLine(blad.Message);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Panie coś pan za dużo");
}
finally
{
    Console.WriteLine("Finally jestem i się wykonam zawsze");
}
Console.ReadKey();

try
{
    Godzina godzina = new Godzina();

    Console.WriteLine("Podaj godzine:");
    int podanaGodzina = Convert.ToInt32(Console.ReadLine());

    godzina.SprawdzGodzine(podanaGodzina);
}
catch(MojWlasnyWyjatek ex)
{
    Console.WriteLine("Mój włąśny wyjątek: {0}", ex.Message);
}

class MojWlasnyWyjatek : ApplicationException
{
    public MojWlasnyWyjatek(string text): base(text)
    {

    }
}
class Godzina
{
    int godzina = 0;

    public void SprawdzGodzine(int godzina)
    {
        this.godzina = godzina;

        if (this.godzina > 24)

            throw (new MojWlasnyWyjatek("Godzina nie może być większa niż 24 "));
        else
            Console.WriteLine("Poprawna godzie zes wpisał ");
    }
}