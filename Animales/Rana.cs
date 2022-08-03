using System;

public class Rana:Anfibios
{
    public bool Esdomestico { get; set; }

    public string Vive { get; set; }


    public Rana()
    {

        Esdomestico = false;

    }
    public void genero()
    {
        Console.WriteLine("Es un Anfibio");
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