using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public  List<Producto> ListadeProductos { get; set; }

    public List<Cliente> ListadeClientes { get; set; }

    public List<Vendedor> ListadeVendedores { get; set; }

    public List<Orden> ListaOrdenes { get; set; }


    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        CargarVendedores();

        ListaOrdenes = new List<Orden>();
    }
    private void CargarVendedores()
    {
        Vendedor v1 = new Vendedor(1,"Maria","v001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2,"Roberto","v002");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3,"Luis","v003");
        ListadeVendedores.Add(v3);
    }
    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1,"Juan","9960-9407");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2,"Pedro","9960-9409");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(1,"Juan","9960-9407");
        ListadeClientes.Add(c3);
    }
    private void cargarProductos()
    {
      Producto p1 = new Producto(1,"Mouse",250);
      ListadeProductos.Add(p1);

      Producto p2 = new Producto(2,"Teclado",350);
      ListadeProductos.Add(p2);

      Producto p3 = new Producto(3,"Monitor",4000);
      ListadeProductos.Add(p3);
    }
    public void CrearOrden()
    {
        Console.WriteLine("*************");
        Console.WriteLine("Creando Orden");
        Console.WriteLine("*************");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();
        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        if (cliente == null)
        {
          Console.WriteLine("Cliente no encontrado");
          Console.ReadLine();
          return; 
        }else
        {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string CodigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(c => c.Codigo.ToString() == CodigoVendedor);
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
        }else
        {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;
         
        Orden nuevaOrden = new Orden(1,DateTime.Now,"SPS" + nuevoCodigo,cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
            if (producto == null)
            {
            Console.WriteLine("Producto no encontrado"); 
            Console.ReadLine();
             }else
             {
                Console.WriteLine("Producto Agregado: " + producto.Descripcion + " con precio de: " + producto.Precio + " Lempiras");
                nuevaOrden.AgregarProducto(producto);
             }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if(continuar.ToLower() == "n")
            {
                break;
            }
        }   
        Console.WriteLine("");
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();
    }
     public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("******************");
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("******************");
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }
            Console.ReadLine();
    }
     public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("******************");
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("******************");
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }
            Console.ReadLine();
    }
    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("******************");
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("******************");
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }
            Console.ReadLine();
    }
}