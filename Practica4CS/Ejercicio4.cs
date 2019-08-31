using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int contador = 0;
            decimal total = 0, ventas = 0, bonificación;
            do
            {
                Console.WriteLine("Ingrese las ventas realizadas (pulse -1 para salir)");
                decimal.TryParse(Console.ReadLine(), out ventas);
                int VenCon = Convert.ToInt32(ventas);
                contador = contador + VenCon;
                total = total + ventas;
            } while (ventas != -1);
            total = total + 1;
            bonificación = total * 0.05m;
            Console.WriteLine("Total de ventas realizadas: " + contador);
            Console.WriteLine("Venta total: " + total.ToString("C2"));
            Console.WriteLine("Bonificación (5%): " + bonificación.ToString("C2"));
            Console.ReadKey();
        }
    }
}
