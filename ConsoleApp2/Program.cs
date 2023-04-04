using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            // Crear productos y agregarlos al inventario
            ProductoElectronico laptop = new ProductoElectronico("Laptop", 5, 800, "Dell");
            ProductoElectronico celular = new ProductoElectronico("Celular", 10, 400, "Samsung");
            Inventario inventario = new Inventario();
            inventario.AgregarProducto(laptop);
            inventario.AgregarProducto(celular);

            // Calcular valor total del inventario y mostrarlo en pantalla
            double valorTotalInventario = inventario.CalcularValorTotalInventario();
            Console.WriteLine("Valor total del inventario: $" + valorTotalInventario);
        }
    }
}
