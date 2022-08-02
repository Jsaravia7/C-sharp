using System;

public abstract class Anfibios: Animal
{
  public string Patas { get; set; }

  public void Respirar()
  {
    Console.WriteLine("Respiracion Cutanea(Por la piel)");
  }
}