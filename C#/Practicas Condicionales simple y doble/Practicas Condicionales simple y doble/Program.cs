using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Condicionales_simple_y_doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 60)
            {
                Console.WriteLine("ES MAYOR DE EDAD");
            }
            else
            {
                Console.WriteLine("ES MENOR DE EDAD");
            }
            Console.ReadKey();
        }
    }
}
