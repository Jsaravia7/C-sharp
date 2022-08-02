using System;

public class Zancudo: Insecto 

{
    public bool Esdomestico { get; set; }
    
    public Zancudo() 
    {
        Esdomestico = false;
    }
    public Zancudo(bool esdomestico) 
    {
        Esdomestico = esdomestico;
    }
    public void Zumbido()
    {
        Console.WriteLine("Zumbido");
    }
}