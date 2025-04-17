using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD_DE_APRENDIZAJE_SEMANA_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido alumno: "+nombre);

            Console.WriteLine("Ingrese su edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                // Éxito: edad es un número
                if (edad >= 18)
                    Console.WriteLine("Cumple con la edad requerida");
                else
                    Console.WriteLine("El alumno es menor de edad");
                return;
            }
            else
            {
                // Error: el usuario escribió texto no válido
                Console.WriteLine("Edad no válida");
                Console.ReadKey();
                return;

            }
                
            Console.WriteLine("Ingrese su nota: ");
            int nota = int.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 9)
                Console.WriteLine("Desaprobado");
            else if (nota >= 10 && nota <= 12)
                Console.WriteLine("Suficiente");
            else if (nota >= 13 && nota <= 15)
                Console.WriteLine("Bien");
            else if (nota >= 16 && nota <= 18)
                Console.WriteLine("Muy bien");
            else if (nota >= 19 && nota <= 20)
                Console.WriteLine("Excelente");
            else
                Console.WriteLine("Nota no valida");

            Console.ReadKey();
        }
    }
}
