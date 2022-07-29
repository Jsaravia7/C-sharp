using System;

namespace NotasEscolares
{
    class Program
    {
       static void Main(string[] arg)
       {
        Notas datos = new Notas();
        string opcion = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("Escuela Republica de Alemania");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("Sistema de Notas Escolares");
            Console.WriteLine("**************************");
            Console.WriteLine("1. -- Inicio de sesion");
            Console.WriteLine("2. -- Lista de Docentes");
            Console.WriteLine("3. -- Mostrar Estudiantes");
            Console.WriteLine("4. -- Mostrar Asignaturas");
            Console.WriteLine("5. -- Ingreso de Notas");
            Console.WriteLine("6. -- Notas Finales");
            Console.WriteLine("0. -- Salir");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una de la opciones: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                     datos.IngresoUsuario();
                     break;
                case "2":
                     datos.ListarUsuario();
                     break;
                case "3":
                     datos.ListarEstudiantes();
                     break;
                case "4":
                     datos.ListarAsignatura();
                     break;
                case "5":
                     datos.ingresarNotas();
                     break;
                case "6":
                     datos.Notafinales();
                     break;     
                default:
                break;
            }
            if(opcion == "0")
            {
                break;
            }
         }
       }
    }
}
