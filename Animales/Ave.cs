using System;

public abstract class Ave: Animal
{
  public string Alas { get; set; }

  public void Volar()
  {
    Console.WriteLine("Vuelan");
  }
}