using System;

namespace Productos
{
    public class Producto
    {
        public string  ? Nombre { get; set; }
        public float Precio { get; set; }
        public int Inventario { get; set; }
        public List<string> Clientes { get; set; }
    }

    public Producto(string ? nombre, float precio, int inventario, List<string> clientes)
    {
        Nombre = nombre;
        Precio = precio;
        Inventario = inventario;
        Clientes = clientes;
    }

    public void mostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, \nPrecio: {Precio}, \nInventario: {Inventario}");
        }

    public void actualizarPrecio()
        {

        }

    public void actualizarCantidad()
        {

        }

    public void actualizarListClientes()
        {

        }
}