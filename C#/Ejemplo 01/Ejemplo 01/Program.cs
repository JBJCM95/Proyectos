using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01
{
    internal class Program
    {
        static void Main(string[] args)
        //	Diseñar un programa en C de acuerdo al enunciado: A un trabajador le pagan según sus horas y una tarifa de pago por horas.  
        //Si la cantidad de horas trabajadas es mayor a 40 horas. La tarifa se incrementa en un 50% para las horas extras.
        //Calcular el salario del trabajador dadas las horas trabajadas y la tarifa.

        {
            double salario1, salario2, horas, tarifa;

            Console.WriteLine("Horas trabajadas: ");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Tarifa por hora:");
            tarifa = double.Parse(Console.ReadLine());
            if (horas > 40)
            {
                salario1 = (40 * tarifa) + ((horas - 40) * (tarifa * 1.5));
                Console.WriteLine("El salario del trabajo es: " + salario1);
            }
            else
            {
                salario2 = horas * tarifa;
                Console.WriteLine("El salario del trabajador es: " + salario2);
    
            }

            Console.ReadKey();



        }
    }
}
