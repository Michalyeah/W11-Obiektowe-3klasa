using System.Diagnostics;

Console.WriteLine("Hello, World!");
/*
int  b ;

//DEBUGGER
for(int i = 0; i < 10; i++)
{
    b = i;
    Debug.WriteLine(b);

}

//Debugger z Breakpointem 

for (int i = 0; i < 10; i++)
{
    b = i;

}

//Breakpoint when changed

for (int i = 0; i < 10; i++)
{
    b = i;

}
//Breakpoint one hit
int x = 0;
for (int i = 0; i < 10; i++)
{
    x++;
    if (x == 6)
    {
        x = 0;
    }
    b = i;

}

//F10 - STEP OVER bez wchodzenia do funkcji/metody
//F11 - STEP INTO wejdz do funkcji/metody
//SHIFT + F11 - STEP OUT wyjdź z aktualnej metody
/*while (true)
{
    int a = 0;
    int c = 0;

    a++;
    c++;

    Console.WriteLine(DodajDwieLiczby(a, c));

};

int DodajDwieLiczby(int a, int b)
{
    return (a + b);
}


*/


int[] tablica = new int[11];

for(int i = 0; i <= 10; i++)
{
    tablica[i] = i;
}