using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese nombre del cliente: ");
            string cliente = Console.ReadLine();
            Console.WriteLine("\nBienvenido: "+cliente);

            Console.WriteLine("\nIngrese su saldo disponible (S/): ");
            double saldo;
            if (!double.TryParse(Console.ReadLine(), out saldo))
            {
                Console.WriteLine("Por favor, ingrese un saldo válido.");
                Console.ReadKey();
                return;
            }

            string producto;
            double precio;

            if (saldo > 0)
            {
                Console.WriteLine("\n*** MENÚ DE PRODUCTOS ***");
                Console.WriteLine("\n1. Auriculares - S/ 85.00");
                Console.WriteLine("2. Teclado RBG - S/ 120.00");
                Console.WriteLine("3. Monitor 24 pulgadas - S/ 550.00");

                Console.WriteLine("\nIngrese el número de producto a seleccionar: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        producto = "Auriculares";
                        precio = 85.00;
                        break;
                    case 2:
                        producto = "Teclado RBG";
                        precio = 120.00;
                        break;
                    case 3:
                        producto = "Monitor 24 pulgadas";
                        precio = 550.00;
                        break;
                    default:
                        Console.WriteLine("Codigo de producto no válido");
                        Console.ReadKey();
                        return;
                }

                if (precio > 100)
                {
                    precio = precio * 0.90;
                }
                Console.WriteLine($"\nProducto seleccionado: {producto}");
                Console.WriteLine($"\nPrecio final del producto es de: S/ {precio:0.00}");
                Console.Write("\n¿Desea realizar la compra? (S/N): ");
                string respuesta = Console.ReadLine().ToUpper();

                if (respuesta == "S")
                {
                    if (saldo >= precio)
                    {
                        saldo = saldo - precio;
                        Console.WriteLine($"\nCompra realizada con éxito, su nuevo saldo es de: S/ {saldo:0.00}");
                        Console.WriteLine("\n¡¡Gracias por su compra!!");
                    }
                    else
                    {
                        Console.WriteLine("Compra rechazada, saldo insuficiente");
                    }
                }
                else
                {
                    Console.WriteLine("\nCompra cancelada por el usuario.");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nCompra rechazada, saldo insuficiente.");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
            return;
        } 
    }
}
