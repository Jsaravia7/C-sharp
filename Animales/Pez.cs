using System;

public abstract class Pez:Animal
{
    public string  Aletas { get; set; }

    public void Agallas()
    {
        Console.WriteLine("Respira bajo el agua");
    }
}