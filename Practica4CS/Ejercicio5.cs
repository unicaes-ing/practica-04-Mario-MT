using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string Cvalida = "17112018", clave;
            int n = 0;
            do
            {
                Console.WriteLine("Ingrese su contraseña de acceso");
                clave = Console.ReadLine();
                if (clave != Cvalida)
                {
                    Console.WriteLine("\n Contraseña incorrecta");
                    n++;
                    Console.WriteLine("Pista: "+ Cvalida.Substring(0,n));
                }
            } while (clave != Cvalida && n!= 3);
            if (n == 3 && clave != Cvalida)
            {
                Console.WriteLine("\n Fin de los intentos");
            }
            else
            {
                Console.WriteLine("Contraseña correcta");
            }
            Console.ReadKey();
        }
    }
}
