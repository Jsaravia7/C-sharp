using System;
using System.Collections.Generic;
public class Notas
{
    public List<Usuario> ListaUsuario { get; set; }

    public List<Estudiantes> ListaEstudiantes { get; set; }

    public List<Asignatura> ListaAsignatura { get; set; }

    public int NotaFinal { get; set; }

    public Notas()
    {
        ListaUsuario = new List<Usuario>();
        CargarUsuario();

        ListaEstudiantes = new List<Estudiantes>();
        CargarEstudiantes();

        ListaAsignatura = new List<Asignatura>();
        CargarAsignaturas();


    }
    private void CargarUsuario()
    {
      Usuario u1 = new Usuario(501,"Ingeniero","Bily","Fernandez");
      ListaUsuario.Add(u1);

      Usuario u2 = new Usuario(502,"Ingeniero","Jorge","Saravia");
      ListaUsuario.Add(u2);

      Usuario u3 = new Usuario(502,"Ingeniera","Alejandra","Pagoada");
      ListaUsuario.Add(u3);
    }

    private void CargarEstudiantes()
    {
      Estudiantes e1 = new Estudiantes(001,"Benito","Juarez");
      ListaEstudiantes.Add(e1);

      Estudiantes e2 = new Estudiantes(002,"Josue","Almendarez");
      ListaEstudiantes.Add(e2);

      Estudiantes e3 = new Estudiantes(003,"Sofia","Zelaya");
      ListaEstudiantes.Add(e3);

      Estudiantes e4 = new Estudiantes(004,"Nathaly","Puerto");
      ListaEstudiantes.Add(e4);
    }

    private void CargarAsignaturas()
    {
      Asignatura a1 = new Asignatura("EG011","Español");
      ListaAsignatura.Add(a1);
      
      Asignatura a2 = new Asignatura("IN101","Ingles");
      ListaAsignatura.Add(a2);

      Asignatura a3 = new Asignatura("EF102","Educacion Fisica");
      ListaAsignatura.Add(a3);

      Asignatura a4 = new Asignatura("CS230","Ciencias Sociales");
      ListaAsignatura.Add(a4);

      Asignatura a5 = new Asignatura("CN320","Ciencias Naturales");
      ListaAsignatura.Add(a5);

      Asignatura a6 = new Asignatura("Cl120","Caligrafia");
      ListaAsignatura.Add(a6);
    }
     public void ListarEstudiantes()
    {
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("Lista de Alumnos");
        Console.WriteLine("****************");
        
        foreach (var estudiantes in ListaEstudiantes)
        {
          Console.WriteLine(estudiantes.CodigoEstudiante + " | " + estudiantes.Nombre + " | " + estudiantes.Apellido);
        }
        Console.ReadLine();
    }
    public void ListarAsignatura()
    {
        Console.Clear();
        Console.WriteLine("********************");
        Console.WriteLine("Lista de Asignaturas");
        Console.WriteLine("********************");
        
        foreach (var asignatura in ListaAsignatura)
        {
          Console.WriteLine(asignatura.Codigo + " | " + asignatura.NombreAsignatura);
        }
        Console.ReadLine();
    }

    public void ListarUsuario()
    {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("Lista de Usuarios Maestros");
        Console.WriteLine("**************************");
         
        foreach (var usuario in ListaUsuario)
        {
          Console.WriteLine( usuario.Codigo + " | " + usuario.Profesion + " | " + usuario.Nombre + " | " + usuario.Apellido);
        }
        Console.ReadLine();
    }
     public void ingresarNotas()
    {
      Console.Clear();
      Console.WriteLine("********************");
      Console.WriteLine("Ingreso de las Notas");
      Console.WriteLine("********************");
      Console.WriteLine("");
      Console.WriteLine("Ingrese el Nombre del Estudiante: ");
      string nombre = Console.ReadLine();

      Estudiantes estudiante = ListaEstudiantes.Find(e => e.Nombre.ToLower() == nombre);
      if (estudiante == null)
      {
        Console.WriteLine("Estudiante no encontrado");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Estudiante: " + estudiante.Nombre + " | " + estudiante.Apellido);
        Console.WriteLine("");
      }
      Console.ReadLine();

      foreach (var asignatura in ListaAsignatura)
      {
        Console.WriteLine("*****************************");
        Console.WriteLine("Asignatura: " + asignatura.NombreAsignatura);
        Console.WriteLine("*****************************");
        Console.WriteLine("");
        Console.WriteLine("Ingrese las 4 notas obtenidas");
        Console.WriteLine("");
        Console.WriteLine("Nota 1: ");
        asignatura.NotaA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 2: ");
        asignatura.NotaB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 3: ");
        asignatura.NotaC = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 4: ");
        asignatura.NotaD = Int32.Parse(Console.ReadLine());

        asignatura.Notapromedio = (asignatura.NotaA + asignatura.NotaB + asignatura.NotaC + asignatura.NotaD)/4;
      }
      foreach (var nota in ListaAsignatura)
      {
        Console.WriteLine("El promedio es de: " + nota.Notapromedio + " en la clase de " + nota.NombreAsignatura);
      }
      Console.ReadLine();
    }

    public void Notafinales()
    {
      double suma = 0;
      Console.Clear();
      Console.WriteLine("****************");
      Console.WriteLine("Calicacion Final");
      Console.WriteLine("****************");
      Console.WriteLine("Ingrese el Nombre del Estudiante: ");
      string nombre = Console.ReadLine();

      Estudiantes estudiante = ListaEstudiantes.Find(e => e.Nombre.ToLower() == nombre);
      if (estudiante == null)
      {
        Console.WriteLine("Estudiante no encontrado");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Estudiante: " + estudiante.Nombre + " | " + estudiante.Apellido);
        Console.WriteLine("");
      }
      foreach (var nota in ListaAsignatura)
      {
        Console.WriteLine("EL Promedio final es de: " + nota.Notapromedio + " en la clase de " + nota.NombreAsignatura);
        suma += nota.Notapromedio / 6;
      }
      Console.WriteLine(""); 
      Console.WriteLine("EL Promedio final es de: " + suma.ToString("N2"));
      Console.ReadLine();
     } 
     public void IngresoUsuario()
       {
            Console.Clear();
            Console.WriteLine("****************");
            Console.WriteLine("Inicio de sesion");
            Console.WriteLine("****************");
            Console.WriteLine("");
            Console.WriteLine("Ingrese Usuario");
            string usuario = Console.ReadLine();
            Usuario usuario1 = ListaUsuario.Find(u => u.Nombre.ToLower() == usuario);
            if (usuario1 == null)
            {
            Console.WriteLine("Usuario no encontrado");
            Console.ReadLine();
            return; 
            }else
            {
                Console.WriteLine("Bienvenido : " +"Profesor(a) " + usuario1.Nombre + " | " + usuario1.Apellido);
                Console.WriteLine("");
            }
            Console.ReadLine();
        }            
}