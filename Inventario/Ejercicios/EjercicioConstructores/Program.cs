using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
          Alumno a = new Alumno();
          a.Id = 1;
          a.Primernombre = "Juan";
          a.SegundoNombre = "Perez";

          Alumno b = new Alumno();
          b.Id = 2;
          b.Primernombre = "Maria";
          b.SegundoNombre = "Martinez";

          Alumno c =new Alumno(3);
          b.Primernombre = "Pedro";

          Console.WriteLine(a.Id);
          Console.WriteLine(b.Id);
          Console.WriteLine(c.Id);
        }
    }
}
