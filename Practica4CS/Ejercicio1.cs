using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            decimal sueldo, total = 0;
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Ingrese el sueldo del empleado N°"+ i);
                decimal.TryParse(Console.ReadLine(),out sueldo);
                total = total + sueldo;
            }
            Console.WriteLine("El total de sueldos es: {0}", total.ToString("C2"));
            Console.WriteLine("El promedio de sueldos es: {0}", (total/20).ToString("C2"));
            Console.ReadKey();
        }
    }
}
