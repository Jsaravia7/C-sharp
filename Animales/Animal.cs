using System;

public abstract class Animal
{
  public string Nombre { get; set; }

  public void comer()
  {
     Console.WriteLine("Come...");

  }
      public void Jugar()

    {

        Console.WriteLine("Jugar");

    }

    public void Triste()

    {

        Console.WriteLine("Triste");

    }

    public void Inquieto()

    {

        Console.WriteLine("Inquieto");

    }

    public void Bañar()

    {

        Console.WriteLine("Bañar");

    }

    public void Secar()

    {

        Console.WriteLine("Secar");

    }

    public void Atrapar()

    {

        Console.WriteLine("Atrapando insectos");

    }

}