using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        // Método para agregar un producto al inventario
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        // Método para calcular el valor total del inventario
        public double CalcularValorTotalInventario()
        {
            double valorTotal = 0;

            foreach (Producto producto in productos)
            {
                valorTotal += producto.CalcularValorInventario();
            }

            return valorTotal;
        }
    }
}
