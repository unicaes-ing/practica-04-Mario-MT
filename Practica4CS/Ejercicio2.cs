using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4CS
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            double calificacion, asis, asistenciaR = 0, calificacionR = 0, notasA = 0;
            int Cestu;
            Console.WriteLine("Programación estructurada");
            Console.WriteLine("¿Cuantos alumnos son?");
            int.TryParse(Console.ReadLine(), out Cestu);
            for (int i = 0; i < Cestu; i++)
            {
                Console.WriteLine("Ingrese la calificación del alumno N°{0}", i+1);
                double.TryParse(Console.ReadLine(), out calificacion);
                Console.WriteLine("Ingrese la asitencia (1 a 100) del alumno N°{0}", i+1);
                double.TryParse(Console.ReadLine(), out asis);
                if (calificacion >= 7 && asis >= 75)
                {
                    Console.WriteLine("Aprobado");
                    notasA = notasA + 1;
                }
                else
                {
                    if (asis < 75)
                    {
                        Console.WriteLine("Reprobado por asistencia");
                        asistenciaR = asistenciaR + 1;
                    }
                    else
                    {
                        if (calificacion < 7)
                        {
                            Console.WriteLine("Reprobado por calficación");
                            calificacionR = calificacionR + 1;
                        }
                    }
                }

            }
                Console.WriteLine("los alumnos reprobados son: {0}", (calificacionR+asistenciaR));
                Console.WriteLine("los alumnos aprobados son: {0}", notasA);
                Console.ReadKey();
        }
    }
}
