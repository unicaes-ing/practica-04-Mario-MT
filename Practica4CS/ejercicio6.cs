using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            int i = 0;
            double TS = 0, GT = 0;
            string mensaje = "";
            do
            {
                Console.WriteLine("Ingrese el total de ventas de la sucursal {0}", i + 1);
                Double.TryParse(Console.ReadLine(),out TS);
                mensaje += "Cantidad sucursal " + (i+1) + ":" + TS + "\n";
                GT += TS;
                i++;
            } while (TS != 0);
            Console.WriteLine(mensaje);
            Console.WriteLine("Cantidad global: {0:N2} Promedio: {1:N2}", GT, GT / i);
            Console.ReadKey();
        }
    }
}
