using System;

namespace InfoProducto
{
    public class Producto
    {
        public string  ? Nombre { get; set; }
        public float Precio { get; set; }
        public int Inventario { get; set; }
        public List<string> Clientes { get; set; }

        public Producto(string ? nombre, float precio, int inventario, List<string> clientes)
        {
            Nombre = nombre;
            Precio = precio;
            Inventario = inventario;
            Clientes = clientes;
        }
    }

}