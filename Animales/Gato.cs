using System;

public class Gato: Mamifero
{
    public string Pelaje { get; set; }

    public bool Esdomestico { get; set; }

public Gato()
    {
        Esdomestico = true;
    }

    public Gato(bool esdomestico) // <- Polimorfismo

    {

        Esdomestico = esdomestico;

    }
    public void Maullar()
    {
        Console.WriteLine("Miau miau");
    }
}