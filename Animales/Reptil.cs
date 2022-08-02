using System;

public abstract class Reptil: Animal
{
    public string Patas { get; set; }

    public void Sangre()
    {
        Console.WriteLine("Tiene sangre fria");
    }
}