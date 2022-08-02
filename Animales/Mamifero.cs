using System;

public abstract class Mamifero: Animal
{
  
  public string Patas { get; set; }

  public void Caminar()
  {
    Console.WriteLine("Camina con sus patas");
  }

}