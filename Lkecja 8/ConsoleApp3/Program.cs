class Skrzynie
{


    int odczytSkrzyni = 1;


    enum typSkrzyni
    {
        Manual = 1,
        Automat = 2
    }
    void SprawdzSkrzynie()
    {
        if (odczytSkrzyni == (int)typSkrzyni.Manual)
        {
            Console.WriteLine("Skrzynia manualna");
        }
        else if (odczytSkrzyni == (int)typSkrzyni.Automat)
        {
            Console.WriteLine("Skrzynia automatyczna");
        }

    }
}