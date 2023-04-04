using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Producto
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        // Constructor
        public Producto(string nombre, int cantidad, double precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        // Método abstracto para calcular el valor del inventario del producto
        public abstract double CalcularValorInventario();
    }
}
