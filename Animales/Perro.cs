using System;

public class Perro: Mamifero
{
    public bool Esdomestico { get; set; }


    public Perro()
    {
        Esdomestico = true;
    }

    public Perro(bool esdomestico) // <- Polimorfismo

    {

        Esdomestico = esdomestico;

    }
    public void genero()
    {
        Console.WriteLine("Es un Mamifero");
    }
      public void Ladrar()
    {
        Console.WriteLine("Gua gua gua");
    }
}