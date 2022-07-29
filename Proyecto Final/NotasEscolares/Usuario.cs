using System;
using System.Collections.Generic;
public class Usuario: Persona // herencia // 
{
    public string Profesion { get; set; }

    public int Codigo { get; set; }

   public Usuario(int codigo, string profesion,string nombre, string apellido)
   {
     Codigo = codigo;
     Profesion = profesion;
     Nombre = nombre;
     Apellido = apellido;
   }
}