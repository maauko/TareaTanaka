using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProductoElectronico : Producto
    {
        // Propiedades
        public string Marca { get; set; }

        // Constructor
        public ProductoElectronico(string nombre, int cantidad, double precio, string marca) : base(nombre, cantidad, precio)
        {
            Marca = marca;
        }

        // Implementación del método abstracto para calcular el valor del inventario del producto
        public override double CalcularValorInventario()
        {
            return Cantidad * Precio;
        }
    }
}
