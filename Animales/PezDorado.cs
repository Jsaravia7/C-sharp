using System;

public class PezDorado:Pez
{
    public bool Esdomestico { get; set; }

    public PezDorado()
    {
        Esdomestico = Esdomestico;
    }
     public PezDorado(bool esdomestico) 
    {
        Esdomestico = esdomestico;
    }
    public void genero()
    {
        Console.WriteLine("Es un Pez");
    }
     public void Burbujas()
    {
        Console.WriteLine("No hace sonidos, solo burbujas");
    }
}