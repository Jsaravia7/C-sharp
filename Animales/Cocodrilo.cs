using System;

public class Cocodrilo: Reptil
{

    public bool Esdomestico { get; set; }


    public Cocodrilo()
    {
        Esdomestico = false;
    }

    public Cocodrilo(bool esdomestico)
    {
        Esdomestico = esdomestico;
    }
    public void genero()
    {
        Console.WriteLine("Es un reptil");
    }
    public void Peligroso()
    {
        Console.WriteLine("Es un animal peligroso");
    }

    public void Gruñir()
    {
        Console.WriteLine("roar roar");
    }
    
}