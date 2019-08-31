using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            string Nom;
            int vocales = 0;
            Console.WriteLine("Ingresa tu nombre");
            Nom = Console.ReadLine();
            for (int i = 0; i < Nom.Length; i++)
            {
                if (Nom[i] == 'a' ||Nom[i] == 'A' ||Nom[i] == 'á' ||Nom[i]== 'Á')
                {
                    vocales = vocales + 1;
                }
                if (Nom[i] == 'e' ||Nom[i] == 'E' ||Nom[i] == 'é' ||Nom[i] == 'É')
                {
                    vocales = vocales + 1;
                }
                if (Nom[i] == 'i' ||Nom[i] == 'I' ||Nom[i] == 'í' ||Nom[i] == 'Í')
                {
                    vocales = vocales + 1;
                }
                if (Nom[i] == 'o' ||Nom[i] == 'O' ||Nom[i] == 'ó' ||Nom[i] == 'Ó')
                {
                    vocales = vocales + 1;
                }
                if (Nom[i] == 'u' ||Nom[i] == 'U' ||Nom[i] == 'ú' ||Nom[i] == 'Ú')
                {
                    vocales = vocales + 1;
                }

            }
            Console.WriteLine("Su nombre tiene : {0} vocales", vocales);
            Console.ReadKey();
        }
    }
}