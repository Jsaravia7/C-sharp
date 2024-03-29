using System;
using System.Collections.Generic;
public class Orden
{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumerodeOrden { get; set; }

    public Cliente Cliente { get; set; }

    public Vendedor Vendedor { get; set; }

    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }

    public double Subtotal { get; set; }

    public double Impuesto { get; set; }

    public double Total { get; set; }

    public double totalp { get; set; }
    public Orden(int codigo, DateTime fecha, string numerodeorden, Cliente cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = Fecha;
        NumerodeOrden = numerodeorden;
        Cliente = cliente;
        Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }
   public void AgregarProducto(Producto producto)
   {
      int nuevoCodigo = ListaOrdenDetalle.Count + 1;
      int cantidad = 1;
      double isv = 0.15;

      OrdenDetalle o = new OrdenDetalle(nuevoCodigo, 1 ,producto);
      ListaOrdenDetalle.Add(o);

      Impuesto = (producto.Precio * isv);
      totalp = Impuesto + producto.Precio;
      Total +=  Impuesto + producto.Precio;
      Subtotal += cantidad * producto.Precio;
      
   }
}