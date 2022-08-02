using System;

public abstract class Insecto: Animal
{
    public string Alas { get; set; }
    public void Alimento()
    {
        Console.WriteLine("Chupa sangre");
    }
}