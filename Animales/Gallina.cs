using System;

public class Gallina: Ave
{
    public bool Esdomestico { get; set; }

    public Gallina()
    {
        Esdomestico = true;
    }

    public Gallina(bool esdomestico)
    {
        Esdomestico = esdomestico;
    }
     public void Kikikear()

    {
        Console.WriteLine("Kikiriki");
    }
}