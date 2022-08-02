using System;

public class Rana:Anfibios
{
    public bool Esdomestico { get; set; }

    public string Vive { get; set; }


    public Rana()
    {

        Esdomestico = false;

    }
     public Rana(bool esdomestico)
     {
        Esdomestico = esdomestico;
     }

     public void Sonido()
     {
        Console.WriteLine("croac croac");
     }
}