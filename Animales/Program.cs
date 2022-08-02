using System;

namespace Animales
{
    class program
    {
        static void Main(string[] args)
        {
            
            Perro p = new Perro();
            p.Nombre = "Perro";
            p.Patas = "4";
            p.Esdomestico = true;
            if(p.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            p.Caminar(); 
            p.comer();
            p.Ladrar();
            Console.WriteLine(p.Patas + " Patas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + p.Nombre);
            Console.WriteLine("**************");

            Console.WriteLine("");
            Gallina g = new Gallina();
            g.Nombre = "Gallina";
            g.Alas = "2";
            g.Esdomestico = true;
            if(p.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            g.comer();
            g.Volar();
            g.Kikikear();
            Console.WriteLine(g.Alas + " Alas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + g.Nombre);
            Console.WriteLine("**************");

            Console.WriteLine("");
            Gato ga = new Gato();
            ga.Nombre = "Gato";
            ga.Patas = "4";
            ga.Pelaje = "Peludo";
            ga.Esdomestico = true;
            if(p.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            ga.comer();
            ga.Caminar();
            ga.Maullar();
            Console.WriteLine(ga.Patas + " Patas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + ga.Nombre);
            Console.WriteLine("**************");

            Console.WriteLine("");
            Rana r = new Rana();
            r.Nombre = "Rana";
            r.Patas = "4";
            r.Vive = "Viven en el agua";
            r.Esdomestico = false;
            if(r.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            r.comer();
            r.Atrapar();
            r.Sonido();
            Console.WriteLine(r.Patas + " Patas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + r.Nombre);
            Console.WriteLine("**************");

            Console.WriteLine("");
            Zancudo z = new Zancudo();
            z.Nombre = "Zancudo";
            z.Alas = "2";
            z.Esdomestico = false;
            if(z.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            z.Inquieto();
            z.Alimento();
            z.Zumbido();
            Console.WriteLine(z.Alas + " Alas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + z.Nombre);
            Console.WriteLine("**************");

            Console.WriteLine("");
            PezDorado pz = new PezDorado();
            pz.Nombre = "Pez Dorado";
            pz.Aletas = "2";
            pz.Esdomestico = true;
            if(pz.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            pz.Bañar();
            pz.Agallas();
            pz.Burbujas();
            Console.WriteLine(pz.Aletas + " Aletas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + pz.Nombre);
            Console.WriteLine("**************");

             Console.WriteLine("");
            Cocodrilo c = new Cocodrilo();
            c.Nombre = "Cocodrilo";
            c.Patas = "4";
            c.Esdomestico = false;
            if(c.Esdomestico == true)
            {
                Console.WriteLine("Es un animal domestico");
            }else
            {
                Console.WriteLine("No es animal Domestico");
            }
            Console.WriteLine("------------");
            c.comer();
            c.Gruñir();
            c.Sangre();
            c.Peligroso();
            Console.WriteLine(c.Patas + " Patas");
            Console.WriteLine("**************");
            Console.WriteLine("Resultado es: " + c.Nombre);
            Console.WriteLine("**************");
        }
        }
    }
