using System;
using System.Collections;

namespace TareaUsodeEstructurasDedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola que solicite las calificaciones de una lista predefinida de estudiantes y posteriormente muestre dicha lista ordenada ascendentemente por nombre de estudiante.

            List<Alumnos> alumnos = new List<Alumnos>();
            

            bool finalizado = true;

            while (finalizado)
            {
                Alumnos estudiante = new Alumnos();
                Console.WriteLine("Ingrese el nombre del alumno: ");
                estudiante.nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la calificación del alumno {estudiante.nombre}: ");
                estudiante.calificacion = int.Parse( Console.ReadLine() );

                alumnos.Add(estudiante);
                int informacion;
                Console.WriteLine("Quiere seguir agregando información? \n1- Continuar\n2- Finalizar" );
                informacion = int.Parse(Console.ReadLine());
                if (informacion == 2)                {

                    alumnos.Sort((a, b) => string.Compare(a.nombre, b.nombre));
                    foreach (Alumnos item in alumnos)
                    {
                        Console.WriteLine($"{item.nombre} - {item.calificacion}");
                    }
                    finalizado = false;
                }

            }
    

        }


        public class Alumnos()
        {
            public string nombre { get; set; }
            public int calificacion { get; set; }
        }
    }
}
