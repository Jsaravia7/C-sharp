using System;

public class Zancudo: Insecto 

{
    public bool Esdomestico { get; set; }
    
    public Zancudo() 
    {
        Esdomestico = false;
    }
    public void genero()
    {
        Console.WriteLine("Es un Insecto");
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